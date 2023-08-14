using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using FaceRecognition;


namespace face_regg_window_forms_app
{
    public partial class FaceRecognition : Form
    {

        private Size formOriginalSize;
        private Rectangle rjButtonp1;
        private Rectangle rjButtonp2;
        private Rectangle rjButtonp3;
        private Rectangle rjButtonSignout;
        private Rectangle textBoxResponseIn;
        private Rectangle displaypicIn;
        private Rectangle labelp1;
        private Rectangle cboCameraIn;

        FaceRec faceRec = new FaceRec();
        public FaceRecognition()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            rjButtonp1 = new Rectangle(rjButton1.Location, rjButton1.Size);
            rjButtonp2 = new Rectangle(rjButton2.Location, rjButton2.Size);
            rjButtonp3 = new Rectangle(rjButton3.Location, rjButton3.Size);
            rjButtonSignout = new Rectangle(signoutButt.Location, signoutButt.Size);
            textBoxResponseIn = new Rectangle(textBoxResponse.Location, textBoxResponse.Size);
            displaypicIn = new Rectangle(displaypic.Location, displaypic.Size);
            labelp1 = new Rectangle(label1.Location, label1.Size);
            cboCameraIn = new Rectangle(cboCamera.Location, cboCamera.Size);
        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(rjButton1, rjButtonp1);
            resize_Control(rjButton2, rjButtonp2);
            resize_Control(rjButton3, rjButtonp3);
            resize_Control(signoutButt, rjButtonSignout);
            resize_Control(textBoxResponse, textBoxResponseIn);
            resize_Control(displaypic, displaypicIn);
            resize_Control(label1, labelp1);
            resize_Control(cboCamera, cboCameraIn);
        }
        private Dictionary<Control, float> originalFontSizes = new Dictionary<Control, float>();

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)this.Width / (float)formOriginalSize.Width;
            float yRatio = (float)this.Height / (float)formOriginalSize.Height;
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            // Resize the font as well
            if (!originalFontSizes.ContainsKey(c))
            {
                originalFontSizes[c] = c.Font.Size;
            }

            float currentFontSize = originalFontSizes[c];
            float newXFontSize = currentFontSize * xRatio;
            float newYFontSize = currentFontSize * yRatio;
            c.Font = new Font(c.Font.FontFamily, Math.Min(newXFontSize, newYFontSize), c.Font.Style);
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;


        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            // Adjust the size mode of the pictureBox to Zoom
            displaypic.SizeMode = PictureBoxSizeMode.Zoom;

            // Assign the cloned frame to the pictureBox
            displaypic.Image = frame;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaypic.BorderStyle = BorderStyle.FixedSingle;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cboCamera.Items.Add(Device.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event handler code goes here
        }


        /*
        private async void button1_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                // Take a screenshot of the current frame
                Bitmap screenshot = (Bitmap)displaypic.Image.Clone();

                // Create a unique filename using a timestamp
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string fileName = $"screenshot_{timestamp}.jpg";

                // Define the file path for saving the screenshot
                string filePath = Path.Combine(@"D:\", fileName);

                // Save the screenshot to the specified file path
                screenshot.Save(filePath);

                // Convert the image to Base64
                string base64Image = ConvertImageToBase64(filePath);

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://cc84-124-122-21-31.ngrok-free.app/face-recognition");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        imageBase64 = base64Image,
                        cameraSide = "DEFAULT"
                    });
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    Console.WriteLine(result);

                }

                /*
                // Prepare the data for the API request
                var requestData = new Dictionary<string, string>
                {
                    { "cameraSide", "DEFAULT_BACKEND_CAMERA" }
                };

                using (HttpClient client = new HttpClient())
                {
                    // Prepare the HTTP request content with the Base64 image data
                    var requestContent = new MultipartFormDataContent();
                    requestContent.Add(new StringContent(base64Image), "imageBase64");
                    /*
                    foreach (var entry in requestData)
                    {
                        requestContent.Add(new StringContent(entry.Value), entry.Key);
                    }

                    try
                    {
                        // Send the HTTP POST request to the server's API endpoint
                        var response = await client.PostAsync("https://cc84-124-122-21-31.ngrok-free.app/face-recognition", requestData);

                        // Check the response status
                        if (response.IsSuccessStatusCode)
                        {
                            string responseText = await response.Content.ReadAsStringAsync();
                            UpdateResponseTextBox(responseText);
                        }
                        else
                        {
                            MessageBox.Show("Failed to upload the screenshot. Error: " + response.StatusCode);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during the API request. " + ex.Message);
                    }
                } 
    }
            else
            {
                MessageBox.Show("Camera is not open.");
            }
        }
        */
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private string ConvertImageToBase64(string filePath)
        {
            Image imageArray = Image.FromFile(filePath);
            string base64ImageRepresentation = Convert.ToBase64String(ImageToByteArray(imageArray));
            return base64ImageRepresentation;
        }

        private void UpdateResponseTextBox(string responseText)
        {
            // Append the new response to the existing text
            textBoxResponse.AppendText(responseText + Environment.NewLine);

            // Scroll to the end of the text
            textBoxResponse.ScrollToCaret();
        }


        private void rjButton1_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                /*
                // Take a screenshot of the current frame
                Bitmap screenshot = (Bitmap)displaypic.Image.Clone();

                // Create a unique filename using a timestamp
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string fileName = $"screenshot_{timestamp}.jpg";

                // Define the file path for saving the screenshot
                string filePath = Path.Combine(@"D:\", fileName);
                

                // Save the screenshot to the specified file path
                screenshot.Save(filePath);

                */

                string filePath = Path.Combine(@"D:\", "tester.jpg");

                // Convert the image to Base64
                string base64Image = ConvertImageToBase64(filePath);

                try
                {
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://172.20.10.7:3002/face-recognition");
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "POST";
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string json = new JavaScriptSerializer().Serialize(new
                        {
                            imageBase64 = base64Image,
                            cameraSide = "DEFAULT"
                        });
                        streamWriter.Write(json);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }

                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        UpdateResponseTextBox(result);
                        Console.WriteLine("API request successful!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send the API request. Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Camera is not open.");
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            // Stop the video capture
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                videoCaptureDevice = null;
            }

            // Clear the pictureBox
            displaypic.Image = null;
        }

        private void textBoxResponse_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void signoutButt_Click(object sender, EventArgs e)
        {
            // Create an instance of the Register form
            login registerForm = new login();

            // Display the Register form
            registerForm.Show();

            // Optionally, hide or close the login form
            this.Hide();
        }

        private void opencamera_Click(object sender, EventArgs e)
        {
            //faceRec.openCamera();
        }
    }
}
