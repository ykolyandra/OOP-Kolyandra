namespace OOP
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Button_HidePassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Phone = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Button_LogIn = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.LinkLabel();
            this.ContinueLikeGuest = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ContinueLikeAdmin = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Phone = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Password.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_Password.Location = new System.Drawing.Point(246, 180);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(241, 36);
            this.TextBox_Password.TabIndex = 2;
            // 
            // Button_HidePassword
            // 
            this.Button_HidePassword.Image = ((System.Drawing.Image)(resources.GetObject("Button_HidePassword.Image")));
            this.Button_HidePassword.Location = new System.Drawing.Point(495, 180);
            this.Button_HidePassword.Name = "Button_HidePassword";
            this.Button_HidePassword.Size = new System.Drawing.Size(55, 40);
            this.Button_HidePassword.TabIndex = 8;
            this.Button_HidePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_HidePassword.UseVisualStyleBackColor = true;
            this.Button_HidePassword.Click += new System.EventHandler(this.Button_HidePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вхід";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox_Phone
            // 
            this.TextBox_Phone.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Phone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_Phone.Location = new System.Drawing.Point(246, 105);
            this.TextBox_Phone.Name = "TextBox_Phone";
            this.TextBox_Phone.Size = new System.Drawing.Size(304, 36);
            this.TextBox_Phone.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(171, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(171, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Button_LogIn
            // 
            this.Button_LogIn.BackColor = System.Drawing.Color.Teal;
            this.Button_LogIn.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_LogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_LogIn.Location = new System.Drawing.Point(171, 257);
            this.Button_LogIn.Name = "Button_LogIn";
            this.Button_LogIn.Size = new System.Drawing.Size(343, 47);
            this.Button_LogIn.TabIndex = 14;
            this.Button_LogIn.Text = "Авторизація";
            this.Button_LogIn.UseVisualStyleBackColor = false;
            this.Button_LogIn.Click += new System.EventHandler(this.Button_LogIn_Click);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(176, 321);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(129, 21);
            this.Registration.TabIndex = 15;
            this.Registration.TabStop = true;
            this.Registration.Text = "Зареєструватися";
            this.Registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label_Registration_Click);
            // 
            // ContinueLikeGuest
            // 
            this.ContinueLikeGuest.AutoSize = true;
            this.ContinueLikeGuest.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContinueLikeGuest.Location = new System.Drawing.Point(353, 321);
            this.ContinueLikeGuest.Name = "ContinueLikeGuest";
            this.ContinueLikeGuest.Size = new System.Drawing.Size(158, 21);
            this.ContinueLikeGuest.TabIndex = 16;
            this.ContinueLikeGuest.TabStop = true;
            this.ContinueLikeGuest.Text = "Продовжити як гість";
            this.ContinueLikeGuest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label_ContinueLikeGuest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(314, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "або";
            // 
            // ContinueLikeAdmin
            // 
            this.ContinueLikeAdmin.AutoSize = true;
            this.ContinueLikeAdmin.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContinueLikeAdmin.Location = new System.Drawing.Point(294, 352);
            this.ContinueLikeAdmin.Name = "ContinueLikeAdmin";
            this.ContinueLikeAdmin.Size = new System.Drawing.Size(168, 21);
            this.ContinueLikeAdmin.TabIndex = 18;
            this.ContinueLikeAdmin.TabStop = true;
            this.ContinueLikeAdmin.Text = "Продовжити як адмін";
            this.ContinueLikeAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ContinueLikeAdmin_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(252, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "або";
            // 
            // Label_Phone
            // 
            this.Label_Phone.AutoSize = true;
            this.Label_Phone.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Phone.Location = new System.Drawing.Point(246, 83);
            this.Label_Phone.Name = "Label_Phone";
            this.Label_Phone.Size = new System.Drawing.Size(141, 21);
            this.Label_Phone.TabIndex = 20;
            this.Label_Phone.Text = "Номер телефону:";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Password.Location = new System.Drawing.Point(246, 158);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(69, 21);
            this.Label_Password.TabIndex = 21;
            this.Label_Password.Text = "Пароль:";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(706, 407);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContinueLikeAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContinueLikeGuest);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Button_LogIn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBox_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_HidePassword);
            this.Controls.Add(this.TextBox_Password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaPost";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Button Button_HidePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Phone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Button_LogIn;
        private System.Windows.Forms.LinkLabel Registration;
        private System.Windows.Forms.LinkLabel ContinueLikeGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ContinueLikeAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Phone;
        private System.Windows.Forms.Label Label_Password;
    }
}

