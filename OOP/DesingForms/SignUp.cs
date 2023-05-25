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
    public partial class SignUp : Form
    {
        Guest guest = new Guest();
        private User currentUser;
        public UserList users;
        public PostBoxList packages;
        public SignUp(UserList users, PostBoxList packages)
        {
            InitializeComponent();
            this.users = users;
            this.packages = packages;
        }

        private void Button_Registration_Click(object sender, EventArgs e)
        {
            try
            {
                //перевірка вводу
                if (TextBox_Adress.Text == "" || TextBox_Email.Text == "" || TextBox_Name.Text == ""||TextBox_SecondName.Text==""||TextBox_Surname.Text==""||TextBox_Phone.Text==""||TextBox_Password.Text==""||TextBox_SamePassword.Text=="")
                    throw new Exception("Заповніть всі поля!");
                //присвоєння значень
                string surname = TextBox_Surname.Text;
                string name = TextBox_Name.Text;
                string second_name = TextBox_SecondName.Text;
                string phone = TextBox_Phone.Text;
                string adress = TextBox_Adress.Text;
                string email = TextBox_Email.Text;
                string password = TextBox_Password.Text;
                string same_password = TextBox_SamePassword.Text;
                //виклик методу
                guest.Registration(surname, name, second_name, phone, adress, email, password, same_password);
                currentUser = UserList.users[UserList.users.Count - 1];
                //збереження даних
                users.SaveUserData();
                UserDesign User = new UserDesign(currentUser, packages, users);
                User.Show();
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
