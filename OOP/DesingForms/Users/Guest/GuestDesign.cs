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
    public partial class GuestDesign : Form
    {
        public GuestDesign()
        {
            InitializeComponent();
        }

        private void Button_CalCulPost_Click(object sender, EventArgs e)
        {
            Form Calcul = new Calculation();
            Calcul.ShowDialog();
        }

        private void Button_TrackPost_Click(object sender, EventArgs e)
        {
            Form GuestFind = new GuestFind();
            GuestFind.ShowDialog();
        }
    }
}
