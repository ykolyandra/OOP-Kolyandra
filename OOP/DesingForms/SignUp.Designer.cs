namespace OOP
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.Label_Redistration = new System.Windows.Forms.Label();
            this.Label_Surname = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_SecondName = new System.Windows.Forms.Label();
            this.Label_Phone = new System.Windows.Forms.Label();
            this.Label_Adress = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Label_SamePassword = new System.Windows.Forms.Label();
            this.TextBox_Surname = new System.Windows.Forms.TextBox();
            this.Button_Registration = new System.Windows.Forms.Button();
            this.Label_Email = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_SecondName = new System.Windows.Forms.TextBox();
            this.TextBox_Phone = new System.Windows.Forms.TextBox();
            this.TextBox_Adress = new System.Windows.Forms.TextBox();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.TextBox_SamePassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_Redistration
            // 
            this.Label_Redistration.AutoSize = true;
            this.Label_Redistration.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Redistration.Location = new System.Drawing.Point(442, 24);
            this.Label_Redistration.Name = "Label_Redistration";
            this.Label_Redistration.Size = new System.Drawing.Size(270, 56);
            this.Label_Redistration.TabIndex = 0;
            this.Label_Redistration.Text = "Реєстрація";
            this.Label_Redistration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_Surname
            // 
            this.Label_Surname.AutoSize = true;
            this.Label_Surname.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Surname.Location = new System.Drawing.Point(67, 127);
            this.Label_Surname.Name = "Label_Surname";
            this.Label_Surname.Size = new System.Drawing.Size(133, 35);
            this.Label_Surname.TabIndex = 1;
            this.Label_Surname.Text = "Прізвище:";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Name.Location = new System.Drawing.Point(67, 223);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(66, 35);
            this.Label_Name.TabIndex = 2;
            this.Label_Name.Text = "Ім\'я:";
            // 
            // Label_SecondName
            // 
            this.Label_SecondName.AutoSize = true;
            this.Label_SecondName.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_SecondName.Location = new System.Drawing.Point(67, 326);
            this.Label_SecondName.Name = "Label_SecondName";
            this.Label_SecondName.Size = new System.Drawing.Size(169, 35);
            this.Label_SecondName.TabIndex = 3;
            this.Label_SecondName.Text = "По батькові:";
            // 
            // Label_Phone
            // 
            this.Label_Phone.AutoSize = true;
            this.Label_Phone.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Phone.Location = new System.Drawing.Point(67, 422);
            this.Label_Phone.Name = "Label_Phone";
            this.Label_Phone.Size = new System.Drawing.Size(226, 35);
            this.Label_Phone.TabIndex = 4;
            this.Label_Phone.Text = "Номер телефону:";
            // 
            // Label_Adress
            // 
            this.Label_Adress.AutoSize = true;
            this.Label_Adress.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Adress.Location = new System.Drawing.Point(624, 127);
            this.Label_Adress.Name = "Label_Adress";
            this.Label_Adress.Size = new System.Drawing.Size(106, 35);
            this.Label_Adress.TabIndex = 5;
            this.Label_Adress.Text = "Адреса:";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Password.Location = new System.Drawing.Point(624, 326);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(108, 35);
            this.Label_Password.TabIndex = 6;
            this.Label_Password.Text = "Пароль:";
            // 
            // Label_SamePassword
            // 
            this.Label_SamePassword.AutoSize = true;
            this.Label_SamePassword.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_SamePassword.Location = new System.Drawing.Point(624, 422);
            this.Label_SamePassword.Name = "Label_SamePassword";
            this.Label_SamePassword.Size = new System.Drawing.Size(246, 35);
            this.Label_SamePassword.TabIndex = 7;
            this.Label_SamePassword.Text = "Повторіть пароль:";
            // 
            // TextBox_Surname
            // 
            this.TextBox_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Surname.Location = new System.Drawing.Point(73, 165);
            this.TextBox_Surname.Name = "TextBox_Surname";
            this.TextBox_Surname.Size = new System.Drawing.Size(445, 38);
            this.TextBox_Surname.TabIndex = 8;
            // 
            // Button_Registration
            // 
            this.Button_Registration.BackColor = System.Drawing.Color.Teal;
            this.Button_Registration.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Registration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Registration.Location = new System.Drawing.Point(440, 575);
            this.Button_Registration.Name = "Button_Registration";
            this.Button_Registration.Size = new System.Drawing.Size(298, 72);
            this.Button_Registration.TabIndex = 15;
            this.Button_Registration.Text = "Зареєструватися";
            this.Button_Registration.UseVisualStyleBackColor = false;
            this.Button_Registration.Click += new System.EventHandler(this.Button_Registration_Click);
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Email.Location = new System.Drawing.Point(624, 223);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(93, 35);
            this.Label_Email.TabIndex = 16;
            this.Label_Email.Text = "Е-mail:";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Name.Location = new System.Drawing.Point(73, 261);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(445, 38);
            this.TextBox_Name.TabIndex = 17;
            // 
            // TextBox_SecondName
            // 
            this.TextBox_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_SecondName.Location = new System.Drawing.Point(73, 364);
            this.TextBox_SecondName.Name = "TextBox_SecondName";
            this.TextBox_SecondName.Size = new System.Drawing.Size(445, 38);
            this.TextBox_SecondName.TabIndex = 18;
            // 
            // TextBox_Phone
            // 
            this.TextBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Phone.Location = new System.Drawing.Point(73, 460);
            this.TextBox_Phone.Name = "TextBox_Phone";
            this.TextBox_Phone.Size = new System.Drawing.Size(445, 38);
            this.TextBox_Phone.TabIndex = 19;
            // 
            // TextBox_Adress
            // 
            this.TextBox_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Adress.Location = new System.Drawing.Point(630, 165);
            this.TextBox_Adress.Name = "TextBox_Adress";
            this.TextBox_Adress.Size = new System.Drawing.Size(445, 38);
            this.TextBox_Adress.TabIndex = 20;
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Email.Location = new System.Drawing.Point(630, 261);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(445, 38);
            this.TextBox_Email.TabIndex = 21;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Password.Location = new System.Drawing.Point(630, 364);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(445, 38);
            this.TextBox_Password.TabIndex = 22;
            // 
            // TextBox_SamePassword
            // 
            this.TextBox_SamePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_SamePassword.Location = new System.Drawing.Point(630, 460);
            this.TextBox_SamePassword.Name = "TextBox_SamePassword";
            this.TextBox_SamePassword.Size = new System.Drawing.Size(445, 38);
            this.TextBox_SamePassword.TabIndex = 23;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1161, 706);
            this.Controls.Add(this.TextBox_SamePassword);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Email);
            this.Controls.Add(this.TextBox_Adress);
            this.Controls.Add(this.TextBox_Phone);
            this.Controls.Add(this.TextBox_SecondName);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.Button_Registration);
            this.Controls.Add(this.TextBox_Surname);
            this.Controls.Add(this.Label_SamePassword);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Adress);
            this.Controls.Add(this.Label_Phone);
            this.Controls.Add(this.Label_SecondName);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_Surname);
            this.Controls.Add(this.Label_Redistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaPost - SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Redistration;
        private System.Windows.Forms.Label Label_Surname;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_SecondName;
        private System.Windows.Forms.Label Label_Phone;
        private System.Windows.Forms.Label Label_Adress;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Label Label_SamePassword;
        private System.Windows.Forms.TextBox TextBox_Surname;
        private System.Windows.Forms.Button Button_Registration;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.TextBox TextBox_SecondName;
        private System.Windows.Forms.TextBox TextBox_Phone;
        private System.Windows.Forms.TextBox TextBox_Adress;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.TextBox TextBox_SamePassword;
    }
}