namespace face_regg_window_forms_app
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linkForgetpassword = new System.Windows.Forms.LinkLabel();
            this.customButtonRegister1 = new face_regg_window_forms_app.customButtonRegister();
            this.customButton1 = new face_regg_window_forms_app.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(331, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(331, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(335, 206);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(325, 42);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(335, 306);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(327, 43);
            this.txtPassword.TabIndex = 3;
            // 
            // linkForgetpassword
            // 
            this.linkForgetpassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.linkForgetpassword.AutoSize = true;
            this.linkForgetpassword.BackColor = System.Drawing.Color.Transparent;
            this.linkForgetpassword.Font = new System.Drawing.Font("Poppins", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgetpassword.LinkColor = System.Drawing.Color.Silver;
            this.linkForgetpassword.Location = new System.Drawing.Point(405, 482);
            this.linkForgetpassword.Name = "linkForgetpassword";
            this.linkForgetpassword.Size = new System.Drawing.Size(187, 36);
            this.linkForgetpassword.TabIndex = 7;
            this.linkForgetpassword.TabStop = true;
            this.linkForgetpassword.Text = "Forget Password";
            this.linkForgetpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkForgetpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgetpassword_LinkClicked);
            // 
            // customButtonRegister1
            // 
            this.customButtonRegister1.Angle = 160F;
            this.customButtonRegister1.BackColor = System.Drawing.Color.Transparent;
            this.customButtonRegister1.BoarderRadius = 43;
            this.customButtonRegister1.Color0 = System.Drawing.Color.White;
            this.customButtonRegister1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.customButtonRegister1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonRegister1.ForeColor = System.Drawing.Color.Gray;
            this.customButtonRegister1.Location = new System.Drawing.Point(337, 428);
            this.customButtonRegister1.Margin = new System.Windows.Forms.Padding(4);
            this.customButtonRegister1.Name = "customButtonRegister1";
            this.customButtonRegister1.Size = new System.Drawing.Size(327, 50);
            this.customButtonRegister1.TabIndex = 9;
            this.customButtonRegister1.Click += new System.EventHandler(this.customButtonRegister1_Click);
            // 
            // customButton1
            // 
            this.customButton1.Angle = 279F;
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.customButton1.BoarderRadius = 43;
            this.customButton1.Color0 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.customButton1.Color1 = System.Drawing.Color.White;
            this.customButton1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.Gray;
            this.customButton1.Location = new System.Drawing.Point(335, 370);
            this.customButton1.Margin = new System.Windows.Forms.Padding(4);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(327, 50);
            this.customButton1.TabIndex = 8;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::face_regg_window_forms_app.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 703);
            this.Controls.Add(this.customButtonRegister1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.linkForgetpassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkForgetpassword;
        private CustomButton customButton1;
        private customButtonRegister customButtonRegister1;
    }
}