namespace OOP.Desing
{
    partial class AdminShowInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminShowInfo));
            this.RichTextBox_Info = new System.Windows.Forms.RichTextBox();
            this.Label_Title = new System.Windows.Forms.Label();
            this.LinkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.Label_AddInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RichTextBox_Info
            // 
            this.RichTextBox_Info.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RichTextBox_Info.Location = new System.Drawing.Point(38, 120);
            this.RichTextBox_Info.Name = "RichTextBox_Info";
            this.RichTextBox_Info.ReadOnly = true;
            this.RichTextBox_Info.Size = new System.Drawing.Size(1102, 564);
            this.RichTextBox_Info.TabIndex = 5;
            this.RichTextBox_Info.Text = "";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title.Location = new System.Drawing.Point(392, 22);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(409, 44);
            this.Label_Title.TabIndex = 4;
            this.Label_Title.Text = "Перегляд інформації";
            // 
            // LinkLabel_Back
            // 
            this.LinkLabel_Back.AutoSize = true;
            this.LinkLabel_Back.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LinkLabel_Back.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel_Back.Name = "LinkLabel_Back";
            this.LinkLabel_Back.Size = new System.Drawing.Size(75, 21);
            this.LinkLabel_Back.TabIndex = 3;
            this.LinkLabel_Back.TabStop = true;
            this.LinkLabel_Back.Text = "<-- Назад";
            this.LinkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Back_LinkClicked);
            // 
            // Label_AddInfo
            // 
            this.Label_AddInfo.AutoSize = true;
            this.Label_AddInfo.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_AddInfo.Location = new System.Drawing.Point(431, 73);
            this.Label_AddInfo.Name = "Label_AddInfo";
            this.Label_AddInfo.Size = new System.Drawing.Size(339, 44);
            this.Label_AddInfo.TabIndex = 6;
            this.Label_AddInfo.Text = "про користувачів";
            this.Label_AddInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1161, 706);
            this.Controls.Add(this.Label_AddInfo);
            this.Controls.Add(this.RichTextBox_Info);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.LinkLabel_Back);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminShowInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Show info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox_Info;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.LinkLabel LinkLabel_Back;
        private System.Windows.Forms.Label Label_AddInfo;
    }
}