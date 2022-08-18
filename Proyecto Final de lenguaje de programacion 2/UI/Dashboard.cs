using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuestoForm pantallaUPuesto = new PuestoForm();
            pantallaUPuesto.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm pantallaUsuario = new RegistroForm();
            pantallaUsuario.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartamentoForm pantallaDepartamento = new DepartamentoForm();
            pantallaDepartamento.ShowDialog();
        }

        private void slaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlaForm pantallaSla = new SlaForm();
            pantallaSla.ShowDialog();
        }

        private void prioridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrioridadForm pantallaPrioridad = new PrioridadForm();
            pantallaPrioridad.ShowDialog();
        }

        private void incidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncidenteForm pantallaIncidente = new IncidenteForm();
            pantallaIncidente.ShowDialog();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_de_IncidentesForm pantallaHistorial = new Historial_de_IncidentesForm();
            pantallaHistorial.ShowDialog();
        }
    }
}
