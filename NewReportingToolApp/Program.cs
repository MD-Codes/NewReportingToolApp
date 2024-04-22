using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewReportingToolApp.Models;

namespace NewReportingToolApp
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
            Form1 form1 = new Form1(); //view
            Model model = new Model();
            ReportingToolPresenter presenter = new ReportingToolPresenter(form1, model);
            Application.Run(form1);
        }
    }
}
