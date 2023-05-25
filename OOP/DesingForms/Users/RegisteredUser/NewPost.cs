using OOP.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class NewPost : Form
    {
        User currentUser;
        PostBoxList packages;
        public NewPost(User user, PostBoxList all_packages)
        {
            InitializeComponent();
            currentUser = user;
            packages = all_packages;
        }


        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Button_CreatePost_Click(object sender, EventArgs e)
        {
            try
            {
                //перевірка чи всі поля введено та присвоєння їх змінним для виклику методу
                if (ComboBox_ReceiverTown.SelectedIndex == -1 || ComboBox_SenderTown.SelectedIndex == -1)
                    throw new Exception("Не вказано місто відправки/одержання.");
                if (TextBox_SenderFullName.Text == "" || TextBox_ReceiverFullName.Text == "")
                    throw new Exception("Не вказано ПІБ відправника/одержувача.");
                if (TextBox_ReceiverAdress.Text == "" || TextBox_SenderAdress.Text == "")
                    throw new Exception("Не вказано адресу відправника/одержувача.");
                if (TextBox_SenderPhone.Text == "" || TextBox_ReceiverPhone.Text == "")
                    throw new Exception("Не вказано номер телефону відправника/одержувача.");
                if (TextBox_Weight.Text == "")
                    throw new Exception("Не вказано вагу посилки.");
                if (TextBox_AppRaisedPrice.Text == "")
                    throw new Exception("Не вказано оціночну вартість.");
                if (TextBox_AppRaisedPrice.Text.Any(char.IsLetter) || TextBox_Weight.Text.Any(char.IsLetter))
                    throw new Exception("У поля 'вага' та 'орієнтовна ціна' мають бути введені лише додатні числа.");
                string sender_full_name = TextBox_SenderFullName.Text;
                string sender_phone = TextBox_SenderPhone.Text;
                string sender_adress = TextBox_SenderAdress.Text;
                string selected_sender_town = ComboBox_SenderTown.SelectedItem.ToString();
                City sender_town = (City)Enum.Parse(typeof(City), selected_sender_town);

                string receiver_full_name = TextBox_ReceiverFullName.Text;
                string receiver_phone = TextBox_ReceiverPhone.Text;
                string receiver_adress = TextBox_ReceiverAdress.Text;
                string selected_receiver_town = ComboBox_ReceiverTown.SelectedItem.ToString();
                City receiver_town = (City)Enum.Parse(typeof(City), selected_receiver_town);

                string description = RichTextBox_Description.Text;

                string w = TextBox_Weight.Text;
                w = w.Replace(",", ".");
                double weight = Convert.ToDouble(w);

                int appraised_price = Convert.ToInt32(TextBox_AppRaisedPrice.Text);

                int posts_number= PostBoxList.packages.Count;

                //виклик методу
                currentUser.NewPostBox(appraised_price, sender_full_name, sender_adress, sender_town, sender_phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages);

                //перевірка чи посилку додано
                if (posts_number + 1 == PostBoxList.packages.Count) {
                    PostBox lastpackage = PostBoxList.packages[PostBoxList.packages.Count - 1];

                    //оновлення даних
                    packages.SavePackagesData();
                    MessageBox.Show("Посилку створено. Її код: " + lastpackage.Code);

                    //очищення всіх полів
                    TextBox_SenderFullName.Text = "";
                    TextBox_SenderPhone.Text="";
                    TextBox_SenderAdress.Text = "";
                    TextBox_ReceiverFullName.Text="";
                    TextBox_ReceiverPhone.Text="";
                    TextBox_ReceiverAdress.Text="";
                    RichTextBox_Description.Text = "";
                    TextBox_Weight.Text = "";
                    TextBox_AppRaisedPrice.Text = "";
                    ComboBox_ReceiverTown.SelectedIndex = -1;
                    ComboBox_SenderTown.SelectedIndex = -1;
                }
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
