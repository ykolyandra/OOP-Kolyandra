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

namespace OOP
{
    public partial class MyPosts : Form
    {
        User currentUser;
        PostBoxList packages;

        public MyPosts(User user, PostBoxList all_packages)
        {
            InitializeComponent();
            currentUser = user;
            packages = all_packages;

            //вивід інформації про посилки цього користувача на екран
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(currentUser.Print());
            RichTextBox_MyPosts.Text=sb.ToString();
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Button_ChangeInfo_Click(object sender, EventArgs e)
        {
            Form EditPost = new EditPost(currentUser, packages);
            EditPost.ShowDialog();

            //вивід оновленого списку з посилками
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(currentUser.Print());
            RichTextBox_MyPosts.Text = sb.ToString();
        }
    }
}
