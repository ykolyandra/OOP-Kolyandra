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
    public partial class ChangeInfo : Form
    {
        User currentUser;
        UserList userList;

        public delegate void InfoChangedEventHandler(object sender, EventArgs e);
        public event InfoChangedEventHandler InfoChanged;

        public ChangeInfo(User user, UserList userList)
        {
            InitializeComponent();
            currentUser = user;
            TextBox_Password.UseSystemPasswordChar = true;
            this.userList = userList;
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Button_SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                //присвоєння значень
                string password = TextBox_Password.Text;
                string surname = TextBox_Surname.Text;
                string name = TextBox_Name.Text;
                string second_name = TextBox_SecondName.Text;
                string email = TextBox_Email.Text;
                string phone = TextBox_Phone.Text;
                string adress = TextBox_Adress.Text;

                //виклик методу зміни інформації
                currentUser.ChangeOwnInfo(surname, name, second_name, phone, adress, email, password);

                // Виклик події InfoChanged
                InfoChanged?.Invoke(this, e);
                MessageBox.Show("Особисту інформацію змінено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //збереження оновлених даних
                userList.SaveUserData();
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

        private void Button_Pussword_IsVisible_Click(object sender, EventArgs e)
        {
            if (TextBox_Password.UseSystemPasswordChar) // Якщо використовується системний символ паролю
            {
                TextBox_Password.UseSystemPasswordChar = false; // Вимкнути використання системного символу паролю
            }
            else
            {
                TextBox_Password.UseSystemPasswordChar = true; // Увімкнути використання системного символу паролю
            }
        }
    }
}
