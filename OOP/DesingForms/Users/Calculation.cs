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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP
{
    public partial class Calculation : Form
    {
        Guest guest = new Guest();
        public Calculation()
        {
            InitializeComponent();
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Button_CalCul_Click(object sender, EventArgs e)
        {
            try
            {
                //перевірка на пусті поля
                if (ComboBox_SenderTown.SelectedIndex == -1 || ComboBox_ReceiverTown.SelectedIndex == -1 || TextBox_Weight.Text == "")
                    throw new Exception("Введіть всі пусті поля!");

                //перевірка на правильно введені дані
                if (TextBox_Weight.Text.Any(char.IsLetter))
                    throw new Exception("Введіть вагу правильно!");

                //присвоєння значень
                string selected_sender_town = ComboBox_SenderTown.SelectedItem.ToString();
                string selected_receiver_town = ComboBox_ReceiverTown.SelectedItem.ToString();

                City sender_town = (City)Enum.Parse(typeof(City), selected_sender_town);
                City receiver_town = (City)Enum.Parse(typeof(City), selected_receiver_town);

                string w = TextBox_Weight.Text;
                w = w.Replace(",", ".");
                double weight = Convert.ToDouble(w);

                //виклик методу
                decimal result = guest.CalculatePay(sender_town, receiver_town, weight);

                //вивід результату
                if (result != 0)
                    TextBox_AppraisedPrice.Text = result.ToString();
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
    }
}
