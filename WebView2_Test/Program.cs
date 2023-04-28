using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2_Test
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //htmlをForm1で開く
            string url = System.IO.Path.GetFullPath(@"..\\..\\html\\sample.html");
            Application.Run(new Form1(url));
        }
    }
}
