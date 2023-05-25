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
    public partial class OperatorDesign : Form
    {
        private Operator current_operator;
        public PostBoxList packages;
        public OperatorDesign(Operator this_operator, PostBoxList all_packages)
        {
            InitializeComponent();
            current_operator = this_operator;
            packages = all_packages;

            Label_Name.Text=current_operator.Name;
        }

        private void Button_ShowPosts_Click(object sender, EventArgs e)
        {
            WorkerShowPosts Form = new WorkerShowPosts(current_operator);
            Form.Show();
        }

        private void Button_EditPost_Click(object sender, EventArgs e)
        {
            WorkerEditPosts Form = new WorkerEditPosts(current_operator, packages);
            Form.Show();
        }
    }
}
