using System;
using System.Windows.Forms;

namespace Bai5_4_QuanLyTapTin
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
