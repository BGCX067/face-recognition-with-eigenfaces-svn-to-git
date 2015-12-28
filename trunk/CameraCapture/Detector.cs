using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.Structure;

namespace LiveFaceDetection
{
    class Detector
    {
        private CascadeClassifier csClassifier;
        //private HaarCascade haar;

        private double scaleFactor = 1.2;
        private int minNeighbors = 2;
        private int windowSizeX = 50;
        private int windowSizeY = 50;

        private Rectangle[] faces;
        private int numberOFFaces;
        public Bitmap[] ExtractedFaces;

        public Detector()
        {
            csClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
            //haar = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
        }

        public Rectangle[] Detect(Image<Bgr, Byte> image, double scaleFactor, int minNeighbors, int windowSizeX, int windowSizeY)
        {
            Image<Gray, byte> grayImage = image.Convert<Gray, byte>();
            Graphics FaceCanvas;
            Bitmap BmpInput = grayImage.ToBitmap();

            this.scaleFactor = scaleFactor;
            this.minNeighbors = minNeighbors;
            this.windowSizeX = windowSizeX;
            this.windowSizeY = windowSizeY;

            faces = csClassifier.DetectMultiScale(grayImage, this.scaleFactor, this.minNeighbors,
                new Size(this.windowSizeX, this.windowSizeY), new Size(this.windowSizeX, this.windowSizeY));

            if (faces.Length > 0)
            {
                this.numberOFFaces = faces.Length;
                ExtractedFaces = new Bitmap[numberOFFaces];

                for (int i = 0; i < numberOFFaces; i++)
                {
                    ExtractedFaces[i] = new Bitmap(faces[i].Width, faces[i].Height);
                    FaceCanvas = Graphics.FromImage(ExtractedFaces[i]);
                    FaceCanvas.DrawImage(BmpInput, 0, 0, faces[i], GraphicsUnit.Pixel);
                }

            }

            return faces;
        }
    }
}
