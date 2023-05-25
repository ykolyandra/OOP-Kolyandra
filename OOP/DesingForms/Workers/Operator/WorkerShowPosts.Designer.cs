namespace OOP.Desing
{
    partial class WorkerShowPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerShowPosts));
            this.LinkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.Label_Title = new System.Windows.Forms.Label();
            this.RichTextBox_Posts = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LinkLabel_Back
            // 
            this.LinkLabel_Back.AutoSize = true;
            this.LinkLabel_Back.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LinkLabel_Back.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel_Back.Name = "LinkLabel_Back";
            this.LinkLabel_Back.Size = new System.Drawing.Size(75, 21);
            this.LinkLabel_Back.TabIndex = 0;
            this.LinkLabel_Back.TabStop = true;
            this.LinkLabel_Back.Text = "<-- Назад";
            this.LinkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Back_LinkClicked);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title.Location = new System.Drawing.Point(383, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(356, 44);
            this.Label_Title.TabIndex = 1;
            this.Label_Title.Text = "Перегляд посилок";
            // 
            // RichTextBox_Posts
            // 
            this.RichTextBox_Posts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RichTextBox_Posts.Location = new System.Drawing.Point(29, 74);
            this.RichTextBox_Posts.Name = "RichTextBox_Posts";
            this.RichTextBox_Posts.ReadOnly = true;
            this.RichTextBox_Posts.Size = new System.Drawing.Size(1102, 597);
            this.RichTextBox_Posts.TabIndex = 2;
            this.RichTextBox_Posts.Text = "";
            // 
            // WorkerShowPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1161, 706);
            this.Controls.Add(this.RichTextBox_Posts);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.LinkLabel_Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkerShowPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operator - Info about posts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkLabel_Back;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.RichTextBox RichTextBox_Posts;
    }
}