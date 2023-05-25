using OOP.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Desing
{
    public partial class AdminShowInfo : Form
    {
        Admin admin=new Admin();
        public AdminShowInfo(string objects)
        {
            InitializeComponent();

            //відображення списку відповідно до переданого запиту
            StringBuilder sb = new StringBuilder();

            Label_AddInfo.Text = objects;

            if (objects == "про посилки")
                sb.AppendLine(admin.Print());
            else if (objects == "про користувачів")
                sb.AppendLine(admin.ShowUsers());
            else if (objects == "про операторів")
                sb.AppendLine(admin.ShowOperators());
            RichTextBox_Info.Text = sb.ToString();
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
