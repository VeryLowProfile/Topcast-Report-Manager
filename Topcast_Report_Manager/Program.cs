using System;
using System.Windows.Forms;
using Topcast_Report_Manager.Forms;

namespace Topcast_Report_Manager
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>


        [STAThread]
        static void Main()
        {
           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new Topcast_Report_Manager_Main());
        }
    }
}
