using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSoftApp
{
    public partial class frmMain : Form
    {
        private frmManageResources formManageResources;
        private frmEmployees formEmployees;
        public frmMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void asignarRecursosOTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formManageResources == null) {
                formManageResources = new frmManageResources();
                formManageResources.FormClosing += formManageResources_FormOneClosing;
                formManageResources.MdiParent = this;
            }
            formManageResources.Visible = true;
        }

        public void formManageResources_FormOneClosing(object sender, FormClosingEventArgs e)
        {
            formManageResources = null;
        }

        private void EmpleadosPorDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formEmployees == null)
            {
                formEmployees = new frmEmployees();
                formEmployees.FormClosing += formManageResources_FormOneClosing;
                formEmployees.MdiParent = this;
            }
            formEmployees.Visible = true;
        }
    }
}
