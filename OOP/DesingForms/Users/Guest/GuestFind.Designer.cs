namespace OOP
{
    partial class GuestFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestFind));
            this.Label_Code = new System.Windows.Forms.Label();
            this.Label_Info = new System.Windows.Forms.Label();
            this.TextBox_Code = new System.Windows.Forms.TextBox();
            this.RichTextBox_Info = new System.Windows.Forms.RichTextBox();
            this.Button_Find = new System.Windows.Forms.Button();
            this.LinkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Label_Code
            // 
            this.Label_Code.AutoSize = true;
            this.Label_Code.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Code.Location = new System.Drawing.Point(43, 48);
            this.Label_Code.Name = "Label_Code";
            this.Label_Code.Size = new System.Drawing.Size(324, 22);
            this.Label_Code.TabIndex = 1;
            this.Label_Code.Text = "Введіть код посилки, яку хочете знайти:";
            // 
            // Label_Info
            // 
            this.Label_Info.AutoSize = true;
            this.Label_Info.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Info.Location = new System.Drawing.Point(43, 167);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(100, 22);
            this.Label_Info.TabIndex = 2;
            this.Label_Info.Text = "Інформація:";
            // 
            // TextBox_Code
            // 
            this.TextBox_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Code.Location = new System.Drawing.Point(47, 73);
            this.TextBox_Code.Name = "TextBox_Code";
            this.TextBox_Code.Size = new System.Drawing.Size(554, 34);
            this.TextBox_Code.TabIndex = 3;
            this.TextBox_Code.TextChanged += new System.EventHandler(this.TextBox_Code_TextChanged);
            // 
            // RichTextBox_Info
            // 
            this.RichTextBox_Info.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RichTextBox_Info.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBox_Info.Location = new System.Drawing.Point(47, 192);
            this.RichTextBox_Info.Name = "RichTextBox_Info";
            this.RichTextBox_Info.ReadOnly = true;
            this.RichTextBox_Info.Size = new System.Drawing.Size(554, 181);
            this.RichTextBox_Info.TabIndex = 4;
            this.RichTextBox_Info.Text = "Інформація про посилку";
            // 
            // Button_Find
            // 
            this.Button_Find.BackColor = System.Drawing.Color.Teal;
            this.Button_Find.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Find.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Find.Location = new System.Drawing.Point(245, 113);
            this.Button_Find.Name = "Button_Find";
            this.Button_Find.Size = new System.Drawing.Size(142, 37);
            this.Button_Find.TabIndex = 6;
            this.Button_Find.Text = "Знайти посилку";
            this.Button_Find.UseVisualStyleBackColor = false;
            this.Button_Find.Click += new System.EventHandler(this.Button_Find_Click);
            // 
            // LinkLabel_Back
            // 
            this.LinkLabel_Back.AutoSize = true;
            this.LinkLabel_Back.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LinkLabel_Back.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel_Back.Name = "LinkLabel_Back";
            this.LinkLabel_Back.Size = new System.Drawing.Size(75, 21);
            this.LinkLabel_Back.TabIndex = 7;
            this.LinkLabel_Back.TabStop = true;
            this.LinkLabel_Back.Text = "<-- Назад";
            this.LinkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Back_LinkClicked);
            // 
            // GuestFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(648, 406);
            this.Controls.Add(this.LinkLabel_Back);
            this.Controls.Add(this.Button_Find);
            this.Controls.Add(this.RichTextBox_Info);
            this.Controls.Add(this.TextBox_Code);
            this.Controls.Add(this.Label_Info);
            this.Controls.Add(this.Label_Code);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest - Find post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Code;
        private System.Windows.Forms.Label Label_Info;
        private System.Windows.Forms.TextBox TextBox_Code;
        private System.Windows.Forms.RichTextBox RichTextBox_Info;
        private System.Windows.Forms.Button Button_Find;
        private System.Windows.Forms.LinkLabel LinkLabel_Back;
    }
}