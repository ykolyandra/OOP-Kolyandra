namespace OOP.Desing
{
    partial class WorkerEditPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerEditPosts));
            this.ComboBox_NewPayStatus = new System.Windows.Forms.ComboBox();
            this.TextBox_PostCode = new System.Windows.Forms.TextBox();
            this.LinkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Button_ChangeLastDay = new System.Windows.Forms.Button();
            this.Button_AddLocation = new System.Windows.Forms.Button();
            this.Label_PostCode = new System.Windows.Forms.Label();
            this.Label_NewStatus = new System.Windows.Forms.Label();
            this.Label_NewPayStatus = new System.Windows.Forms.Label();
            this.Label_LastDay = new System.Windows.Forms.Label();
            this.Label_CurrentLocation = new System.Windows.Forms.Label();
            this.TextBox_CurrentLocation = new System.Windows.Forms.TextBox();
            this.TextBox_LastDay = new System.Windows.Forms.TextBox();
            this.ComboBox_NewStatus = new System.Windows.Forms.ComboBox();
            this.Button_ChangePayStatus = new System.Windows.Forms.Button();
            this.ButtonChangeStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBox_NewPayStatus
            // 
            this.ComboBox_NewPayStatus.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_NewPayStatus.FormattingEnabled = true;
            this.ComboBox_NewPayStatus.Items.AddRange(new object[] {
            "Оплачено",
            "Неоплачено"});
            this.ComboBox_NewPayStatus.Location = new System.Drawing.Point(395, 494);
            this.ComboBox_NewPayStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_NewPayStatus.Name = "ComboBox_NewPayStatus";
            this.ComboBox_NewPayStatus.Size = new System.Drawing.Size(450, 36);
            this.ComboBox_NewPayStatus.TabIndex = 0;
            // 
            // TextBox_PostCode
            // 
            this.TextBox_PostCode.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_PostCode.Location = new System.Drawing.Point(395, 110);
            this.TextBox_PostCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_PostCode.Name = "TextBox_PostCode";
            this.TextBox_PostCode.Size = new System.Drawing.Size(450, 36);
            this.TextBox_PostCode.TabIndex = 2;
            // 
            // LinkLabel_Back
            // 
            this.LinkLabel_Back.AutoSize = true;
            this.LinkLabel_Back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LinkLabel_Back.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel_Back.Name = "LinkLabel_Back";
            this.LinkLabel_Back.Size = new System.Drawing.Size(75, 21);
            this.LinkLabel_Back.TabIndex = 4;
            this.LinkLabel_Back.TabStop = true;
            this.LinkLabel_Back.Text = "<-- Назад";
            this.LinkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Back_LinkClicked);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title.Location = new System.Drawing.Point(373, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(414, 44);
            this.Label_Title.TabIndex = 5;
            this.Label_Title.Text = "Редагування посилки";
            // 
            // Button_ChangeLastDay
            // 
            this.Button_ChangeLastDay.BackColor = System.Drawing.Color.Teal;
            this.Button_ChangeLastDay.Font = new System.Drawing.Font("Book Antiqua", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ChangeLastDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_ChangeLastDay.Location = new System.Drawing.Point(927, 300);
            this.Button_ChangeLastDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_ChangeLastDay.Name = "Button_ChangeLastDay";
            this.Button_ChangeLastDay.Size = new System.Drawing.Size(114, 38);
            this.Button_ChangeLastDay.TabIndex = 6;
            this.Button_ChangeLastDay.Text = "Змінити";
            this.Button_ChangeLastDay.UseVisualStyleBackColor = false;
            this.Button_ChangeLastDay.Click += new System.EventHandler(this.Button_ChangeLastDay_Click);
            // 
            // Button_AddLocation
            // 
            this.Button_AddLocation.BackColor = System.Drawing.Color.Teal;
            this.Button_AddLocation.Font = new System.Drawing.Font("Book Antiqua", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_AddLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_AddLocation.Location = new System.Drawing.Point(927, 392);
            this.Button_AddLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_AddLocation.Name = "Button_AddLocation";
            this.Button_AddLocation.Size = new System.Drawing.Size(114, 40);
            this.Button_AddLocation.TabIndex = 9;
            this.Button_AddLocation.Text = "Додати";
            this.Button_AddLocation.UseVisualStyleBackColor = false;
            this.Button_AddLocation.Click += new System.EventHandler(this.Button_AddLocation_Click);
            // 
            // Label_PostCode
            // 
            this.Label_PostCode.AutoSize = true;
            this.Label_PostCode.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_PostCode.Location = new System.Drawing.Point(159, 118);
            this.Label_PostCode.Name = "Label_PostCode";
            this.Label_PostCode.Size = new System.Drawing.Size(221, 28);
            this.Label_PostCode.TabIndex = 11;
            this.Label_PostCode.Text = "Введіть код посилки:";
            // 
            // Label_NewStatus
            // 
            this.Label_NewStatus.AutoSize = true;
            this.Label_NewStatus.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NewStatus.Location = new System.Drawing.Point(218, 607);
            this.Label_NewStatus.Name = "Label_NewStatus";
            this.Label_NewStatus.Size = new System.Drawing.Size(162, 28);
            this.Label_NewStatus.TabIndex = 12;
            this.Label_NewStatus.Text = "Новий статус:";
            // 
            // Label_NewPayStatus
            // 
            this.Label_NewPayStatus.AutoSize = true;
            this.Label_NewPayStatus.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_NewPayStatus.Location = new System.Drawing.Point(135, 499);
            this.Label_NewPayStatus.Name = "Label_NewPayStatus";
            this.Label_NewPayStatus.Size = new System.Drawing.Size(245, 28);
            this.Label_NewPayStatus.TabIndex = 13;
            this.Label_NewPayStatus.Text = "Новий статус оплати:";
            // 
            // Label_LastDay
            // 
            this.Label_LastDay.AutoSize = true;
            this.Label_LastDay.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_LastDay.Location = new System.Drawing.Point(44, 280);
            this.Label_LastDay.Name = "Label_LastDay";
            this.Label_LastDay.Size = new System.Drawing.Size(336, 56);
            this.Label_LastDay.TabIndex = 14;
            this.Label_LastDay.Text = "Дата доставки (потрібно\r\nподити у форматі дд/мм/рррр):\r\n";
            // 
            // Label_CurrentLocation
            // 
            this.Label_CurrentLocation.AutoSize = true;
            this.Label_CurrentLocation.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_CurrentLocation.Location = new System.Drawing.Point(83, 403);
            this.Label_CurrentLocation.Name = "Label_CurrentLocation";
            this.Label_CurrentLocation.Size = new System.Drawing.Size(297, 28);
            this.Label_CurrentLocation.TabIndex = 15;
            this.Label_CurrentLocation.Text = "Поточне місце перебування:";
            // 
            // TextBox_CurrentLocation
            // 
            this.TextBox_CurrentLocation.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_CurrentLocation.Location = new System.Drawing.Point(395, 395);
            this.TextBox_CurrentLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_CurrentLocation.Name = "TextBox_CurrentLocation";
            this.TextBox_CurrentLocation.Size = new System.Drawing.Size(450, 36);
            this.TextBox_CurrentLocation.TabIndex = 16;
            // 
            // TextBox_LastDay
            // 
            this.TextBox_LastDay.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_LastDay.Location = new System.Drawing.Point(395, 300);
            this.TextBox_LastDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_LastDay.Name = "TextBox_LastDay";
            this.TextBox_LastDay.Size = new System.Drawing.Size(450, 36);
            this.TextBox_LastDay.TabIndex = 17;
            // 
            // ComboBox_NewStatus
            // 
            this.ComboBox_NewStatus.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_NewStatus.FormattingEnabled = true;
            this.ComboBox_NewStatus.Items.AddRange(new object[] {
            "Створено",
            "У_дорозі",
            "Доставлено",
            "Одержано"});
            this.ComboBox_NewStatus.Location = new System.Drawing.Point(395, 599);
            this.ComboBox_NewStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_NewStatus.Name = "ComboBox_NewStatus";
            this.ComboBox_NewStatus.Size = new System.Drawing.Size(450, 36);
            this.ComboBox_NewStatus.TabIndex = 18;
            // 
            // Button_ChangePayStatus
            // 
            this.Button_ChangePayStatus.BackColor = System.Drawing.Color.Teal;
            this.Button_ChangePayStatus.Font = new System.Drawing.Font("Book Antiqua", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ChangePayStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_ChangePayStatus.Location = new System.Drawing.Point(927, 494);
            this.Button_ChangePayStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_ChangePayStatus.Name = "Button_ChangePayStatus";
            this.Button_ChangePayStatus.Size = new System.Drawing.Size(114, 38);
            this.Button_ChangePayStatus.TabIndex = 19;
            this.Button_ChangePayStatus.Text = "Змінити";
            this.Button_ChangePayStatus.UseVisualStyleBackColor = false;
            this.Button_ChangePayStatus.Click += new System.EventHandler(this.Button_ChangePayStatus_Click);
            // 
            // ButtonChangeStatus
            // 
            this.ButtonChangeStatus.BackColor = System.Drawing.Color.Teal;
            this.ButtonChangeStatus.Font = new System.Drawing.Font("Book Antiqua", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChangeStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonChangeStatus.Location = new System.Drawing.Point(927, 602);
            this.ButtonChangeStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonChangeStatus.Name = "ButtonChangeStatus";
            this.ButtonChangeStatus.Size = new System.Drawing.Size(114, 38);
            this.ButtonChangeStatus.TabIndex = 20;
            this.ButtonChangeStatus.Text = "Змінити";
            this.ButtonChangeStatus.UseVisualStyleBackColor = false;
            this.ButtonChangeStatus.Click += new System.EventHandler(this.ButtonChangeStatus_Click);
            // 
            // WorkerEditPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1161, 706);
            this.Controls.Add(this.ButtonChangeStatus);
            this.Controls.Add(this.Button_ChangePayStatus);
            this.Controls.Add(this.ComboBox_NewStatus);
            this.Controls.Add(this.TextBox_LastDay);
            this.Controls.Add(this.TextBox_CurrentLocation);
            this.Controls.Add(this.Label_CurrentLocation);
            this.Controls.Add(this.Label_LastDay);
            this.Controls.Add(this.Label_NewPayStatus);
            this.Controls.Add(this.Label_NewStatus);
            this.Controls.Add(this.Label_PostCode);
            this.Controls.Add(this.Button_AddLocation);
            this.Controls.Add(this.Button_ChangeLastDay);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.LinkLabel_Back);
            this.Controls.Add(this.TextBox_PostCode);
            this.Controls.Add(this.ComboBox_NewPayStatus);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WorkerEditPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaPost - Edit posts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_NewPayStatus;
        private System.Windows.Forms.TextBox TextBox_PostCode;
        private System.Windows.Forms.LinkLabel LinkLabel_Back;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Button Button_ChangeLastDay;
        private System.Windows.Forms.Button Button_AddLocation;
        private System.Windows.Forms.Label Label_PostCode;
        private System.Windows.Forms.Label Label_NewStatus;
        private System.Windows.Forms.Label Label_NewPayStatus;
        private System.Windows.Forms.Label Label_LastDay;
        private System.Windows.Forms.Label Label_CurrentLocation;
        private System.Windows.Forms.TextBox TextBox_CurrentLocation;
        private System.Windows.Forms.TextBox TextBox_LastDay;
        private System.Windows.Forms.ComboBox ComboBox_NewStatus;
        private System.Windows.Forms.Button Button_ChangePayStatus;
        private System.Windows.Forms.Button ButtonChangeStatus;
    }
}