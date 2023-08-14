using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace face_regg_window_forms_app
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Create an instance of Login form instead of Form1
            // Run the application with the Login form as the main form
            Application.Run(new faceRecognition1());
        }
    }
}
