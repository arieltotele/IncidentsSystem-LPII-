using Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities;
using Proyecto_Final_de_lenguaje_de_programacion_2.Interfaces;
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
            if (String.IsNullOrWhiteSpace(txtNombrePuesto.Text) ||
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
                        Id = 0,
                        Nombre = txtNombrePuesto.Text,
                        Estatus = "A",
                        Borrado = 0,
                        FechaRegistro = DateTimeOffset.Now,
                        Creadopor = 0,
                        Modificadopor = 0,
                        Departamentoid = actualDepart.Id
                    };
                    _repository.Create(puesto);

                    MessageBox.Show("El puesto ha sido registrado exitosamente.");
                    fullDTGV();
                }
            }
        }

        private void btnBuscarPuesto_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPuestoId.Text))
            {
                fullDTGV();
            }
            else
            {
                actualPuesto = _repository.getById(Int32.Parse(txtPuestoId.Text));

                if (actualPuesto == null)
                {
                    MessageBox.Show("Este puesto no existe");
                }
                else
                {
                    txtNombrePuesto.Text = actualPuesto.Nombre;
                    txtDepartamentoIdpt.Text = actualPuesto.Departamentoid.ToString();

                }

            }
        }

        private void btnActualizarPuesto_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombrePuesto.Text) ||
                String.IsNullOrWhiteSpace(txtDepartamentoIdpt.Text))
            {
                MessageBox.Show("Debe llenar el campo de Nombre y ID");
            }
            else
            {
                actualPuesto.Nombre = txtNombrePuesto.Text;
                actualPuesto.Departamentoid = Int32.Parse(txtPuestoId.Text);
                OperationResult result = _repository.Update(actualPuesto);
                if (!result.Succes)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("El puesto ha sido actualizado exitosamente.");
                    fullDTGV();
                }
            }
        }

        private void btnBorrarPuesto_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPuestoId.Text))
            {
                MessageBox.Show("Debe de completar el campo ID.");
            }
            else
            {

                actualPuesto = _repository.getById(Int32.Parse(txtPuestoId.Text));

                OperationResult result = _repository.Delete(actualPuesto);
                if (!result.Succes)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("El puesto ha sido eliminado exitosamente.");
                    fullDTGV();
                }
            }
        }
    }
}
