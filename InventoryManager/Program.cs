using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManager;

namespace InventoryManager
{
    internal static class Program
    {
        public static string UserRole = ""; 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            
            if (!string.IsNullOrEmpty(UserRole)) 
            {
                Application.Run(new Mainform());
            }
        }
    }
}
