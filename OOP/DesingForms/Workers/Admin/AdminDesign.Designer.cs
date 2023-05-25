namespace OOP
{
    partial class AdminDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDesign));
            this.Button_AddOperator = new System.Windows.Forms.Button();
            this.Button_CreatePromocode = new System.Windows.Forms.Button();
            this.Button_ShowUsers = new System.Windows.Forms.Button();
            this.Button_ShowPostBoxes = new System.Windows.Forms.Button();
            this.Button_EditPost = new System.Windows.Forms.Button();
            this.Button_ShowOperators = new System.Windows.Forms.Button();
            this.Label_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_AddOperator
            // 
            this.Button_AddOperator.BackColor = System.Drawing.Color.Teal;
            this.Button_AddOperator.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_AddOperator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_AddOperator.Location = new System.Drawing.Point(121, 223);
            this.Button_AddOperator.Name = "Button_AddOperator";
            this.Button_AddOperator.Size = new System.Drawing.Size(229, 83);
            this.Button_AddOperator.TabIndex = 0;
            this.Button_AddOperator.Text = "Додати нового оператора";
            this.Button_AddOperator.UseVisualStyleBackColor = false;
            this.Button_AddOperator.Click += new System.EventHandler(this.Button_AddOperator_Click);
            // 
            // Button_CreatePromocode
            // 
            this.Button_CreatePromocode.BackColor = System.Drawing.Color.Teal;
            this.Button_CreatePromocode.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_CreatePromocode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_CreatePromocode.Location = new System.Drawing.Point(454, 223);
            this.Button_CreatePromocode.Name = "Button_CreatePromocode";
            this.Button_CreatePromocode.Size = new System.Drawing.Size(229, 83);
            this.Button_CreatePromocode.TabIndex = 4;
            this.Button_CreatePromocode.Text = "Створити промокод";
            this.Button_CreatePromocode.UseVisualStyleBackColor = false;
            this.Button_CreatePromocode.Click += new System.EventHandler(this.Button_CreatePromocode_Click);
            // 
            // Button_ShowUsers
            // 
            this.Button_ShowUsers.BackColor = System.Drawing.Color.Teal;
            this.Button_ShowUsers.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ShowUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_ShowUsers.Location = new System.Drawing.Point(454, 393);
            this.Button_ShowUsers.Name = "Button_ShowUsers";
            this.Button_ShowUsers.Size = new System.Drawing.Size(229, 83);
            this.Button_ShowUsers.TabIndex = 5;
            this.Button_ShowUsers.Text = "Переглянути інформацію про користувачів\r\n";
            this.Button_ShowUsers.UseVisualStyleBackColor = false;
            this.Button_ShowUsers.Click += new System.EventHandler(this.Button_ShowUsers_Click);
            // 
            // Button_ShowPostBoxes
            // 
            this.Button_ShowPostBoxes.BackColor = System.Drawing.Color.Teal;
            this.Button_ShowPostBoxes.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ShowPostBoxes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_ShowPostBoxes.Location = new System.Drawing.Point(786, 392);
            this.Button_ShowPostBoxes.Name = "Button_ShowPostBoxes";
            this.Button_ShowPostBoxes.Size = new System.Drawing.Size(229, 80);
            this.Button_ShowPostBoxes.TabIndex = 6;
            this.Button_ShowPostBoxes.Text = "Переглянути інформацію про посилки\r\n";
            this.Button_ShowPostBoxes.UseVisualStyleBackColor = false;
            this.Button_ShowPostBoxes.Click += new System.EventHandler(this.Button_ShowPostBoxes_Click);
            // 
            // Button_EditPost
            // 
            this.Button_EditPost.BackColor = System.Drawing.Color.Teal;
            this.Button_EditPost.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_EditPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_EditPost.Location = new System.Drawing.Point(786, 223);
            this.Button_EditPost.Name = "Button_EditPost";
            this.Button_EditPost.Size = new System.Drawing.Size(229, 80);
            this.Button_EditPost.TabIndex = 8;
            this.Button_EditPost.Text = "Редагувати посилку";
            this.Button_EditPost.UseVisualStyleBackColor = false;
            this.Button_EditPost.Click += new System.EventHandler(this.Button_EditPost_Click);
            // 
            // Button_ShowOperators
            // 
            this.Button_ShowOperators.BackColor = System.Drawing.Color.Teal;
            this.Button_ShowOperators.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ShowOperators.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_ShowOperators.Location = new System.Drawing.Point(121, 393);
            this.Button_ShowOperators.Name = "Button_ShowOperators";
            this.Button_ShowOperators.Size = new System.Drawing.Size(229, 83);
            this.Button_ShowOperators.TabIndex = 7;
            this.Button_ShowOperators.Text = "Переглянути інформацію про операторів";
            this.Button_ShowOperators.UseVisualStyleBackColor = false;
            this.Button_ShowOperators.Click += new System.EventHandler(this.Button_ShowOperators_Click);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title.Location = new System.Drawing.Point(247, 27);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(645, 44);
            this.Label_Title.TabIndex = 9;
            this.Label_Title.Text = "Особистий кабінет адміністратора";
            // 
            // AdminDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1161, 706);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Button_EditPost);
            this.Controls.Add(this.Button_ShowOperators);
            this.Controls.Add(this.Button_ShowPostBoxes);
            this.Controls.Add(this.Button_ShowUsers);
            this.Controls.Add(this.Button_CreatePromocode);
            this.Controls.Add(this.Button_AddOperator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaPost - Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_AddOperator;
        private System.Windows.Forms.Button Button_CreatePromocode;
        private System.Windows.Forms.Button Button_ShowUsers;
        private System.Windows.Forms.Button Button_ShowPostBoxes;
        private System.Windows.Forms.Button Button_EditPost;
        private System.Windows.Forms.Button Button_ShowOperators;
        private System.Windows.Forms.Label Label_Title;
    }
}