using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace face_regg_window_forms_app
{
    public partial class faceRecognition1 : Form
    {
        private VideoCapture _capture;
        private CascadeClassifier _faceCascade;

        public faceRecognition1()
        {
            InitializeComponent();
            _faceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            _capture.Read(frame);

            if (!frame.IsEmpty)
            {
                // Resize the frame to fit the PictureBox while maintaining aspect ratio
                int targetWidth = pictureBox1.Width;
                int targetHeight = pictureBox1.Height;

                double aspectRatio = (double)frame.Width / frame.Height;
                int newWidth = (int)(targetHeight * aspectRatio);
                int newHeight = targetHeight;

                if (newWidth > targetWidth)
                {
                    newWidth = targetWidth;
                    newHeight = (int)(targetWidth / aspectRatio);
                }

                Mat resizedFrame = new Mat();
                CvInvoke.Resize(frame, resizedFrame, new Size(newWidth, newHeight));

                // Convert the resized frame to a Bitmap to display in PictureBox
                Bitmap bmp = resizedFrame.ToImage<Bgr, byte>().Bitmap;

                // Display the resized frame in PictureBox
                pictureBox1.Image = bmp;
            }
        }





        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_capture != null)
            {
                _capture.Dispose();
                _capture = null;
            }

            base.OnFormClosing(e);
        }

        private void btnOpenCamera_Click_1(object sender, EventArgs e)
        {
            if (_capture == null)
            {
                // Open camera
                _capture = new VideoCapture(0);

                if (_capture != null && _capture.Ptr != IntPtr.Zero)
                {
                    Application.Idle += ProcessFrame;
                }
            }
        }

        private void btnDetectFace_Click(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                Mat frame = new Mat();
                _capture.Read(frame);

                if (!frame.IsEmpty)
                {
                    // Detect faces in the frame
                    Rectangle[] faces = _faceCascade.DetectMultiScale(frame, 1.1, 3, Size.Empty);

                    foreach (var faceRect in faces)
                    {
                        // Crop the detected face
                        Mat faceMat = new Mat(frame, faceRect);

                        // Calculate the scaling factor for fitting the face inside PictureBox2
                        float scaleX = (float)pictureBox2.Width / faceMat.Width;
                        float scaleY = (float)pictureBox2.Height / faceMat.Height;
                        float scaleFactor = Math.Min(scaleX, scaleY);

                        // Resize the cropped face while maintaining aspect ratio
                        Mat resizedFace = new Mat();
                        CvInvoke.Resize(faceMat, resizedFace, Size.Empty, scaleFactor, scaleFactor, Inter.Linear);

                        // Convert the resized face to a Bitmap
                        Bitmap faceBitmap = resizedFace.ToImage<Bgr, byte>().Bitmap;

                        // Display the resized face in PictureBox2
                        pictureBox2.Image = faceBitmap;
                    }
                }
            }
        }



    }
}
