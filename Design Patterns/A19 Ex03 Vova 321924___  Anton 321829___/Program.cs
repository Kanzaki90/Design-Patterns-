using System;
using System.Windows.Forms;


// $G$ THE-001 (-15) your grade on diagrams document - 85 please see comments inside the document. (50% of your grade).

namespace A19_Ex03_Vova_321924466_Anton_321829707
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppUI());
        }
    }
}