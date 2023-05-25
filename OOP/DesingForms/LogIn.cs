using OOP.Code;
using OOP.Desing;
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
    public partial class LogIn : Form
    {
        public UserList users=new UserList();
        public PostBoxList packages=new PostBoxList();
        public OperatorList operators = new OperatorList();
        public LogIn()
        {
            InitializeComponent();

            TextBox_Password.UseSystemPasswordChar = true;
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            users.LoadUserData();
            packages.LoadPackagesData();
            operators.LoadOperatorData();
        }

        private void Button_LogIn_Click(object sender, EventArgs e)
        {
            //перевірка
            if (TextBox_Phone.Text == "" || TextBox_Password.Text == "")
            {
                MessageBox.Show("Заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //присвоєння змінних
            string phone = TextBox_Phone.Text;
            string password = TextBox_Password.Text;

            //якщо входить користувач
            if (!password.Contains("operator")&&!phone.Contains('#'))
            {
                if (!phone.Contains("+380") || phone.Length != 13 || phone.Any(c => Char.IsLetter(c)))
                {
                    MessageBox.Show("Неправильно вказаний номер телефону.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //пошук користувача
                    User user = UserList.users.FirstOrDefault(u => u.Password == password && u.Phone == phone);
                    if (user == null)
                    {
                        MessageBox.Show("Такого користувача не існує. Спробуйте ввести дані ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (user != null)
                    {
                        this.Hide();
                        UserDesign User = new UserDesign(user, packages, users);
                        User.Show();
                    }
                }
            }//якщо входить оператор
            else if (password.Contains("operator"))
            {
                if (!(phone.Contains('#'))||(phone.Length != 5)||(password.Length < 8))
                    MessageBox.Show("Неправильно введені дані! Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //пошук оператора
                    Operator current_operator=OperatorList.operators.FirstOrDefault(u=>u.Password==password&&u.Name==phone);
                    if(current_operator==null)
                        MessageBox.Show("Такого оператора не існує. Спробуйте ввести дані ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if(current_operator != null)
                    {
                        this.Hide();
                        Form FormOperator = new OperatorDesign(current_operator, packages);
                        FormOperator.Show();
                    }
                }
            }
        }

        private void Label_Registration_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form SingUp = new SignUp(users, packages);
            SingUp.Show();
        }

        private void Label_ContinueLikeGuest_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form Guest = new GuestDesign();
            Guest.Show();
        }

        private void Button_HidePassword_Click(object sender, EventArgs e)
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

        private void ContinueLikeAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form Admin = new AdminDesign(packages, operators, users);
            Admin.Show();
        }
    }
}
