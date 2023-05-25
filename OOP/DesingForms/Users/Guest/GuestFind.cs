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
    public partial class GuestFind : Form
    {
        Guest guest = new Guest();
        public GuestFind()
        {
            InitializeComponent();
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Button_Find_Click(object sender, EventArgs e)
        {
            try
            {
                //якщо немає коду
                if (TextBox_Code.Text == "")
                    throw new Exception("Введіть код.");

                string code = TextBox_Code.Text;

                //виклик методу пошуку посилки
                string info = guest.CheckPostBox(code);

                //вивід інформації про посилку на екран
                RichTextBox_Info.Clear();
                RichTextBox_Info.Text = info;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox_Code_TextChanged(object sender, EventArgs e)
        {
            RichTextBox_Info.Text = "";
        }
    }
}
