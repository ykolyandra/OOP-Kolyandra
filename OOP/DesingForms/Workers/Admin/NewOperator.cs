using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Code
{
    public partial class NewOperator : Form
    {
        Admin admin = new Admin();
        OperatorList operators;
        public NewOperator(OperatorList operators)
        {
            InitializeComponent();
            this.operators = operators;
        }

        private void LinkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Button_CreateOperator_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Password.Text == "" || TextBox_Name.Text == "")
                    throw new Exception("Заповніть всі поля!");
                //присвоєння змінних
                string code = TextBox_Name.Text;
                string password = TextBox_Password.Text;

                int operators_number = OperatorList.operators.Count;

                //виклик методу
                admin.NewOperator(code, password);

                if (operators_number + 1 == OperatorList.operators.Count)
                {
                    //оновлення даних
                    operators.SaveOperatorData();
                    MessageBox.Show("Нового оператора створено.");

                    //очищення полів
                    TextBox_Name.Text="";
                    TextBox_Password.Text="";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
