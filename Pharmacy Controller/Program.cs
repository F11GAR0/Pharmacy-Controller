using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Controller
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Globals.Log("App OEP start");
/*#if !NET462
            MessageBox.Show("Warning, u need .NET 4.6.2 for correct work!", "Warning");
            Globals.Log("DETECTED NOT 462 VER");
#endif
*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartPageForm());
        }
    }
}
