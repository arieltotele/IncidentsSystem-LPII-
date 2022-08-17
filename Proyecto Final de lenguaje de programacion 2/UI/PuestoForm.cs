using Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities;
using Proyecto_Final_de_lenguaje_de_programacion_2.Repositories;
using System;
using System.Windows.Forms;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.UI
{
    public partial class PuestoForm : Form
    {
        PuestoRepository _repository = new PuestoRepository();
        Puesto actualPuesto;

        DepartamentoRepository _departRepository = new DepartamentoRepository();
        Departamento actualDepart;
        public PuestoForm()
        {
            InitializeComponent();
        }

        private void PuestoForm_Load(object sender, EventArgs e)
        {
            fullDTGV();
        }

        private void fullDTGV()
        {
            dtgvPuesto.DataSource = _repository.getAll();
        }

        private void btnCrearPuesto_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombrePuesto.Text) &&
                String.IsNullOrWhiteSpace(txtDepartamentoIdpt.Text))
            {
                MessageBox.Show("Debe llenar el campo de Nombre y ID");
            }
            else
            {
                actualDepart = _departRepository.getById(Int32.Parse(txtDepartamentoIdpt.Text));

                if (actualDepart == null)
                {
                    MessageBox.Show("El departamento asignado no existe.");
                }

                else
                {

                    Puesto puesto = new Puesto()
                    {
                        
                        Nombre = txtNombrePuesto.Text,
                        Estatus = "A",
                        Borrado = 0,
                        FechaRegistro = DateTimeOffset.Now,
                        Creadopor = 0,
                        FechaModificacion = DateTimeOffset.Now,
                        Modificadopor = 0,
                        Departamentoid = Int32.Parse(txtDepartamentoIdpt.Text),
                        Id = 0
                    };
                    _repository.Create(puesto);

                    MessageBox.Show("El puesto ha sido registrado exitosamente.");
                    fullDTGV();
                }
            }
        }
    }
}
