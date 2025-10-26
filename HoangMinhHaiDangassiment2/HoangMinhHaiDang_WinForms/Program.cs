using DataAccess;
using System;
using System.Windows.Forms;

namespace HoangMinhHaiDang_WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // ✅ Kiểm tra kết nối EF Core
            TestDb.Check();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
