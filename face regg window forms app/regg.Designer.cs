namespace face_regg_window_forms_app
{
    partial class FaceRecognition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceRecognition));
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.displaypic = new RoundPictureBox();
            this.signoutButt = new CustomControls.RJControls.RJButton();
            this.detect = new System.Windows.Forms.Button();
            this.opencamera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displaypic)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(45, 70);
            this.cboCamera.Margin = new System.Windows.Forms.Padding(2);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(331, 21);
            this.cboCamera.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Camera";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(507, 314);
            this.textBoxResponse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(260, 20);
            this.textBoxResponse.TabIndex = 6;
            this.textBoxResponse.TextChanged += new System.EventHandler(this.textBoxResponse_TextChanged);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.LightGreen;
            this.rjButton1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.DimGray;
            this.rjButton1.Location = new System.Drawing.Point(545, 176);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(188, 37);
            this.rjButton1.TabIndex = 7;
            this.rjButton1.Text = "OPEN CAMERA";
            this.rjButton1.TextColor = System.Drawing.Color.DimGray;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.LightGreen;
            this.rjButton2.BackgroundColor = System.Drawing.Color.LightGreen;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.rjButton2.ForeColor = System.Drawing.Color.DimGray;
            this.rjButton2.Location = new System.Drawing.Point(545, 219);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(188, 37);
            this.rjButton2.TabIndex = 8;
            this.rjButton2.Text = "SCREENSHOT";
            this.rjButton2.TextColor = System.Drawing.Color.DimGray;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.LightGreen;
            this.rjButton3.BackgroundColor = System.Drawing.Color.LightGreen;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.rjButton3.ForeColor = System.Drawing.Color.DimGray;
            this.rjButton3.Location = new System.Drawing.Point(545, 262);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(188, 37);
            this.rjButton3.TabIndex = 9;
            this.rjButton3.Text = "CLOSE CAMERA";
            this.rjButton3.TextColor = System.Drawing.Color.DimGray;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // displaypic
            // 
            this.displaypic.BorderRadius = 10;
            this.displaypic.Location = new System.Drawing.Point(26, 117);
            this.displaypic.Name = "displaypic";
            this.displaypic.Size = new System.Drawing.Size(454, 306);
            this.displaypic.TabIndex = 10;
            this.displaypic.TabStop = false;
            // 
            // signoutButt
            // 
            this.signoutButt.BackColor = System.Drawing.Color.DarkGreen;
            this.signoutButt.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.signoutButt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.signoutButt.BorderRadius = 20;
            this.signoutButt.BorderSize = 0;
            this.signoutButt.FlatAppearance.BorderSize = 0;
            this.signoutButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signoutButt.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.signoutButt.ForeColor = System.Drawing.Color.White;
            this.signoutButt.Location = new System.Drawing.Point(694, 24);
            this.signoutButt.Name = "signoutButt";
            this.signoutButt.Size = new System.Drawing.Size(87, 37);
            this.signoutButt.TabIndex = 11;
            this.signoutButt.Text = "SIGNOUT";
            this.signoutButt.TextColor = System.Drawing.Color.White;
            this.signoutButt.UseVisualStyleBackColor = false;
            this.signoutButt.Click += new System.EventHandler(this.signoutButt_Click);
            // 
            // detect
            // 
            this.detect.Location = new System.Drawing.Point(591, 400);
            this.detect.Name = "detect";
            this.detect.Size = new System.Drawing.Size(75, 23);
            this.detect.TabIndex = 12;
            this.detect.Text = "detect";
            this.detect.UseVisualStyleBackColor = true;
            // 
            // opencamera
            // 
            this.opencamera.Location = new System.Drawing.Point(591, 371);
            this.opencamera.Name = "opencamera";
            this.opencamera.Size = new System.Drawing.Size(75, 23);
            this.opencamera.TabIndex = 13;
            this.opencamera.Text = "open";
            this.opencamera.UseVisualStyleBackColor = true;
            this.opencamera.Click += new System.EventHandler(this.opencamera_Click);
            // 
            // FaceRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::face_regg_window_forms_app.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 533);
            this.Controls.Add(this.opencamera);
            this.Controls.Add(this.detect);
            this.Controls.Add(this.signoutButt);
            this.Controls.Add(this.displaypic);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCamera);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaceRecognition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Recognition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displaypic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResponse;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private RoundPictureBox displaypic;
        private CustomControls.RJControls.RJButton signoutButt;
        private System.Windows.Forms.Button detect;
        private System.Windows.Forms.Button opencamera;
    }
}

