namespace OOP.Code
{
    partial class NewOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOperator));
            this.LinkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Button_CreateOperator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinkLabel_Back
            // 
            this.LinkLabel_Back.AutoSize = true;
            this.LinkLabel_Back.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Back.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Back.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel_Back.Name = "LinkLabel_Back";
            this.LinkLabel_Back.Size = new System.Drawing.Size(75, 21);
            this.LinkLabel_Back.TabIndex = 55;
            this.LinkLabel_Back.TabStop = true;
            this.LinkLabel_Back.Text = "<-- Назад";
            this.LinkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Back_LinkClicked);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Password.Location = new System.Drawing.Point(249, 249);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(261, 34);
            this.TextBox_Password.TabIndex = 54;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Name.Location = new System.Drawing.Point(249, 159);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(261, 34);
            this.TextBox_Name.TabIndex = 50;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Name.Location = new System.Drawing.Point(93, 163);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(136, 28);
            this.Label_Name.TabIndex = 46;
            this.Label_Name.Text = "Введіть код:";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title.Location = new System.Drawing.Point(48, 51);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(528, 44);
            this.Label_Title.TabIndex = 42;
            this.Label_Title.Text = "Створити нового оператора";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Password.Location = new System.Drawing.Point(57, 253);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(172, 28);
            this.Label_Password.TabIndex = 56;
            this.Label_Password.Text = "Введіть пароль:";
            // 
            // Button_CreateOperator
            // 
            this.Button_CreateOperator.BackColor = System.Drawing.Color.Teal;
            this.Button_CreateOperator.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_CreateOperator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_CreateOperator.Location = new System.Drawing.Point(161, 354);
            this.Button_CreateOperator.Name = "Button_CreateOperator";
            this.Button_CreateOperator.Size = new System.Drawing.Size(320, 50);
            this.Button_CreateOperator.TabIndex = 57;
            this.Button_CreateOperator.Text = "Створити оператора";
            this.Button_CreateOperator.UseVisualStyleBackColor = false;
            this.Button_CreateOperator.Click += new System.EventHandler(this.Button_CreateOperator_Click);
            // 
            // NewOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(653, 472);
            this.Controls.Add(this.Button_CreateOperator);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.LinkLabel_Back);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Create new operator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkLabel_Back;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Button Button_CreateOperator;
    }
}