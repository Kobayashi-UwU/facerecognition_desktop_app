namespace face_regg_window_forms_app
{
    partial class faceRecognition1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.btnDetectFace = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 393);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(781, 70);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 204);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Location = new System.Drawing.Point(781, 307);
            this.btnOpenCamera.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(188, 43);
            this.btnOpenCamera.TabIndex = 2;
            this.btnOpenCamera.Text = "opencamera";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click_1);
            // 
            // btnDetectFace
            // 
            this.btnDetectFace.Location = new System.Drawing.Point(781, 358);
            this.btnDetectFace.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetectFace.Name = "btnDetectFace";
            this.btnDetectFace.Size = new System.Drawing.Size(188, 43);
            this.btnDetectFace.TabIndex = 3;
            this.btnDetectFace.Text = "Detect Face";
            this.btnDetectFace.UseVisualStyleBackColor = true;
            this.btnDetectFace.Click += new System.EventHandler(this.btnDetectFace_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(781, 408);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // faceRecognition1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::face_regg_window_forms_app.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 656);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDetectFace);
            this.Controls.Add(this.btnOpenCamera);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "faceRecognition1";
            this.Text = "faceRecognition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.Button btnDetectFace;
        private System.Windows.Forms.Button button3;
    }
}