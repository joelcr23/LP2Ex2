using GameSoftDAO;
using GameSoftDev;
using GameSoftDev.opt;
using GameSoftDev.pject;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSoftApp
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
