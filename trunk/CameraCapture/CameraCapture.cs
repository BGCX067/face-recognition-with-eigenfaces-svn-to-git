using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;

namespace LiveFaceDetection
{
    public partial class CameraCapture : Form
    {
        private Capture capture;
        Image<Bgr, Byte> ImageFrame;
        private double scaleFactor = 1.2;
        private int minNeighbors = 2;
        private int windowSizeX = 50;
        private int windowSizeY = 50;

        private PCA faceRecognizer;
        private Detector detector;
        private Rectangle[] faces;
        private String[] faceLabels;

        private DirectoryInfo mainDir;

        public CameraCapture()
        {
            InitializeComponent();
        }
        
        private void ProcessFrame(object sender, EventArgs arg)
        {
            ImageFrame = capture.QueryFrame();

            if (ImageFrame != null)
                DetectFaces();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                if (btnStart.Text == "Pause")
                {
                    btnStart.Text = "Resume";
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    btnStart.Text = "Pause";
                    Application.Idle += ProcessFrame;
                }
            }
        }

        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }
        
        private void cbCamIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CamNumber = -1;
            CamNumber = int.Parse(cbCamIndex.Text);

            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture(CamNumber);
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            btnStart_Click(sender, e);
            btnStart.Enabled = true;
        }

        private void CameraCapture_Load(object sender, EventArgs e)
        {
            detector = new Detector();
            faceRecognizer = new PCA();
            mainDir = new DirectoryInfo("E:/Faces/");
            faceRecognizer.Train(mainDir, int.Parse(thresholdUpDown.Text)*100);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image InputImg = Image.FromFile(openFileDialog.FileName);
                ImageFrame = new Image<Bgr, byte>(new Bitmap(InputImg));
                CamImageBox.Image = ImageFrame;
                DetectFaces();
            }
        }

        private void DetectFaces()
        {
            scaleFactor = double.Parse(scaleFactorComboBox.Text);
            minNeighbors = int.Parse(minNeighborsComboBox.Text);
            windowSizeX = int.Parse(windowSizeXTextBox.Text);
            windowSizeY = int.Parse(windowSizeYTextBox.Text);

            faces = detector.Detect(ImageFrame, scaleFactor, minNeighbors, windowSizeX, windowSizeY);
            faceLabels = new String[faces.Length];

            Image<Bgr, byte> duplicateFrame = ImageFrame.Clone();

            if (faces.Length > 0)
            {
                for (int i = 0; i < faces.Length; i++)
                {
                    Image<Gray,byte> I = new Image<Gray, byte>(detector.ExtractedFaces[i]);
                    I._EqualizeHist();
                    faceLabels[i] = faceRecognizer.Predict(I);
                    if (faceLabels[i] == "Unknown Face")
                        duplicateFrame.Draw(faces[i], new Bgr(Color.Red), 3);
                    else duplicateFrame.Draw(faces[i], new Bgr(Color.Green), 3);
                }
            }

            CamImageBox.Image = duplicateFrame;
        }

        private void CamImageBox_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickedLocation = new Point(e.Location.X * ImageFrame.Width / CamImageBox.Width,
                e.Location.Y * ImageFrame.Height / CamImageBox.Height);

            if (faces != null)
            {
                for (int i = 0; i < faces.Length; i++)
                {
                    if (faces[i].Contains(clickedLocation))
                    {
                        Bitmap b = detector.ExtractedFaces[i];
                        Face f1 = new Face(b, faceLabels[i]);
                        f1.ShowDialog();
                        if (f1.added == true)
                            faceRecognizer.Train(mainDir, int.Parse(thresholdUpDown.Text)*100);
                        break;
                    }
                }
            }
        }

        private void thresholdUpDown_TextChanged(object sender, EventArgs e)
        {
            faceRecognizer.Train(mainDir, int.Parse(thresholdUpDown.Text)*100);
            DetectFaces();
        }

        private void CameraCapture_KeyPress(object sender, KeyPressEventArgs e)
        {
            // MessageBox.Show("" + e.KeyChar);
            if (e.KeyChar.ToString() == "+")
                thresholdUpDown.UpButton();
            else if (e.KeyChar.ToString() == "-")
                thresholdUpDown.DownButton();
        }

    }
}
