namespace OOP
{
    partial class UserDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDesign));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Button_CreatePost = new System.Windows.Forms.Button();
            this.Button_ShowPosts = new System.Windows.Forms.Button();
            this.Button_PayPost = new System.Windows.Forms.Button();
            this.Button_CalCulPay = new System.Windows.Forms.Button();
            this.RichTextBox_Info = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Label_Promocode = new System.Windows.Forms.Label();
            this.Label_TitlePromocode = new System.Windows.Forms.Label();
            this.Button_DownloadPhoto = new System.Windows.Forms.Button();
            this.PictureBox_Photo = new System.Windows.Forms.PictureBox();
            this.Button_ChangeInfo = new System.Windows.Forms.Button();
            this.Label_Adress = new System.Windows.Forms.Label();
            this.Label_TitleAdress = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Label_TitleEmail = new System.Windows.Forms.Label();
            this.Label_Phone = new System.Windows.Forms.Label();
            this.Label_TitlePhone = new System.Windows.Forms.Label();
            this.Label_FullName = new System.Windows.Forms.Label();
            this.Label_TitleFullName = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1161, 708);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Controls.Add(this.Button_CreatePost);
            this.tabPage1.Controls.Add(this.Button_ShowPosts);
            this.tabPage1.Controls.Add(this.Button_PayPost);
            this.tabPage1.Controls.Add(this.Button_CalCulPay);
            this.tabPage1.Controls.Add(this.RichTextBox_Info);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1153, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Головна";
            // 
            // Button_CreatePost
            // 
            this.Button_CreatePost.BackColor = System.Drawing.Color.Teal;
            this.Button_CreatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_CreatePost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_CreatePost.Location = new System.Drawing.Point(660, 465);
            this.Button_CreatePost.Name = "Button_CreatePost";
            this.Button_CreatePost.Size = new System.Drawing.Size(231, 84);
            this.Button_CreatePost.TabIndex = 5;
            this.Button_CreatePost.Text = "Створити посилку";
            this.Button_CreatePost.UseVisualStyleBackColor = false;
            this.Button_CreatePost.Click += new System.EventHandler(this.Button_CreatePost_Click);
            // 
            // Button_ShowPosts
            // 
            this.Button_ShowPosts.BackColor = System.Drawing.Color.Teal;
            this.Button_ShowPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ShowPosts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_ShowPosts.Location = new System.Drawing.Point(660, 571);
            this.Button_ShowPosts.Name = "Button_ShowPosts";
            this.Button_ShowPosts.Size = new System.Drawing.Size(231, 75);
            this.Button_ShowPosts.TabIndex = 4;
            this.Button_ShowPosts.Text = "Мої посилки";
            this.Button_ShowPosts.UseVisualStyleBackColor = false;
            this.Button_ShowPosts.Click += new System.EventHandler(this.Button_ShowPosts_Click);
            // 
            // Button_PayPost
            // 
            this.Button_PayPost.BackColor = System.Drawing.Color.Teal;
            this.Button_PayPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_PayPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_PayPost.Location = new System.Drawing.Point(200, 571);
            this.Button_PayPost.Name = "Button_PayPost";
            this.Button_PayPost.Size = new System.Drawing.Size(246, 75);
            this.Button_PayPost.TabIndex = 3;
            this.Button_PayPost.Text = "Оплатити посилку";
            this.Button_PayPost.UseVisualStyleBackColor = false;
            this.Button_PayPost.Click += new System.EventHandler(this.Button_PayPost_Click);
            // 
            // Button_CalCulPay
            // 
            this.Button_CalCulPay.BackColor = System.Drawing.Color.Teal;
            this.Button_CalCulPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_CalCulPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_CalCulPay.Location = new System.Drawing.Point(200, 465);
            this.Button_CalCulPay.Name = "Button_CalCulPay";
            this.Button_CalCulPay.Size = new System.Drawing.Size(246, 79);
            this.Button_CalCulPay.TabIndex = 1;
            this.Button_CalCulPay.Text = "Розрахувати доставку";
            this.Button_CalCulPay.UseVisualStyleBackColor = false;
            this.Button_CalCulPay.Click += new System.EventHandler(this.Button_CalCulPay_Click);
            // 
            // RichTextBox_Info
            // 
            this.RichTextBox_Info.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RichTextBox_Info.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBox_Info.Location = new System.Drawing.Point(49, 20);
            this.RichTextBox_Info.Name = "RichTextBox_Info";
            this.RichTextBox_Info.ReadOnly = true;
            this.RichTextBox_Info.Size = new System.Drawing.Size(1045, 423);
            this.RichTextBox_Info.TabIndex = 0;
            this.RichTextBox_Info.Text = resources.GetString("RichTextBox_Info.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Linen;
            this.tabPage2.Controls.Add(this.Label_Promocode);
            this.tabPage2.Controls.Add(this.Label_TitlePromocode);
            this.tabPage2.Controls.Add(this.Button_DownloadPhoto);
            this.tabPage2.Controls.Add(this.PictureBox_Photo);
            this.tabPage2.Controls.Add(this.Button_ChangeInfo);
            this.tabPage2.Controls.Add(this.Label_Adress);
            this.tabPage2.Controls.Add(this.Label_TitleAdress);
            this.tabPage2.Controls.Add(this.Label_Email);
            this.tabPage2.Controls.Add(this.Label_TitleEmail);
            this.tabPage2.Controls.Add(this.Label_Phone);
            this.tabPage2.Controls.Add(this.Label_TitlePhone);
            this.tabPage2.Controls.Add(this.Label_FullName);
            this.tabPage2.Controls.Add(this.Label_TitleFullName);
            this.tabPage2.Controls.Add(this.Label_Title);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1153, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Особистий кабінет";
            // 
            // Label_Promocode
            // 
            this.Label_Promocode.AutoSize = true;
            this.Label_Promocode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Promocode.Location = new System.Drawing.Point(102, 399);
            this.Label_Promocode.Name = "Label_Promocode";
            this.Label_Promocode.Size = new System.Drawing.Size(132, 29);
            this.Label_Promocode.TabIndex = 14;
            this.Label_Promocode.Text = "Промокод";
            // 
            // Label_TitlePromocode
            // 
            this.Label_TitlePromocode.AutoSize = true;
            this.Label_TitlePromocode.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TitlePromocode.Location = new System.Drawing.Point(104, 380);
            this.Label_TitlePromocode.Name = "Label_TitlePromocode";
            this.Label_TitlePromocode.Size = new System.Drawing.Size(179, 22);
            this.Label_TitlePromocode.TabIndex = 13;
            this.Label_TitlePromocode.Text = "Доступний промокод:";
            // 
            // Button_DownloadPhoto
            // 
            this.Button_DownloadPhoto.BackColor = System.Drawing.Color.Teal;
            this.Button_DownloadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_DownloadPhoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_DownloadPhoto.Location = new System.Drawing.Point(698, 559);
            this.Button_DownloadPhoto.Name = "Button_DownloadPhoto";
            this.Button_DownloadPhoto.Size = new System.Drawing.Size(214, 73);
            this.Button_DownloadPhoto.TabIndex = 12;
            this.Button_DownloadPhoto.Text = "Завантажити фото";
            this.Button_DownloadPhoto.UseVisualStyleBackColor = false;
            this.Button_DownloadPhoto.Click += new System.EventHandler(this.Button_DownloadPhoto_Click);
            // 
            // PictureBox_Photo
            // 
            this.PictureBox_Photo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Photo.Image")));
            this.PictureBox_Photo.Location = new System.Drawing.Point(698, 104);
            this.PictureBox_Photo.Name = "PictureBox_Photo";
            this.PictureBox_Photo.Size = new System.Drawing.Size(347, 319);
            this.PictureBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_Photo.TabIndex = 11;
            this.PictureBox_Photo.TabStop = false;
            // 
            // Button_ChangeInfo
            // 
            this.Button_ChangeInfo.BackColor = System.Drawing.Color.Teal;
            this.Button_ChangeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ChangeInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_ChangeInfo.Location = new System.Drawing.Point(182, 559);
            this.Button_ChangeInfo.Name = "Button_ChangeInfo";
            this.Button_ChangeInfo.Size = new System.Drawing.Size(232, 73);
            this.Button_ChangeInfo.TabIndex = 10;
            this.Button_ChangeInfo.Text = "Змінити особисту інформацію";
            this.Button_ChangeInfo.UseVisualStyleBackColor = false;
            this.Button_ChangeInfo.Click += new System.EventHandler(this.Button_ChangeInfo_Click);
            // 
            // Label_Adress
            // 
            this.Label_Adress.AutoSize = true;
            this.Label_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Adress.Location = new System.Drawing.Point(103, 326);
            this.Label_Adress.Name = "Label_Adress";
            this.Label_Adress.Size = new System.Drawing.Size(95, 29);
            this.Label_Adress.TabIndex = 8;
            this.Label_Adress.Text = "Адреса";
            // 
            // Label_TitleAdress
            // 
            this.Label_TitleAdress.AutoSize = true;
            this.Label_TitleAdress.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TitleAdress.Location = new System.Drawing.Point(105, 307);
            this.Label_TitleAdress.Name = "Label_TitleAdress";
            this.Label_TitleAdress.Size = new System.Drawing.Size(68, 22);
            this.Label_TitleAdress.TabIndex = 7;
            this.Label_TitleAdress.Text = "Адреса:";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Email.Location = new System.Drawing.Point(103, 271);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(82, 29);
            this.Label_Email.TabIndex = 6;
            this.Label_Email.Text = "Е-mail";
            // 
            // Label_TitleEmail
            // 
            this.Label_TitleEmail.AutoSize = true;
            this.Label_TitleEmail.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TitleEmail.Location = new System.Drawing.Point(105, 252);
            this.Label_TitleEmail.Name = "Label_TitleEmail";
            this.Label_TitleEmail.Size = new System.Drawing.Size(61, 22);
            this.Label_TitleEmail.TabIndex = 5;
            this.Label_TitleEmail.Text = "Е-mail:";
            // 
            // Label_Phone
            // 
            this.Label_Phone.AutoSize = true;
            this.Label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Phone.Location = new System.Drawing.Point(103, 216);
            this.Label_Phone.Name = "Label_Phone";
            this.Label_Phone.Size = new System.Drawing.Size(211, 29);
            this.Label_Phone.TabIndex = 4;
            this.Label_Phone.Text = "Номер телефону";
            // 
            // Label_TitlePhone
            // 
            this.Label_TitlePhone.AutoSize = true;
            this.Label_TitlePhone.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TitlePhone.Location = new System.Drawing.Point(105, 196);
            this.Label_TitlePhone.Name = "Label_TitlePhone";
            this.Label_TitlePhone.Size = new System.Drawing.Size(145, 22);
            this.Label_TitlePhone.TabIndex = 3;
            this.Label_TitlePhone.Text = "Номер телефону:";
            // 
            // Label_FullName
            // 
            this.Label_FullName.AutoSize = true;
            this.Label_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FullName.Location = new System.Drawing.Point(103, 134);
            this.Label_FullName.Name = "Label_FullName";
            this.Label_FullName.Size = new System.Drawing.Size(311, 29);
            this.Label_FullName.TabIndex = 2;
            this.Label_FullName.Text = "Прізвище Ім\'я По батькові";
            // 
            // Label_TitleFullName
            // 
            this.Label_TitleFullName.AutoSize = true;
            this.Label_TitleFullName.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TitleFullName.Location = new System.Drawing.Point(105, 115);
            this.Label_TitleFullName.Name = "Label_TitleFullName";
            this.Label_TitleFullName.Size = new System.Drawing.Size(216, 22);
            this.Label_TitleFullName.TabIndex = 1;
            this.Label_TitleFullName.Text = "Прізвище Ім\'я По батькові:";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title.Location = new System.Drawing.Point(358, 24);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(440, 44);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "Контактна інформація";
            // 
            // UserDesign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1161, 706);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaPost - User";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox RichTextBox_Info;
        private System.Windows.Forms.Button Button_CreatePost;
        private System.Windows.Forms.Button Button_ShowPosts;
        private System.Windows.Forms.Button Button_PayPost;
        private System.Windows.Forms.Button Button_CalCulPay;
        private System.Windows.Forms.Label Label_TitlePhone;
        private System.Windows.Forms.Label Label_FullName;
        private System.Windows.Forms.Label Label_TitleFullName;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_Phone;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_TitleEmail;
        private System.Windows.Forms.Label Label_Adress;
        private System.Windows.Forms.Label Label_TitleAdress;
        private System.Windows.Forms.Button Button_ChangeInfo;
        private System.Windows.Forms.Button Button_DownloadPhoto;
        private System.Windows.Forms.PictureBox PictureBox_Photo;
        private System.Windows.Forms.Label Label_Promocode;
        private System.Windows.Forms.Label Label_TitlePromocode;
    }
}