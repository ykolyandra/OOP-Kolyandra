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
    public partial class UserDesign : Form
    {
        private User currentUser;
        public PostBoxList packages;
        public UserList users;
        public UserDesign(User user, PostBoxList all_packages, UserList users)
        {
            InitializeComponent();

            currentUser = user;
            packages = all_packages;
            DisplayUserData();
            this.users = users;

            Image image = Image.FromFile(currentUser.PhotoFilePath);
            PictureBox_Photo.Image = image;
        }

        public void DisplayUserData()
        {
            string full_name = currentUser.Surname + " " + currentUser.Name + " " + currentUser.SecondName;

            // Відображення даних користувача на формі
            Label_FullName.Text = full_name;
            Label_Phone.Text = currentUser.Phone;
            Label_Email.Text = currentUser.Email;
            Label_Adress.Text = currentUser.Adress;
            if (currentUser.Discount == 0)
                Label_Promocode.Text = "Немає";
            else
                Label_Promocode.Text = currentUser.Discount.ToString()+"%";
        }
        private void Button_CalCulPay_Click(object sender, EventArgs e)
        {
            Form Calcul = new Calculation();
            Calcul.ShowDialog();
        }

        private void Button_CreatePost_Click(object sender, EventArgs e)
        {
            //int count = PostBoxList.packages.Count();
            Form NewPost = new NewPost(currentUser, packages);
            NewPost.ShowDialog();
        }

        private void Button_PayPost_Click(object sender, EventArgs e)
        {
            Form Pay = new Pay(currentUser, packages, users);
            Pay.ShowDialog();
            DisplayUserData();
        }

        private void Button_ChangeInfo_Click(object sender, EventArgs e)
        {
            Form ChangeInfo = new ChangeInfo(currentUser, users);
            ChangeInfo.ShowDialog();
            DisplayUserData();
        }

        private void Button_ShowPosts_Click(object sender, EventArgs e)
        {
            Form MyPosts = new MyPosts(currentUser, packages);
            MyPosts.ShowDialog();
        }

        private void Button_DownloadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //встановлення фільтру для вибору файлів зображень
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //отримання шляху до вибраного файлу
                string filePath = openFileDialog.FileName;
                currentUser.PhotoFilePath=filePath;
                users.SaveUserData();
                try
                {
                    //завантаження зображення з вибраного файлу
                    Image image = Image.FromFile(filePath);

                    //встановлення зображення у PictureBox
                    PictureBox_Photo.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження зображення: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
