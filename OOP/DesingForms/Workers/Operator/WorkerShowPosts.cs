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
    public partial class WorkerShowPosts : Form
    {
        Operator current_operator=new Operator();

        public WorkerShowPosts(Operator this_operator)
        {
            InitializeComponent();

            current_operator = this_operator;

            //вивід інформації про посилки
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(current_operator.Print());

            RichTextBox_Posts.Text = sb.ToString();
            
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
