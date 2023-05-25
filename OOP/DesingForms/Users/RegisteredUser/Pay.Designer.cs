namespace OOP
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.Label_TitlePay = new System.Windows.Forms.Label();
            this.Label_PostCode = new System.Windows.Forms.Label();
            this.Label_CardNumber = new System.Windows.Forms.Label();
            this.Label_Month_and_Year = new System.Windows.Forms.Label();
            this.TextBox_PostCode = new System.Windows.Forms.TextBox();
            this.Label_PaymentDetails = new System.Windows.Forms.Label();
            this.TextBox_CardNumber = new System.Windows.Forms.TextBox();
            this.TextBox_Month_and_Year = new System.Windows.Forms.TextBox();
            this.Button_Pay = new System.Windows.Forms.Button();
            this.LinkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.TextBox_CVV = new System.Windows.Forms.TextBox();
            this.Label_CVV = new System.Windows.Forms.Label();
            this.RadioButton_Yes = new System.Windows.Forms.RadioButton();
            this.Label_UsePromocode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_TitlePay
            // 
            this.Label_TitlePay.AutoSize = true;
            this.Label_TitlePay.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TitlePay.Location = new System.Drawing.Point(111, 21);
            this.Label_TitlePay.Name = "Label_TitlePay";
            this.Label_TitlePay.Size = new System.Drawing.Size(154, 44);
            this.Label_TitlePay.TabIndex = 0;
            this.Label_TitlePay.Text = "Оплата";
            // 
            // Label_PostCode
            // 
            this.Label_PostCode.AutoSize = true;
            this.Label_PostCode.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_PostCode.Location = new System.Drawing.Point(28, 84);
            this.Label_PostCode.Name = "Label_PostCode";
            this.Label_PostCode.Size = new System.Drawing.Size(171, 22);
            this.Label_PostCode.TabIndex = 1;
            this.Label_PostCode.Text = "Введіть код посилки:";
            // 
            // Label_CardNumber
            // 
            this.Label_CardNumber.AutoSize = true;
            this.Label_CardNumber.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_CardNumber.Location = new System.Drawing.Point(28, 196);
            this.Label_CardNumber.Name = "Label_CardNumber";
            this.Label_CardNumber.Size = new System.Drawing.Size(117, 22);
            this.Label_CardNumber.TabIndex = 3;
            this.Label_CardNumber.Text = "Номер карти:";
            // 
            // Label_Month_and_Year
            // 
            this.Label_Month_and_Year.AutoSize = true;
            this.Label_Month_and_Year.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Month_and_Year.Location = new System.Drawing.Point(28, 267);
            this.Label_Month_and_Year.Name = "Label_Month_and_Year";
            this.Label_Month_and_Year.Size = new System.Drawing.Size(70, 22);
            this.Label_Month_and_Year.TabIndex = 4;
            this.Label_Month_and_Year.Text = "ММ/РР:";
            // 
            // TextBox_PostCode
            // 
            this.TextBox_PostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_PostCode.Location = new System.Drawing.Point(32, 109);
            this.TextBox_PostCode.Name = "TextBox_PostCode";
            this.TextBox_PostCode.Size = new System.Drawing.Size(311, 34);
            this.TextBox_PostCode.TabIndex = 6;
            // 
            // Label_PaymentDetails
            // 
            this.Label_PaymentDetails.AutoSize = true;
            this.Label_PaymentDetails.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_PaymentDetails.Location = new System.Drawing.Point(48, 156);
            this.Label_PaymentDetails.Name = "Label_PaymentDetails";
            this.Label_PaymentDetails.Size = new System.Drawing.Size(275, 28);
            this.Label_PaymentDetails.TabIndex = 11;
            this.Label_PaymentDetails.Text = "Ввід реквізитів оплати";
            // 
            // TextBox_CardNumber
            // 
            this.TextBox_CardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_CardNumber.Location = new System.Drawing.Point(32, 221);
            this.TextBox_CardNumber.Name = "TextBox_CardNumber";
            this.TextBox_CardNumber.Size = new System.Drawing.Size(311, 34);
            this.TextBox_CardNumber.TabIndex = 12;
            // 
            // TextBox_Month_and_Year
            // 
            this.TextBox_Month_and_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Month_and_Year.Location = new System.Drawing.Point(32, 292);
            this.TextBox_Month_and_Year.Name = "TextBox_Month_and_Year";
            this.TextBox_Month_and_Year.Size = new System.Drawing.Size(132, 34);
            this.TextBox_Month_and_Year.TabIndex = 13;
            // 
            // Button_Pay
            // 
            this.Button_Pay.BackColor = System.Drawing.Color.Teal;
            this.Button_Pay.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Pay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Pay.Location = new System.Drawing.Point(100, 402);
            this.Button_Pay.Name = "Button_Pay";
            this.Button_Pay.Size = new System.Drawing.Size(178, 49);
            this.Button_Pay.TabIndex = 15;
            this.Button_Pay.Text = "Оплатити";
            this.Button_Pay.UseVisualStyleBackColor = false;
            this.Button_Pay.Click += new System.EventHandler(this.Button_Pay_Click);
            // 
            // LinkLabel_Back
            // 
            this.LinkLabel_Back.AutoSize = true;
            this.LinkLabel_Back.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Back.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Back.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel_Back.Name = "LinkLabel_Back";
            this.LinkLabel_Back.Size = new System.Drawing.Size(82, 22);
            this.LinkLabel_Back.TabIndex = 16;
            this.LinkLabel_Back.TabStop = true;
            this.LinkLabel_Back.Text = "<-- Назад";
            this.LinkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Back_LinkClicked);
            // 
            // TextBox_CVV
            // 
            this.TextBox_CVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_CVV.Location = new System.Drawing.Point(211, 292);
            this.TextBox_CVV.Name = "TextBox_CVV";
            this.TextBox_CVV.Size = new System.Drawing.Size(132, 34);
            this.TextBox_CVV.TabIndex = 18;
            // 
            // Label_CVV
            // 
            this.Label_CVV.AutoSize = true;
            this.Label_CVV.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_CVV.Location = new System.Drawing.Point(207, 267);
            this.Label_CVV.Name = "Label_CVV";
            this.Label_CVV.Size = new System.Drawing.Size(43, 22);
            this.Label_CVV.TabIndex = 17;
            this.Label_CVV.Text = "CVV:";
            // 
            // RadioButton_Yes
            // 
            this.RadioButton_Yes.AutoSize = true;
            this.RadioButton_Yes.Location = new System.Drawing.Point(172, 376);
            this.RadioButton_Yes.Name = "RadioButton_Yes";
            this.RadioButton_Yes.Size = new System.Drawing.Size(52, 20);
            this.RadioButton_Yes.TabIndex = 19;
            this.RadioButton_Yes.TabStop = true;
            this.RadioButton_Yes.Text = "Так";
            this.RadioButton_Yes.UseVisualStyleBackColor = true;
            // 
            // Label_UsePromocode
            // 
            this.Label_UsePromocode.AutoSize = true;
            this.Label_UsePromocode.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_UsePromocode.Location = new System.Drawing.Point(85, 329);
            this.Label_UsePromocode.Name = "Label_UsePromocode";
            this.Label_UsePromocode.Size = new System.Drawing.Size(238, 44);
            this.Label_UsePromocode.TabIndex = 20;
            this.Label_UsePromocode.Text = "Ви маєте промокод.\r\nБажаєте його використати?";
            this.Label_UsePromocode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(386, 463);
            this.Controls.Add(this.Label_UsePromocode);
            this.Controls.Add(this.RadioButton_Yes);
            this.Controls.Add(this.TextBox_CVV);
            this.Controls.Add(this.Label_CVV);
            this.Controls.Add(this.LinkLabel_Back);
            this.Controls.Add(this.Button_Pay);
            this.Controls.Add(this.TextBox_Month_and_Year);
            this.Controls.Add(this.TextBox_CardNumber);
            this.Controls.Add(this.Label_PaymentDetails);
            this.Controls.Add(this.TextBox_PostCode);
            this.Controls.Add(this.Label_Month_and_Year);
            this.Controls.Add(this.Label_CardNumber);
            this.Controls.Add(this.Label_PostCode);
            this.Controls.Add(this.Label_TitlePay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User - Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_TitlePay;
        private System.Windows.Forms.Label Label_PostCode;
        private System.Windows.Forms.Label Label_CardNumber;
        private System.Windows.Forms.Label Label_Month_and_Year;
        private System.Windows.Forms.TextBox TextBox_PostCode;
        private System.Windows.Forms.Label Label_PaymentDetails;
        private System.Windows.Forms.TextBox TextBox_CardNumber;
        private System.Windows.Forms.TextBox TextBox_Month_and_Year;
        private System.Windows.Forms.Button Button_Pay;
        private System.Windows.Forms.LinkLabel LinkLabel_Back;
        private System.Windows.Forms.TextBox TextBox_CVV;
        private System.Windows.Forms.Label Label_CVV;
        private System.Windows.Forms.RadioButton RadioButton_Yes;
        private System.Windows.Forms.Label Label_UsePromocode;
    }
}