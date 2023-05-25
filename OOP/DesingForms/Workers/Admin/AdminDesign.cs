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
    public partial class AdminDesign : Form
    {
        public PostBoxList packages;
        public OperatorList operators;
        public UserList users;
        public AdminDesign(PostBoxList packages, OperatorList operators, UserList users)
        {
            InitializeComponent();

            this.packages = packages;
            this.operators = operators;
            this.users = users;
        }

        private void Button_EditPost_Click(object sender, EventArgs e)
        {
            WorkerEditPosts Form = new WorkerEditPosts(null, packages);
            Form.Show();
        }

        private void Button_ShowOperators_Click(object sender, EventArgs e)
        {
            AdminShowInfo Form = new AdminShowInfo("про операторів");
            Form.Show();
        }

        private void Button_ShowUsers_Click(object sender, EventArgs e)
        {
            AdminShowInfo Form = new AdminShowInfo("про користувачів");
            Form.Show();
        }

        private void Button_ShowPostBoxes_Click(object sender, EventArgs e)
        {
            AdminShowInfo Form = new AdminShowInfo("про посилки");
            Form.Show();
        }

        private void Button_AddOperator_Click(object sender, EventArgs e)
        {
            NewOperator Form = new NewOperator(operators);
            Form.Show();
        }

        private void Button_CreatePromocode_Click(object sender, EventArgs e)
        {
            NewPromocode Form = new NewPromocode(users);
            Form.Show();
        }
    }
}
