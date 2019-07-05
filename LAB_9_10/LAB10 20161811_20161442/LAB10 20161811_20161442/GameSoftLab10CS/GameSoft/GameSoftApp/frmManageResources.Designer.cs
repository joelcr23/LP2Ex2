namespace GameSoftApp
{
    partial class frmManageResources
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageResources));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAssign = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.gbDataProject = new System.Windows.Forms.GroupBox();
            this.txtDescriptionActivity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboActivity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPhaseProject = new System.Windows.Forms.ComboBox();
            this.lblPhase = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.lblTasks = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.gbDataProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAssign,
            this.btnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAssign
            // 
            this.btnAssign.Image = ((System.Drawing.Image)(resources.GetObject("btnAssign.Image")));
            this.btnAssign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(152, 22);
            this.btnAssign.Text = "&Asignar/Editar Recursos";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 22);
            this.btnSave.Text = "&Guardar Cambios";
            // 
            // gbDataProject
            // 
            this.gbDataProject.Controls.Add(this.txtDescriptionActivity);
            this.gbDataProject.Controls.Add(this.label2);
            this.gbDataProject.Controls.Add(this.cboActivity);
            this.gbDataProject.Controls.Add(this.label1);
            this.gbDataProject.Controls.Add(this.cboPhaseProject);
            this.gbDataProject.Controls.Add(this.lblPhase);
            this.gbDataProject.Controls.Add(this.lblProject);
            this.gbDataProject.Controls.Add(this.cboProject);
            this.gbDataProject.Location = new System.Drawing.Point(12, 28);
            this.gbDataProject.Name = "gbDataProject";
            this.gbDataProject.Size = new System.Drawing.Size(698, 162);
            this.gbDataProject.TabIndex = 1;
            this.gbDataProject.TabStop = false;
            this.gbDataProject.Text = "Datos del Proyecto";
            // 
            // txtDescriptionActivity
            // 
            this.txtDescriptionActivity.Location = new System.Drawing.Point(248, 107);
            this.txtDescriptionActivity.Multiline = true;
            this.txtDescriptionActivity.Name = "txtDescriptionActivity";
            this.txtDescriptionActivity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionActivity.Size = new System.Drawing.Size(334, 45);
            this.txtDescriptionActivity.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción de la Actividad:";
            // 
            // cboActivity
            // 
            this.cboActivity.FormattingEnabled = true;
            this.cboActivity.Location = new System.Drawing.Point(248, 76);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Size = new System.Drawing.Size(334, 21);
            this.cboActivity.TabIndex = 5;
            this.cboActivity.SelectionChangeCommitted += new System.EventHandler(this.cboActivity_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione la Actividad:";
            // 
            // cboPhaseProject
            // 
            this.cboPhaseProject.FormattingEnabled = true;
            this.cboPhaseProject.Location = new System.Drawing.Point(248, 45);
            this.cboPhaseProject.Name = "cboPhaseProject";
            this.cboPhaseProject.Size = new System.Drawing.Size(334, 21);
            this.cboPhaseProject.TabIndex = 3;
            this.cboPhaseProject.SelectionChangeCommitted += new System.EventHandler(this.cboPhaseProject_SelectionChangeCommitted);
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(105, 48);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(100, 13);
            this.lblPhase.TabIndex = 2;
            this.lblPhase.Text = "Seleccione la Fase:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(105, 18);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(118, 13);
            this.lblProject.TabIndex = 1;
            this.lblProject.Text = "Seleccione el proyecto:";
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(248, 18);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(334, 21);
            this.cboProject.TabIndex = 0;
            this.cboProject.SelectionChangeCommitted += new System.EventHandler(this.selectionChangeCommittedCBOProject);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tarea,
            this.UnidadTiempo,
            this.CantTiempo,
            this.Moneda,
            this.Costo,
            this.Participantes});
            this.dgvTasks.Location = new System.Drawing.Point(12, 219);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(710, 131);
            this.dgvTasks.TabIndex = 2;
            this.dgvTasks.DoubleClick += new System.EventHandler(this.dgvTasks_DoubleClick);
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(12, 200);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(270, 13);
            this.lblTasks.TabIndex = 3;
            this.lblTasks.Text = "Lista de Tareas Asociadas a la Actividad Seleccionada:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Tarea
            // 
            this.Tarea.DataPropertyName = "Name";
            this.Tarea.HeaderText = "Tarea";
            this.Tarea.Name = "Tarea";
            this.Tarea.ReadOnly = true;
            this.Tarea.Width = 110;
            // 
            // UnidadTiempo
            // 
            this.UnidadTiempo.DataPropertyName = "TimeUnitMeasure";
            this.UnidadTiempo.HeaderText = "Unid. Tiempo";
            this.UnidadTiempo.Name = "UnidadTiempo";
            // 
            // CantTiempo
            // 
            this.CantTiempo.DataPropertyName = "TimeQuantity";
            this.CantTiempo.HeaderText = "Cant. Tiempo";
            this.CantTiempo.Name = "CantTiempo";
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "MoneyCurrency";
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "MoneyQuantity";
            dataGridViewCellStyle1.Format = "N2";
            this.Costo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // Participantes
            // 
            this.Participantes.DataPropertyName = "ParticipantsReport";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Participantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Participantes.HeaderText = "Participantes";
            this.Participantes.Name = "Participantes";
            this.Participantes.ReadOnly = true;
            this.Participantes.Width = 110;
            // 
            // frmManageResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 359);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.gbDataProject);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageResources";
            this.Text = "Formulario de Gestión de Recursos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbDataProject.ResumeLayout(false);
            this.gbDataProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAssign;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.GroupBox gbDataProject;
        private System.Windows.Forms.TextBox txtDescriptionActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPhaseProject;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participantes;
    }
}