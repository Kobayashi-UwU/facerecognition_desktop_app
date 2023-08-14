using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace face_regg_window_forms_app
{
    public partial class serverchecking : Form
    {
        public serverchecking()
        {
            InitializeComponent();
        }

        private async void serverchecking_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send the HTTP POST request to the server's login endpoint
                    var response = await client.GetAsync("http://172.20.10.7:3001/status");

                    // Check the response status
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // The login was successful
                        // Create an instance of the FaceRecognition form
                        login loginForm = new login();

                        // Show the FaceRecognition form
                        loginForm.Show();

                        // Optionally, hide or close the login form
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("ERROR404");
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Server is down: " + ex.Message);
                }
            }
            

        }
    }
}
