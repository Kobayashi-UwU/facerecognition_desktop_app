using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace face_regg_window_forms_app
{

    public partial class login : Form
    {
        private Size formOriginalSize;
        private Rectangle recButLogin;
        private Rectangle recButRegister;
        private Rectangle txtUseIn;
        private Rectangle txtPasIn;
        private Rectangle labelUse;
        private Rectangle labelReg;
        private Rectangle forgetpass;
        
        public login()
        {
          InitializeComponent();
          this.Resize += Form1_Resiz;
          formOriginalSize = this.Size;
          recButLogin = new Rectangle(customButton1.Location, customButton1.Size);
            recButRegister = new Rectangle(customButtonRegister1.Location, customButtonRegister1.Size);
            txtUseIn = new Rectangle(txtUsername.Location, txtUsername.Size);
            txtPasIn = new Rectangle(txtPassword.Location, txtPassword.Size);
            labelUse = new Rectangle(label1.Location, label1.Size);
            labelReg = new Rectangle(label2.Location, label2.Size);
            forgetpass = new Rectangle(linkForgetpassword.Location, linkForgetpassword.Size);
            txtUsername.Multiline = true;
            txtPassword.Multiline = true;

        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
          resize_Control(customButton1, recButLogin);
            resize_Control(customButtonRegister1, recButRegister);
            resize_Control(txtUsername, txtUseIn);
            resize_Control(txtPassword, txtPasIn);
            resize_Control(label1, labelUse);
            resize_Control(label2, labelReg);
            resize_Control(linkForgetpassword, forgetpass);
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



        private async void customButton1_Click(object sender, EventArgs e)
        {
            
            // The login was successful
            // Create an instance of the FaceRecognition form
            FaceRecognition faceRecognitionForm = new FaceRecognition();

            // Show the FaceRecognition form
            faceRecognitionForm.Show();

            // Optionally, hide or close the login form
            this.Hide();
            
            
            
            // Get the login credentials from the input fields
            //string username = txtUsername.Text;
            //string password = txtPassword.Text;

            /*
            string username = "kasinphat@gmail.com";
            string password = "pam40624";

            // Prepare the data for login
            var requestData = new Dictionary<string, string>
            {
                { "email", username },
                { "password", password }
                // Add any other necessary data for login
            };

            using (HttpClient client = new HttpClient())
            {
                // Convert the data to JSON format
                var content = new FormUrlEncodedContent(requestData);

                try
                {
                    // Send the HTTP POST request to the server's login endpoint
                    var response = await client.PostAsync("http://172.20.10.7:3001/auth/login", content);

                    // Check the response status
                    if (response.IsSuccessStatusCode)
                    {
                        // get respone back from server
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Global respons from server
                        GlobalResponse.ApiResponse = responseBody;

                        // Parse the responseData JSON into a JObject
                        JObject data = JObject.Parse(responseBody);

                        // Extract the "role" value from the responseData
                        string role = (string)data["role"];

                        if (role == "1")
                        {
                            // The login was successful
                            // Create an instance of the FaceRecognition form
                            FaceRecognition facerecForm = new FaceRecognition();

                            // Show the FaceRecognition form
                            facerecForm.Show();

                            // Optionally, hide or close the login form
                            this.Hide();
                        }

                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        // The server returned a Bad Request (400) status code, indicating a login error
                        var responseContent = await response.Content.ReadAsStringAsync();
                        if (responseContent.Contains("Password Incorrect"))
                        {
                            // Handle the case of wrong password here, show an error message or take appropriate action
                            MessageBox.Show("Username or Password incorrect");
                        }
                        else
                        {
                            // Handle other possible error messages returned by the server
                            MessageBox.Show("ERROR404");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR404");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the API request
                    MessageBox.Show("An error occurred during login. " + ex.Message);
                }
            }
            */
            

        }


        private void customButtonRegister1_Click(object sender, EventArgs e)
        {
            // Create an instance of the Register form
            register registerForm = new register();

            // Display the Register form
            registerForm.Show();

            // Optionally, hide or close the login form
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void linkForgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }

    public static class GlobalResponse
    {
        public static string ApiResponse { get; set; }
    }
}
