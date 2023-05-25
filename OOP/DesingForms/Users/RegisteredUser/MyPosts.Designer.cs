namespace OOP
{
    partial class MyPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPosts));
            this.Label_Title_MyPosts = new System.Windows.Forms.Label();
            this.LinkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.RichTextBox_MyPosts = new System.Windows.Forms.RichTextBox();
            this.Button_ChangeInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Title_MyPosts
            // 
            this.Label_Title_MyPosts.AutoSize = true;
            this.Label_Title_MyPosts.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title_MyPosts.Location = new System.Drawing.Point(437, 9);
            this.Label_Title_MyPosts.Name = "Label_Title_MyPosts";
            this.Label_Title_MyPosts.Size = new System.Drawing.Size(253, 44);
            this.Label_Title_MyPosts.TabIndex = 0;
            this.Label_Title_MyPosts.Text = "Мої посилки";
            // 
            // LinkLabel_Back
            // 
            this.LinkLabel_Back.AutoSize = true;
            this.LinkLabel_Back.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Back.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Back.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel_Back.Name = "LinkLabel_Back";
            this.LinkLabel_Back.Size = new System.Drawing.Size(82, 22);
            this.LinkLabel_Back.TabIndex = 1;
            this.LinkLabel_Back.TabStop = true;
            this.LinkLabel_Back.Text = "<-- Назад";
            this.LinkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Back_LinkClicked);
            // 
            // RichTextBox_MyPosts
            // 
            this.RichTextBox_MyPosts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RichTextBox_MyPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBox_MyPosts.Location = new System.Drawing.Point(24, 76);
            this.RichTextBox_MyPosts.Name = "RichTextBox_MyPosts";
            this.RichTextBox_MyPosts.ReadOnly = true;
            this.RichTextBox_MyPosts.Size = new System.Drawing.Size(1110, 604);
            this.RichTextBox_MyPosts.TabIndex = 2;
            this.RichTextBox_MyPosts.Text = "Перелік посилок користувача";
            // 
            // Button_ChangeInfo
            // 
            this.Button_ChangeInfo.BackColor = System.Drawing.Color.Teal;
            this.Button_ChangeInfo.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ChangeInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_ChangeInfo.Location = new System.Drawing.Point(908, 2);
            this.Button_ChangeInfo.Name = "Button_ChangeInfo";
            this.Button_ChangeInfo.Size = new System.Drawing.Size(226, 68);
            this.Button_ChangeInfo.TabIndex = 3;
            this.Button_ChangeInfo.Text = "Змінити інформацію про посилки";
            this.Button_ChangeInfo.UseVisualStyleBackColor = false;
            this.Button_ChangeInfo.Click += new System.EventHandler(this.Button_ChangeInfo_Click);
            // 
            // MyPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1161, 706);
            this.Controls.Add(this.Button_ChangeInfo);
            this.Controls.Add(this.RichTextBox_MyPosts);
            this.Controls.Add(this.LinkLabel_Back);
            this.Controls.Add(this.Label_Title_MyPosts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User - Show my posts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Title_MyPosts;
        private System.Windows.Forms.LinkLabel LinkLabel_Back;
        private System.Windows.Forms.RichTextBox RichTextBox_MyPosts;
        private System.Windows.Forms.Button Button_ChangeInfo;
    }
}