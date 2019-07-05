namespace GameSoftApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fasesDeUnProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesPorFaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarRecursosOTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosPorDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosPorDepartamentoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectosToolStripMenuItem,
            this.fasesDeUnProyectoToolStripMenuItem,
            this.actividadesPorFaseToolStripMenuItem,
            this.asignarRecursosOTareasToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // fasesDeUnProyectoToolStripMenuItem
            // 
            this.fasesDeUnProyectoToolStripMenuItem.Name = "fasesDeUnProyectoToolStripMenuItem";
            this.fasesDeUnProyectoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.fasesDeUnProyectoToolStripMenuItem.Text = "Fases de un proyecto";
            // 
            // actividadesPorFaseToolStripMenuItem
            // 
            this.actividadesPorFaseToolStripMenuItem.Name = "actividadesPorFaseToolStripMenuItem";
            this.actividadesPorFaseToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.actividadesPorFaseToolStripMenuItem.Text = "Actividades por fase";
            // 
            // asignarRecursosOTareasToolStripMenuItem
            // 
            this.asignarRecursosOTareasToolStripMenuItem.Name = "asignarRecursosOTareasToolStripMenuItem";
            this.asignarRecursosOTareasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.asignarRecursosOTareasToolStripMenuItem.Text = "Asignar recursos";
            this.asignarRecursosOTareasToolStripMenuItem.Click += new System.EventHandler(this.asignarRecursosOTareasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // empleadosPorDepartamentoToolStripMenuItem
            // 
            this.empleadosPorDepartamentoToolStripMenuItem.Name = "empleadosPorDepartamentoToolStripMenuItem";
            this.empleadosPorDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.empleadosPorDepartamentoToolStripMenuItem.Text = "Empleados por Departamento";
            this.empleadosPorDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosPorDepartamentoToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 617);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Sistema de Proyectos de Videojuegos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasesDeUnProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesPorFaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarRecursosOTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosPorDepartamentoToolStripMenuItem;
    }
}