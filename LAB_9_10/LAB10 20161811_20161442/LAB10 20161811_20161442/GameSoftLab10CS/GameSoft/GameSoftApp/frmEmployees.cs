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
    public partial class frmEmployees : Form
    {
        private DBControllerWS.DBControllerWSClient controller;
        private DBControllerWS.department selectedDep=null;
        private BindingList<DBControllerWS.employee> listEmp;
        public frmEmployees()
        {
            InitializeComponent();
            controller = new DBControllerWS.DBControllerWSClient();
            BindingList<DBControllerWS.department> listDep = new BindingList<DBControllerWS.department>(controller.queryAllDepartmentsIndependent());
            cmbDepartments.DataSource = listDep;
            cmbDepartments.DisplayMember = "name";
            dgvEmployees.AutoGenerateColumns = false;
            selectedDep = (DBControllerWS.department)cmbDepartments.SelectedItem;
            listEmp = new BindingList<DBControllerWS.employee>(controller.queryAllEmployeesIndependent(selectedDep.id));
            dgvEmployees.DataSource = listEmp;
        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedDep != null)
            {
                selectedDep = (DBControllerWS.department)cmbDepartments.SelectedItem;
                listEmp = new BindingList<DBControllerWS.employee>(controller.queryAllEmployeesIndependent(selectedDep.id));
                dgvEmployees.DataSource = listEmp;
            }
            
        }
    }
}
