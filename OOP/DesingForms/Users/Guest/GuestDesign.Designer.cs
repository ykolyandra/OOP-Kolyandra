namespace OOP
{
    partial class GuestDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestDesign));
            this.Button_CalcCulPost = new System.Windows.Forms.Button();
            this.Button_TrackPost = new System.Windows.Forms.Button();
            this.RichTextBox_Info = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Button_CalcCulPost
            // 
            this.Button_CalcCulPost.BackColor = System.Drawing.Color.Teal;
            this.Button_CalcCulPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_CalcCulPost.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_CalcCulPost.Location = new System.Drawing.Point(185, 601);
            this.Button_CalcCulPost.Name = "Button_CalcCulPost";
            this.Button_CalcCulPost.Size = new System.Drawing.Size(250, 72);
            this.Button_CalcCulPost.TabIndex = 0;
            this.Button_CalcCulPost.Text = "Розрахувати доставку";
            this.Button_CalcCulPost.UseVisualStyleBackColor = false;
            this.Button_CalcCulPost.Click += new System.EventHandler(this.Button_CalCulPost_Click);
            // 
            // Button_TrackPost
            // 
            this.Button_TrackPost.BackColor = System.Drawing.Color.Teal;
            this.Button_TrackPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_TrackPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_TrackPost.Location = new System.Drawing.Point(668, 601);
            this.Button_TrackPost.Name = "Button_TrackPost";
            this.Button_TrackPost.Size = new System.Drawing.Size(250, 72);
            this.Button_TrackPost.TabIndex = 1;
            this.Button_TrackPost.Text = "Відстежити посилку";
            this.Button_TrackPost.UseVisualStyleBackColor = false;
            this.Button_TrackPost.Click += new System.EventHandler(this.Button_TrackPost_Click);
            // 
            // RichTextBox_Info
            // 
            this.RichTextBox_Info.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RichTextBox_Info.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBox_Info.Location = new System.Drawing.Point(36, 29);
            this.RichTextBox_Info.Name = "RichTextBox_Info";
            this.RichTextBox_Info.ReadOnly = true;
            this.RichTextBox_Info.Size = new System.Drawing.Size(1080, 551);
            this.RichTextBox_Info.TabIndex = 3;
            this.RichTextBox_Info.Text = resources.GetString("RichTextBox_Info.Text");
            // 
            // GuestDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1161, 706);
            this.Controls.Add(this.RichTextBox_Info);
            this.Controls.Add(this.Button_TrackPost);
            this.Controls.Add(this.Button_CalcCulPost);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaPost - Guest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_CalcCulPost;
        private System.Windows.Forms.Button Button_TrackPost;
        private System.Windows.Forms.RichTextBox RichTextBox_Info;
    }
}