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
    public partial class DepartamentoForm : Form
    {
        DepartamentoRepository _repository = new DepartamentoRepository();
        Departamento actualDepart;
        public DepartamentoForm()
        {
            InitializeComponent();
        }

        private void DepartamentoForm_Load(object sender, EventArgs e)
        {
            fullDTGV();
        }
        
        private bool haveFieldsForCreate()
        {
            return (string.IsNullOrWhiteSpace(txtNombredep.Text));
        }

        private void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            if (haveFieldsForCreate())
            {
                MessageBox.Show("Debe llenar el campo de Nombre");
            }
            else
            {
                Departamento departamento = new Departamento() {

                    Id = 0,
                    Nombre = txtNombredep.Text,
                    Estatus = "A",
                    Borrado = 0,
                    FechaRegistro = DateTimeOffset.Now,
                    Creadopor = 0,
                    Modificadopor = 0                    
                };
                _repository.Create(departamento);

                MessageBox.Show("El departamento ha sido registrado exitosamente.");
                fullDTGV();
            }
        }

        private void fullDTGV()
        {
            dtgvDepartamento.DataSource = _repository.getAll();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarDepartamento_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(id_departxt.Text)){
                fullDTGV();
            }
            else
            {
                actualDepart = _repository.getById(Int32.Parse(id_departxt.Text));

                if(actualDepart == null)
                {
                    MessageBox.Show("Este departamento no existe");
                }
                else
                {
                    txtNombredep.Text = actualDepart.Nombre;
                }
                
            }
        }

        private void btnActualizarDepartamento_Click(object sender, EventArgs e)
        {
            if(txtNombredep.Text == null)
            {
                MessageBox.Show("Debe de llenar el campo de Nombre");
            }
            else
            {
                actualDepart.Nombre = txtNombredep.Text;
                OperationResult result = _repository.Update(actualDepart);
                if (!result.Succes)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("El vehiculo ha sido actualizado exitosamente.");
                    fullDTGV();
                }
            }
        }

        private void btnBorrarDepartamento_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(id_departxt.Text))
            {
                MessageBox.Show("Debe de completar el campo ID.");
            }
            else{

                actualDepart = _repository.getById(Int32.Parse(id_departxt.Text));

                OperationResult result = _repository.Delete(actualDepart);
                if (!result.Succes)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("El departamento ha sido eliminado exitosamente.");
                    fullDTGV();
                }
            }
        }
    }
}
