namespace OOP
{
    partial class EditPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPost));
            this.RichTextBox_Edit = new System.Windows.Forms.RichTextBox();
            this.Label_PostCode = new System.Windows.Forms.Label();
            this.Label_Edit = new System.Windows.Forms.Label();
            this.TextBox_Code = new System.Windows.Forms.TextBox();
            this.LinkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTextBox_Edit
            // 
            this.RichTextBox_Edit.Location = new System.Drawing.Point(44, 163);
            this.RichTextBox_Edit.Name = "RichTextBox_Edit";
            this.RichTextBox_Edit.Size = new System.Drawing.Size(457, 265);
            this.RichTextBox_Edit.TabIndex = 0;
            this.RichTextBox_Edit.Text = "";
            // 
            // Label_PostCode
            // 
            this.Label_PostCode.AutoSize = true;
            this.Label_PostCode.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_PostCode.Location = new System.Drawing.Point(40, 42);
            this.Label_PostCode.Name = "Label_PostCode";
            this.Label_PostCode.Size = new System.Drawing.Size(461, 44);
            this.Label_PostCode.TabIndex = 1;
            this.Label_PostCode.Text = "Введіть код посилки, яку хочете змінити\r\n(можна змінювати опис лише вами відправл" +
    "ених посилок):";
            // 
            // Label_Edit
            // 
            this.Label_Edit.AutoSize = true;
            this.Label_Edit.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Edit.Location = new System.Drawing.Point(141, 129);
            this.Label_Edit.Name = "Label_Edit";
            this.Label_Edit.Size = new System.Drawing.Size(300, 28);
            this.Label_Edit.TabIndex = 2;
            this.Label_Edit.Text = "Редагувати опис посилки";
            // 
            // TextBox_Code
            // 
            this.TextBox_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Code.Location = new System.Drawing.Point(44, 89);
            this.TextBox_Code.Name = "TextBox_Code";
            this.TextBox_Code.Size = new System.Drawing.Size(457, 34);
            this.TextBox_Code.TabIndex = 3;
            this.TextBox_Code.TextChanged += new System.EventHandler(this.TextBox_Code_TextChanged);
            // 
            // LinkLabel_Back
            // 
            this.LinkLabel_Back.AutoSize = true;
            this.LinkLabel_Back.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Back.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Back.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel_Back.Name = "LinkLabel_Back";
            this.LinkLabel_Back.Size = new System.Drawing.Size(75, 21);
            this.LinkLabel_Back.TabIndex = 4;
            this.LinkLabel_Back.TabStop = true;
            this.LinkLabel_Back.Text = "<-- Назад";
            this.LinkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Back_LinkClicked);
            // 
            // Button_Edit
            // 
            this.Button_Edit.BackColor = System.Drawing.Color.Teal;
            this.Button_Edit.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Edit.Location = new System.Drawing.Point(201, 434);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(153, 46);
            this.Button_Edit.TabIndex = 5;
            this.Button_Edit.Text = "Зберегти";
            this.Button_Edit.UseVisualStyleBackColor = false;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // EditPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(554, 497);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.LinkLabel_Back);
            this.Controls.Add(this.TextBox_Code);
            this.Controls.Add(this.Label_Edit);
            this.Controls.Add(this.Label_PostCode);
            this.Controls.Add(this.RichTextBox_Edit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User - Change post info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox_Edit;
        private System.Windows.Forms.Label Label_PostCode;
        private System.Windows.Forms.Label Label_Edit;
        private System.Windows.Forms.TextBox TextBox_Code;
        private System.Windows.Forms.LinkLabel LinkLabel_Back;
        private System.Windows.Forms.Button Button_Edit;
    }
}