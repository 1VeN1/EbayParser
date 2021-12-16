using System;
using System.Windows.Forms;

namespace EbayParser
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Parser_eBay());
        }
    }
}
