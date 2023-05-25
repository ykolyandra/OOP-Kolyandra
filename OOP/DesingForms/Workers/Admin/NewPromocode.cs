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
    public partial class NewPromocode : Form
    {
        Admin admin = new Admin();
        UserList users;
        public NewPromocode(UserList users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Button_AddPromocode_Click(object sender, EventArgs e)
        {
            try
            {
                //присвоєння полів
                string phone = TextBox_Phone.Text;
                string password = TextBox_Password.Text;
                int promocode = Convert.ToInt32(TextBox_Promocode.Text);

                //виклик методу
                admin.NewDiscount(promocode, password, phone);

                //оновлення даних
                users.SaveUserData();
                MessageBox.Show($"Промокод додано.");

                //очищення полів
                TextBox_Phone.Text="";
                TextBox_Password.Text="";
                TextBox_Promocode.Text = "";
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
