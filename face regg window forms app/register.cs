using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace face_regg_window_forms_app
{
    public partial class register : Form
    {
        private Size formOriginalSize;
        private Rectangle recButLogin;
        private Rectangle recButRegister;
        private Rectangle txtEmailIn;
        private Rectangle txtPasIn;
        private Rectangle txtPasConIn;
        private Rectangle txtFirstnameIn;
        private Rectangle txtLastnameIn;
        private Rectangle txtGenderIn;
        private Rectangle txtPersonalIn;
        private Rectangle labelp1;
        private Rectangle labelp2;
        private Rectangle labelp3;
        private Rectangle labelp4;
        private Rectangle labelp5;
        private Rectangle labelp6;
        private Rectangle labelp7;
        private Rectangle calenderIn;

        public register()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recButLogin = new Rectangle(customButton1.Location, customButton1.Size);
            recButRegister = new Rectangle(customButtonRegister1.Location, customButtonRegister1.Size);
            txtEmailIn = new Rectangle(txtEmail.Location, txtEmail.Size);
            txtPasIn = new Rectangle(txtPassword.Location, txtPassword.Size);
            txtPasConIn = new Rectangle(txtPasswordConfirm.Location, txtPasswordConfirm.Size);
            txtFirstnameIn = new Rectangle(txtFirstname.Location, txtFirstname.Size);
            txtLastnameIn = new Rectangle(txtLastname.Location, txtLastname.Size);
            txtGenderIn = new Rectangle(txtGender.Location, txtGender.Size);
            txtPersonalIn = new Rectangle(textPersonal.Location, textPersonal.Size);
            labelp1 = new Rectangle(label1.Location, label1.Size);
            labelp2 = new Rectangle(label2.Location, label2.Size);
            labelp3 = new Rectangle(label3.Location, label3.Size);
            labelp4 = new Rectangle(label4.Location, label4.Size);
            labelp5 = new Rectangle(label5.Location, label5.Size);
            labelp6 = new Rectangle(label6.Location, label6.Size);
            labelp7 = new Rectangle(label7.Location, label7.Size);
            calenderIn = new Rectangle(datePicker1.Location, datePicker1.Size);

        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(customButton1, recButLogin);
            resize_Control(customButtonRegister1, recButRegister);
            resize_Control(txtEmail, txtEmailIn);
            resize_Control(txtPassword, txtPasIn);
            resize_Control(txtPasswordConfirm, txtPasConIn);
            resize_Control(txtFirstname, txtFirstnameIn);
            resize_Control(txtLastname, txtLastnameIn);
            resize_Control(txtGender, txtGenderIn);
            resize_Control(textPersonal, txtPersonalIn);
            resize_Control(label1, labelp1);
            resize_Control(label2, labelp2);
            resize_Control(label3, labelp3);
            resize_Control(label4, labelp4);
            resize_Control(label5, labelp5);
            resize_Control(label6, labelp6);
            resize_Control(label7, labelp7);
            resize_Control(datePicker1, calenderIn);
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



        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Create an instance of the Register form
            login registerForm = new login();

            // Display the Register form
            registerForm.Show();

            // Optionally, hide or close the login form
            this.Hide();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            // Create an instance of the Register form
            login registerForm = new login();

            // Display the Register form
            registerForm.Show();

            // Optionally, hide or close the login form
            this.Hide();
        }

        private async void customButtonRegister1_Click(object sender, EventArgs e)
        {
            string passwordcheck1 = txtPassword.Text;
            string passwordcheck2 = txtPasswordConfirm.Text;
            if (passwordcheck1 == passwordcheck2)
            {
                // Get the login credentials from the input fields
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string passwordCon = txtPasswordConfirm.Text;
                string firstname = txtFirstname.Text;
                string lastname = txtLastname.Text;
                string gender = txtGender.Text;
                string dob = datePicker1.Text+"T00:00:00Z"; ;
               

                /*
                //string username = "kasinphat@gmail.com";
                //string password = "pam40624";

                // Prepare the data for login
                var requestData = new Dictionary<string, string>
                {
                    { "personalId" , "69420" },
                    { "email" , "tai242415597@gmail.com" },
                    { "password", "tai1234" } ,
                    { "firstname", "Panumeth" } ,
                    { "lastname", "kon" },
                    { "gender" , "Male" },
                    { "dob" , "2003-01-24T00:00:00Z" },
                };

                using (HttpClient client = new HttpClient())
                {
                    // Convert the data to JSON format
                    var content = new FormUrlEncodedContent(requestData);

                    try
                    {
                        // Send the HTTP POST request to the server's login endpoint
                        var response = await client.PostAsync("https://5589-202-28-7-92.ngrok-free.app/auth/register", content);

                        // Check the response status
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Register Successful, wait for confirmation from admin");

                            // Create an instance of the Register form
                            login registerForm = new login();

                            // Display the Register form
                            registerForm.Show();

                            // Optionally, hide or close the login form
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Register Fail");
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
            else
            {
                MessageBox.Show("Password not match");
            }

        }
    }
}
