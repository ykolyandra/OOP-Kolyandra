namespace OOP.Desing
{
    partial class OperatorDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorDesign));
            this.Button_EditPost = new System.Windows.Forms.Button();
            this.Button_ShowPosts = new System.Windows.Forms.Button();
            this.Label_Title_Name = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_EditPost
            // 
            this.Button_EditPost.BackColor = System.Drawing.Color.Teal;
            this.Button_EditPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_EditPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_EditPost.Location = new System.Drawing.Point(685, 444);
            this.Button_EditPost.Name = "Button_EditPost";
            this.Button_EditPost.Size = new System.Drawing.Size(215, 126);
            this.Button_EditPost.TabIndex = 0;
            this.Button_EditPost.Text = "Редагувати дані про посилку";
            this.Button_EditPost.UseVisualStyleBackColor = false;
            this.Button_EditPost.Click += new System.EventHandler(this.Button_EditPost_Click);
            // 
            // Button_ShowPosts
            // 
            this.Button_ShowPosts.BackColor = System.Drawing.Color.Teal;
            this.Button_ShowPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ShowPosts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_ShowPosts.Location = new System.Drawing.Point(238, 444);
            this.Button_ShowPosts.Name = "Button_ShowPosts";
            this.Button_ShowPosts.Size = new System.Drawing.Size(215, 126);
            this.Button_ShowPosts.TabIndex = 1;
            this.Button_ShowPosts.Text = "Переглянути посилки";
            this.Button_ShowPosts.UseVisualStyleBackColor = false;
            this.Button_ShowPosts.Click += new System.EventHandler(this.Button_ShowPosts_Click);
            // 
            // Label_Title_Name
            // 
            this.Label_Title_Name.AutoSize = true;
            this.Label_Title_Name.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title_Name.Location = new System.Drawing.Point(49, 129);
            this.Label_Title_Name.Name = "Label_Title_Name";
            this.Label_Title_Name.Size = new System.Drawing.Size(112, 28);
            this.Label_Title_Name.TabIndex = 3;
            this.Label_Title_Name.Text = "Оператор:";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title.Location = new System.Drawing.Point(303, 28);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(558, 44);
            this.Label_Title.TabIndex = 5;
            this.Label_Title.Text = "Особистий кабінет оператора";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Name.Location = new System.Drawing.Point(168, 129);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(156, 28);
            this.Label_Name.TabIndex = 6;
            this.Label_Name.Text = "Ім\'я оператора";
            // 
            // OperatorDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1161, 706);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Label_Title_Name);
            this.Controls.Add(this.Button_ShowPosts);
            this.Controls.Add(this.Button_EditPost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperatorDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaPost - Operator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_EditPost;
        private System.Windows.Forms.Button Button_ShowPosts;
        private System.Windows.Forms.Label Label_Title_Name;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_Name;
    }
}