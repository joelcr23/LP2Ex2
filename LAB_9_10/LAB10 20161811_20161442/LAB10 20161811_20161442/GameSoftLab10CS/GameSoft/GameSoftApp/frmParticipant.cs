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
    public partial class frmParticipant : Form
    {
        public class Empleado
        {
            private String nombre;
            public Empleado(String nombre)
            {
                this.nombre = nombre;
            }
            public string Nombre { get => nombre; set => nombre = value; }
        }
        public frmParticipant()
        {
            InitializeComponent();
            Empleado e1 = new Empleado("Juan Zapata");
            Empleado e2 = new Empleado("Pedro Mendoza");
            BindingList<Empleado> emps = new BindingList<Empleado>();
            emps.Add(e1);
            emps.Add(e2);
            dgvParticipantes.DataSource = emps;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
