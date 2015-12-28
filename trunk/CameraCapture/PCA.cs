using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace LiveFaceDetection
{
    class PCA
    {
        private FaceRecognizer recognizer;
        private int numberOfComponents;
        private double threshold;
        private Image<Gray, byte>[] faces;
        private int size;

        String[] labels;

        public PCA(int numberOfComponents, double threshold = 100)
        {
            this.numberOfComponents = numberOfComponents;
            this.threshold = threshold;
            recognizer = new EigenFaceRecognizer(this.numberOfComponents, this.threshold);
        }

        public PCA()
        {
            this.threshold = 100;
            this.numberOfComponents = 0;
        }

        public void Train(DirectoryInfo dir, int threshold, int size = 60)
        {
            FileInfo[] listFile = dir.GetFiles();
            numberOfComponents = listFile.Length;
            this.size = size;
            this.threshold = threshold;

            faces = new Image<Gray,byte>[numberOfComponents];
            int[] faceNo = new int[numberOfComponents];
            this.labels = new String[numberOfComponents];
            int i = 0;

            foreach (FileInfo fi in listFile)
            {
                this.labels[i] = Path.GetFileNameWithoutExtension(fi.FullName).Split('_')[0];
                faceNo[i] = i;
                faces[i++] = new Image<Gray, byte>(fi.FullName).Resize(this.size, this.size, INTER.CV_INTER_CUBIC);
            }
            try
            {
                //MessageBox.Show("" + threshold);
                recognizer = new FisherFaceRecognizer(this.numberOfComponents, this.threshold);
                recognizer.Train(faces, faceNo);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public String Predict(Image<Gray, byte> image)
        {
            int faceNo = -1;
            if (numberOfComponents > 4)
            {
                image = image.Resize(this.size, this.size, INTER.CV_INTER_CUBIC);
                faceNo = recognizer.Predict(image).Label;
            }

            if (faceNo == -1)
                return "Unknown Face";
            else return labels[faceNo];
        }
    }
}
