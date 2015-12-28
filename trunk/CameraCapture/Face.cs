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

namespace LiveFaceDetection
{
    public partial class Face : Form
    {
        public bool added;

        public Face()
        {
            InitializeComponent();
            added = false;
            //this.label.Size = new Size(188, 20);
        }

        public Face(Bitmap image, String label = "")
        {
            InitializeComponent();
            added = false;

            Image<Gray, byte> I = new Image<Gray, byte>(image).Resize(imageBox.Size.Width, imageBox.Size.Height, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            I._EqualizeHist();
            imageBox.Image = I;

            if (label == "Unknown Face")
            {
                textBox.Visible = true;
                button.Visible = true;
            }
            else
            {
                this.label.Text = label;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                String fileName = textBox.Text;
                while (File.Exists("E:/Faces/" + fileName + ".jpg"))
                    fileName = fileName + "_1";

                this.imageBox.Image.Save("E:/Faces/" + fileName + ".jpg");
                this.added = true;
                this.Close();
            }
        }
    }
}
