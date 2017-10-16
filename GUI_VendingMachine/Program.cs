using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_VendingMachine
{

    class Program
    {


        /// <summary>
        /// This is a vending machine program with GUI. The version 2.0 of my original
        /// Console Vending Machine
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
