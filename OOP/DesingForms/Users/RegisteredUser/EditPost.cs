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
    public partial class EditPost : Form
    {
        User currentUser;
        PostBoxList packages;

        public EditPost(User user, PostBoxList all_packages)
        {
            InitializeComponent();
            currentUser = user;
            packages = all_packages;
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                //присвоєння значень
                string code = TextBox_Code.Text;
                string new_info = RichTextBox_Edit.Text;

                //виклик методу
                currentUser.ChangePostBoxInfo(code, new_info);

                //збереження даних
                packages.SavePackagesData();

                //очищення полів
                TextBox_Code.Text = "";
                RichTextBox_Edit.Text = "";
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
            RichTextBox_Edit.Text = "";
        }
    }
}
