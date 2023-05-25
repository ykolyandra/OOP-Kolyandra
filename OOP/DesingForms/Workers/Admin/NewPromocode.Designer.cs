namespace OOP.Desing
{
    partial class NewPromocode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPromocode));
            this.Button_AddPromocode = new System.Windows.Forms.Button();
            this.Label_Password = new System.Windows.Forms.Label();
            this.LinkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.TextBox_Phone = new System.Windows.Forms.TextBox();
            this.Label_Phone = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_Promcode = new System.Windows.Forms.Label();
            this.TextBox_Promocode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_AddPromocode
            // 
            this.Button_AddPromocode.BackColor = System.Drawing.Color.Teal;
            this.Button_AddPromocode.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_AddPromocode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_AddPromocode.Location = new System.Drawing.Point(154, 384);
            this.Button_AddPromocode.Name = "Button_AddPromocode";
            this.Button_AddPromocode.Size = new System.Drawing.Size(320, 50);
            this.Button_AddPromocode.TabIndex = 64;
            this.Button_AddPromocode.Text = "Додати промокод";
            this.Button_AddPromocode.UseVisualStyleBackColor = false;
            this.Button_AddPromocode.Click += new System.EventHandler(this.Button_AddPromocode_Click);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Password.Location = new System.Drawing.Point(33, 203);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(225, 28);
            this.Label_Password.TabIndex = 63;
            this.Label_Password.Text = "Пароль користувача:";
            // 
            // LinkLabel_Back
            // 
            this.LinkLabel_Back.AutoSize = true;
            this.LinkLabel_Back.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Back.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Back.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel_Back.Name = "LinkLabel_Back";
            this.LinkLabel_Back.Size = new System.Drawing.Size(75, 21);
            this.LinkLabel_Back.TabIndex = 62;
            this.LinkLabel_Back.TabStop = true;
            this.LinkLabel_Back.Text = "<-- Назад";
            this.LinkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Back_LinkClicked);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Password.Location = new System.Drawing.Point(281, 199);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(261, 34);
            this.TextBox_Password.TabIndex = 61;
            // 
            // TextBox_Phone
            // 
            this.TextBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Phone.Location = new System.Drawing.Point(281, 137);
            this.TextBox_Phone.Name = "TextBox_Phone";
            this.TextBox_Phone.Size = new System.Drawing.Size(261, 34);
            this.TextBox_Phone.TabIndex = 60;
            // 
            // Label_Phone
            // 
            this.Label_Phone.AutoSize = true;
            this.Label_Phone.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Phone.Location = new System.Drawing.Point(70, 115);
            this.Label_Phone.Name = "Label_Phone";
            this.Label_Phone.Size = new System.Drawing.Size(188, 56);
            this.Label_Phone.TabIndex = 59;
            this.Label_Phone.Text = "Номер телефону \r\nкористувача:";
            this.Label_Phone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title.Location = new System.Drawing.Point(62, 51);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(511, 44);
            this.Label_Title.TabIndex = 58;
            this.Label_Title.Text = "Створити новий промокод";
            // 
            // Label_Promcode
            // 
            this.Label_Promcode.AutoSize = true;
            this.Label_Promcode.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Promcode.Location = new System.Drawing.Point(65, 293);
            this.Label_Promcode.Name = "Label_Promcode";
            this.Label_Promcode.Size = new System.Drawing.Size(193, 56);
            this.Label_Promcode.TabIndex = 66;
            this.Label_Promcode.Text = "Введіть промокод\r\n(не більше 50%):";
            this.Label_Promcode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBox_Promocode
            // 
            this.TextBox_Promocode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Promocode.Location = new System.Drawing.Point(281, 315);
            this.TextBox_Promocode.Name = "TextBox_Promocode";
            this.TextBox_Promocode.Size = new System.Drawing.Size(261, 34);
            this.TextBox_Promocode.TabIndex = 65;
            // 
            // NewPromocode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(653, 472);
            this.Controls.Add(this.Label_Promcode);
            this.Controls.Add(this.TextBox_Promocode);
            this.Controls.Add(this.Button_AddPromocode);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.LinkLabel_Back);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Phone);
            this.Controls.Add(this.Label_Phone);
            this.Controls.Add(this.Label_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPromocode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Add new promocode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_AddPromocode;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.LinkLabel LinkLabel_Back;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.TextBox TextBox_Phone;
        private System.Windows.Forms.Label Label_Phone;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_Promcode;
        private System.Windows.Forms.TextBox TextBox_Promocode;
    }
}