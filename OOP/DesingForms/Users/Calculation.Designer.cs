namespace OOP
{
    partial class Calculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculation));
            this.Label_CalCulPay = new System.Windows.Forms.Label();
            this.ComboBox_SenderTown = new System.Windows.Forms.ComboBox();
            this.Label_SenderTown = new System.Windows.Forms.Label();
            this.Label_ReceiverTown = new System.Windows.Forms.Label();
            this.ComboBox_ReceiverTown = new System.Windows.Forms.ComboBox();
            this.Label_Weight = new System.Windows.Forms.Label();
            this.Label_AppraisedPrice = new System.Windows.Forms.Label();
            this.TextBox_Weight = new System.Windows.Forms.TextBox();
            this.TextBox_AppraisedPrice = new System.Windows.Forms.TextBox();
            this.Button_CalCul = new System.Windows.Forms.Button();
            this.LinkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Label_CalCulPay
            // 
            this.Label_CalCulPay.AutoSize = true;
            this.Label_CalCulPay.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_CalCulPay.Location = new System.Drawing.Point(29, 35);
            this.Label_CalCulPay.Name = "Label_CalCulPay";
            this.Label_CalCulPay.Size = new System.Drawing.Size(553, 44);
            this.Label_CalCulPay.TabIndex = 0;
            this.Label_CalCulPay.Text = "Розрахунок вартості посилки";
            // 
            // ComboBox_SenderTown
            // 
            this.ComboBox_SenderTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_SenderTown.FormattingEnabled = true;
            this.ComboBox_SenderTown.Items.AddRange(new object[] {
            "Вінниця",
            "Дніпро",
            "Донецьк",
            "Запоріжжя",
            "Київ",
            "Кіровоград",
            "Луганськ",
            "Львів",
            "Миколаїв",
            "Одеса",
            "Полтава",
            "Суми",
            "Харків",
            "Херсон",
            "Черкаси",
            "Чернігів"});
            this.ComboBox_SenderTown.Location = new System.Drawing.Point(67, 141);
            this.ComboBox_SenderTown.Name = "ComboBox_SenderTown";
            this.ComboBox_SenderTown.Size = new System.Drawing.Size(199, 37);
            this.ComboBox_SenderTown.Sorted = true;
            this.ComboBox_SenderTown.TabIndex = 1;
            // 
            // Label_SenderTown
            // 
            this.Label_SenderTown.AutoSize = true;
            this.Label_SenderTown.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_SenderTown.Location = new System.Drawing.Point(63, 116);
            this.Label_SenderTown.Name = "Label_SenderTown";
            this.Label_SenderTown.Size = new System.Drawing.Size(160, 22);
            this.Label_SenderTown.TabIndex = 2;
            this.Label_SenderTown.Text = "Місто відправника:";
            // 
            // Label_ReceiverTown
            // 
            this.Label_ReceiverTown.AutoSize = true;
            this.Label_ReceiverTown.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ReceiverTown.Location = new System.Drawing.Point(337, 116);
            this.Label_ReceiverTown.Name = "Label_ReceiverTown";
            this.Label_ReceiverTown.Size = new System.Drawing.Size(160, 22);
            this.Label_ReceiverTown.TabIndex = 3;
            this.Label_ReceiverTown.Text = "Місто одержувача:";
            // 
            // ComboBox_ReceiverTown
            // 
            this.ComboBox_ReceiverTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_ReceiverTown.FormattingEnabled = true;
            this.ComboBox_ReceiverTown.Items.AddRange(new object[] {
            "Київ",
            "Харків",
            "Одеса",
            "Дніпро",
            "Полтава",
            "Львів",
            "Суми",
            "Черкаси",
            "Чернігів",
            "Вінниця",
            "Миколаїв",
            "Херсон",
            "Донецьк",
            "Луганськ",
            "Кіровоград",
            "Запоріжжя"});
            this.ComboBox_ReceiverTown.Location = new System.Drawing.Point(341, 141);
            this.ComboBox_ReceiverTown.Name = "ComboBox_ReceiverTown";
            this.ComboBox_ReceiverTown.Size = new System.Drawing.Size(196, 37);
            this.ComboBox_ReceiverTown.TabIndex = 4;
            // 
            // Label_Weight
            // 
            this.Label_Weight.AutoSize = true;
            this.Label_Weight.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Weight.Location = new System.Drawing.Point(205, 203);
            this.Label_Weight.Name = "Label_Weight";
            this.Label_Weight.Size = new System.Drawing.Size(144, 22);
            this.Label_Weight.TabIndex = 5;
            this.Label_Weight.Text = "Вага посилки (кг):";
            // 
            // Label_AppraisedPrice
            // 
            this.Label_AppraisedPrice.AutoSize = true;
            this.Label_AppraisedPrice.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_AppraisedPrice.Location = new System.Drawing.Point(128, 347);
            this.Label_AppraisedPrice.Name = "Label_AppraisedPrice";
            this.Label_AppraisedPrice.Size = new System.Drawing.Size(150, 22);
            this.Label_AppraisedPrice.TabIndex = 6;
            this.Label_AppraisedPrice.Text = "Орієнтовна ціна:";
            // 
            // TextBox_Weight
            // 
            this.TextBox_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Weight.Location = new System.Drawing.Point(209, 228);
            this.TextBox_Weight.Name = "TextBox_Weight";
            this.TextBox_Weight.Size = new System.Drawing.Size(196, 34);
            this.TextBox_Weight.TabIndex = 7;
            // 
            // TextBox_AppraisedPrice
            // 
            this.TextBox_AppraisedPrice.BackColor = System.Drawing.Color.LightCyan;
            this.TextBox_AppraisedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_AppraisedPrice.Location = new System.Drawing.Point(291, 340);
            this.TextBox_AppraisedPrice.Name = "TextBox_AppraisedPrice";
            this.TextBox_AppraisedPrice.ReadOnly = true;
            this.TextBox_AppraisedPrice.Size = new System.Drawing.Size(196, 34);
            this.TextBox_AppraisedPrice.TabIndex = 8;
            // 
            // Button_CalCul
            // 
            this.Button_CalCul.BackColor = System.Drawing.Color.Teal;
            this.Button_CalCul.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_CalCul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_CalCul.Location = new System.Drawing.Point(191, 268);
            this.Button_CalCul.Name = "Button_CalCul";
            this.Button_CalCul.Size = new System.Drawing.Size(244, 49);
            this.Button_CalCul.TabIndex = 9;
            this.Button_CalCul.Text = "Розрахувати";
            this.Button_CalCul.UseVisualStyleBackColor = false;
            this.Button_CalCul.Click += new System.EventHandler(this.Button_CalCul_Click);
            // 
            // LinkLabel_Back
            // 
            this.LinkLabel_Back.AutoSize = true;
            this.LinkLabel_Back.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Back.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Back.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel_Back.Name = "LinkLabel_Back";
            this.LinkLabel_Back.Size = new System.Drawing.Size(75, 21);
            this.LinkLabel_Back.TabIndex = 10;
            this.LinkLabel_Back.TabStop = true;
            this.LinkLabel_Back.Text = "<-- Назад";
            this.LinkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Back_LinkClicked);
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(648, 406);
            this.Controls.Add(this.LinkLabel_Back);
            this.Controls.Add(this.Button_CalCul);
            this.Controls.Add(this.TextBox_AppraisedPrice);
            this.Controls.Add(this.TextBox_Weight);
            this.Controls.Add(this.Label_AppraisedPrice);
            this.Controls.Add(this.Label_Weight);
            this.Controls.Add(this.ComboBox_ReceiverTown);
            this.Controls.Add(this.Label_ReceiverTown);
            this.Controls.Add(this.Label_SenderTown);
            this.Controls.Add(this.ComboBox_SenderTown);
            this.Controls.Add(this.Label_CalCulPay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaPost - Calculate price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_CalCulPay;
        private System.Windows.Forms.ComboBox ComboBox_SenderTown;
        private System.Windows.Forms.Label Label_SenderTown;
        private System.Windows.Forms.Label Label_ReceiverTown;
        private System.Windows.Forms.ComboBox ComboBox_ReceiverTown;
        private System.Windows.Forms.Label Label_Weight;
        private System.Windows.Forms.Label Label_AppraisedPrice;
        private System.Windows.Forms.TextBox TextBox_Weight;
        private System.Windows.Forms.TextBox TextBox_AppraisedPrice;
        private System.Windows.Forms.Button Button_CalCul;
        private System.Windows.Forms.LinkLabel LinkLabel_Back;
    }
}