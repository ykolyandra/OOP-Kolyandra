using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //LogIn logIn = new LogIn();
            //UserDesign userForm=new UserDesign();

            //logIn.FormClosed += (s, args) => {
            //    userForm.Show();
            //};

            Application.Run(new LogIn());
        }
    }
}
