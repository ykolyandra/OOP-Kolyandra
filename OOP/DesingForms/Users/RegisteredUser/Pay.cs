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
    public partial class Pay : Form
    {
        User currentUser;
        PostBoxList packages;
        UserList userList;

        public delegate void PaymentCompletedEventHandler(object sender, EventArgs e);
        public event PaymentCompletedEventHandler PaymentCompleted;

        public Pay(User user, PostBoxList all_packages, UserList userList)
        {
            InitializeComponent();
            currentUser = user;
            packages = all_packages;
            this.userList = userList;
            
            //якщо користувач не має промокоду
            if (currentUser.Discount == 0)
            {
                Label_UsePromocode.Visible = false;
                RadioButton_Yes.Visible = false;
            }
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Button_Pay_Click(object sender, EventArgs e)
        {
            try
            {
                //перевірка чи всі поля введені
                if (TextBox_CardNumber.Text == "" || TextBox_Month_and_Year.Text == "" || TextBox_CVV.Text == "" || TextBox_PostCode.Text == "")
                {
                    MessageBox.Show("Заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //присвоєння значень
                string card_number = TextBox_CardNumber.Text;
                string mm_yy = TextBox_Month_and_Year.Text;
                string cvv = TextBox_CVV.Text;
                string code = TextBox_PostCode.Text;

                bool use_promocode = RadioButton_Yes.Checked;

                //виклик методу
                currentUser.Pay(code, card_number, mm_yy, cvv, currentUser.Phone);

                //перевірка на відображення RadioButton_Yes
                if (RadioButton_Yes.Checked == true)
                {
                    User user = UserList.users.FirstOrDefault(u => u.Password == currentUser.Password && u.Phone == currentUser.Phone);

                    //якщо користувача знайдено
                    if (user != null)
                    {
                        currentUser.Discount = 0;
                        user.Discount = 0;
                    }
                }

                //оновлення даних
                packages.SavePackagesData();
                userList.SaveUserData();

                //очищення полів
                TextBox_CardNumber.Text = "";
                TextBox_Month_and_Year.Text = "";
                TextBox_CVV.Text = "";
                TextBox_PostCode.Text = "";
                RadioButton_Yes.Checked = false;

                //виклик події PaymentCompleted
                PaymentCompleted?.Invoke(this, e);
                MessageBox.Show("Платіж успішно завершений!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
