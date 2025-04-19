using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Presentation
{
    public partial class CameraCapture : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;

        public string CapturedImagePath { get; private set; }

        public CameraCapture()
        {
            InitializeComponent();
            this.Load += CameraCapture_Load;
            this.FormClosing += CameraCapture_FormClosing;
        }


        private void CameraCapture_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("❌ No se encontró ninguna cámara.");
                this.DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
            videoSource.Start();
        }

        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                currentFrame = (Bitmap)eventArgs.Frame.Clone();
                pbPreview.Image = (Bitmap)currentFrame.Clone();
            }
            catch (Exception ex)
            {
                // Por si algo revienta en el rendering
                Console.WriteLine("Error al procesar frame: " + ex.Message);
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (currentFrame != null)
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "captura_face.jpg");
                currentFrame.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                CapturedImagePath = path;

                MessageBox.Show("📸 Imagen capturada correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("⚠️ No se detectó ninguna imagen.");
            }
        }

        private void CameraCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}
