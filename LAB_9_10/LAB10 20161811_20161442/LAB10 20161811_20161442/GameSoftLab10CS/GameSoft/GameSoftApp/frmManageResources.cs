using GameSoftController;
using GameSoftDev.pject;
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
    public partial class frmManageResources : Form
    {
        public frmManageResources()
        {
            InitializeComponent();
            //Consultamos los proyectos activos y enlazamos la información con el combobox
            cboProject.DataSource = DBController.queryAllProjects();
            cboProject.DisplayMember = "Name";
            dgvTasks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTasks.AutoGenerateColumns = false;
            stablishFormStatus(Status.Initial);
        }

        public void stablishFormStatus(Status status)
        {
            switch (status)
            {
                case Status.Initial:
                    gbDataProject.Enabled = true;
                    dgvTasks.Enabled = false;
                    btnSave.Enabled = false;
                    btnAssign.Enabled = true;
                    cboProject.SelectedIndex = -1;
                    break;
                case Status.Edit:
                    gbDataProject.Enabled = true;
                    dgvTasks.Enabled = true;
                    btnSave.Enabled = true;
                    btnAssign.Enabled = false;
                    break;
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            stablishFormStatus(Status.Edit);
        }

        private void selectionChangeCommittedCBOProject(object sender, EventArgs e)
        {
            int selectedIdProject = ((Project)cboProject.SelectedItem).Id;
            cboPhaseProject.DataSource = DBController.queryAllPhaseProjectsbyIdProject(selectedIdProject);
            cboPhaseProject.DisplayMember = "PhaseName";
            cboPhaseProject.SelectedIndex = -1;
        }

        private void cboActivity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Activity activity = (Activity)cboActivity.SelectedItem;
            txtDescriptionActivity.Text = activity.Description;
            BindingList<GameSoftDev.pject.Task> tasks = DBController.queryAllTasksbyIdActivity(activity.Id);
            foreach (GameSoftDev.pject.Task task in tasks)
            {
                task.Time = DBController.queryTimebyIdTask(task.Id);
                task.Money = DBController.queryMoneybyIdTask(task.Id);
                task.Participants = DBController.queryParticipantsbyIdTask(task.Id);
            }
            dgvTasks.DataSource = tasks;
        }

        private void cboPhaseProject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedIdPhaseProject = ((PhaseProject)cboPhaseProject.SelectedItem).Id;
            cboActivity.DataSource = DBController.queryAllActivitiesbyIdPhaseProject(selectedIdPhaseProject);
            cboActivity.DisplayMember = "Name";
            cboActivity.SelectedIndex = -1;

        }

        private void dgvTasks_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentCell.ColumnIndex == 6)
            {
                frmParticipant frm = new frmParticipant();
                //frm.MdiParent = this.ParentForm;
                frm.ShowDialog();
            }
        }

    }
}
