namespace GameSoftApp
{
    partial class frmEmployees
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
            this.cmbDepartments = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_secondlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDepartments
            // 
            this.cmbDepartments.FormattingEnabled = true;
            this.cmbDepartments.Location = new System.Drawing.Point(226, 31);
            this.cmbDepartments.Name = "cmbDepartments";
            this.cmbDepartments.Size = new System.Drawing.Size(255, 21);
            this.cmbDepartments.TabIndex = 0;
            this.cmbDepartments.SelectedIndexChanged += new System.EventHandler(this.cmbDepartments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departamento";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_name,
            this.col_lastname,
            this.col_secondlastname});
            this.dgvEmployees.Location = new System.Drawing.Point(32, 98);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(449, 240);
            this.dgvEmployees.TabIndex = 2;
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.Frozen = true;
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 43;
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "name";
            this.col_name.Frozen = true;
            this.col_name.HeaderText = "NOMBRE";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Width = 79;
            // 
            // col_lastname
            // 
            this.col_lastname.DataPropertyName = "lastName";
            this.col_lastname.Frozen = true;
            this.col_lastname.HeaderText = "PRIMER APELLIDO";
            this.col_lastname.Name = "col_lastname";
            this.col_lastname.ReadOnly = true;
            this.col_lastname.Width = 118;
            // 
            // col_secondlastname
            // 
            this.col_secondlastname.DataPropertyName = "secondLastName";
            this.col_secondlastname.Frozen = true;
            this.col_secondlastname.HeaderText = "SEGUNDO APELLIDO";
            this.col_secondlastname.Name = "col_secondlastname";
            this.col_secondlastname.ReadOnly = true;
            this.col_secondlastname.Width = 129;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 350);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDepartments);
            this.Name = "frmEmployees";
            this.Text = "Empleados por Departamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_secondlastname;
    }
}