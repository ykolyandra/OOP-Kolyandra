using OOP.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OOP.Desing
{
    public partial class WorkerEditPosts : Form
    {
        private Operator current_operator;
        Admin admin=new Admin();
        public PostBoxList packages;
        public WorkerEditPosts(Operator current_operator, PostBoxList packages)
        {
            InitializeComponent();

            this.current_operator = current_operator;
            this.packages = packages;
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Button_AddLocation_Click(object sender, EventArgs e)
        {
            try
            {
                //присвоєння змінних
                string code = TextBox_PostCode.Text;
                string new_location = TextBox_CurrentLocation.Text;

                //виклик методу
                if (current_operator != null)
                    current_operator.ChangeDetails(code, new_location);
                else
                    admin.ChangeDetails(code, new_location);

                //оновлення даних
                packages.SavePackagesData();
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

        private void Button_ChangeLastDay_Click(object sender, EventArgs e)
        {
            try
            {
                //присвоєння змінних
                string code = TextBox_PostCode.Text;
                string dateString = TextBox_LastDay.Text;
                DateTime date;
                if (!DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    throw new FormatException("Неправильний формат дати. Використовуйте формат dd/MM/yyyy.");
                }
                date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                //виклик методу
                if (current_operator != null)
                    current_operator.SetLastDay(code, date);
                else
                    admin.SetLastDay(code, date);

                //збереження даних
                packages.SavePackagesData();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_ChangePayStatus_Click(object sender, EventArgs e)
        {
            try
            {
                //присвоєння змінних
                string code = TextBox_PostCode.Text;
                string new_status = ComboBox_NewPayStatus.SelectedItem.ToString();

                PaymentStatus pay_status = (PaymentStatus)Enum.Parse(typeof(PaymentStatus), new_status);

                //виклик методу
                if (current_operator != null)
                    current_operator.ChangePayStatus(code, pay_status);
                else
                    admin.ChangePayStatus(code, pay_status);

                //збереження даних
                packages.SavePackagesData();
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

        private void ButtonChangeStatus_Click(object sender, EventArgs e)
        {
            try
            {
                //присвоєння змінних
                string code = TextBox_PostCode.Text;
                string new_status = ComboBox_NewStatus.SelectedItem.ToString();

                Status status = (Status)Enum.Parse(typeof(Status), new_status);

                //виклик методу
                if (current_operator != null)
                    current_operator.ChangeStatus(code, status);
                else
                    admin.ChangeStatus(code, status);

                //збереження даних
                packages.SavePackagesData();
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
