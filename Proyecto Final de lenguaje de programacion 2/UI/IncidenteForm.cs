using Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities;
using Proyecto_Final_de_lenguaje_de_programacion_2.Interfaces;
using Proyecto_Final_de_lenguaje_de_programacion_2.Repositories;
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
    public partial class IncidenteForm : Form
    {
        IncidenteRepository _repository = new IncidenteRepository();
        Incidente actualPriori;

        UsuarioidRepository _repositoryUsuario = new UsuarioidRepository();
        Usuarioid actualSla;
        public IncidenteForm()
        {
            InitializeComponent();
        }

        private void IncidenteForm_Load(object sender, EventArgs e)
        {
            fullDTGV();
        }
        private void fullDTGV()
        {
            dtgvIncidente.DataSource = _repository.getAll();
        }

        private void btnCrearIncidente_Click(object sender, EventArgs e)
        {
            
        }
    }
}
