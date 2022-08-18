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
    public partial class SlaForm : Form
    {

        SlaRepository _repository = new SlaRepository();
        Sla actualSla;
        public SlaForm()
        {
            InitializeComponent();
        }

        private void SlaForm_Load(object sender, EventArgs e)
        {
            fullDTGV();
        }

        private void fullDTGV()
        {
            dtgvSla.DataSource = _repository.getAll();
        }

        private void btnCrearSla_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescripcionSla.Text) &&
                String.IsNullOrWhiteSpace(txtCantidadHorasSla.Text))
            {
                MessageBox.Show("Debe llenar el campo de Descriccion y " +
                    "Cantidad de Horas");
            }
            else
            {
                Sla sla = new Sla()
                {

                    Id = 0,
                    Descripcion = txtDescripcionSla.Text,
                    CantidadHoras = Int32.Parse(txtCantidadHorasSla.Text),
                    Estatus = "A",
                    Borrado = 0,
                    FechaRegistro = DateTimeOffset.Now,
                    Creadopor = 0,
                    Modificadopor = 0
                };
                _repository.Create(sla);

                MessageBox.Show("El Sla ha sido registrado exitosamente.");
                fullDTGV();
            }
        }

        private void btnBuscarSla_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIdSla.Text))
            {
                fullDTGV();
            }
            else
            {
                actualSla = _repository.getById(Int32.Parse(txtIdSla.Text));

                if (actualSla == null)
                {
                    MessageBox.Show("Este Sla no existe");
                }
                else
                {
                    txtDescripcionSla.Text = actualSla.Descripcion;
                    txtCantidadHorasSla.Text = actualSla.CantidadHoras.ToString();
                }

            }
        }

        private void btnActualizarSla_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescripcionSla.Text) &&
                String.IsNullOrWhiteSpace(txtCantidadHorasSla.Text))
            {
                MessageBox.Show("Debe llenar el campo de Descriccion y " +
                    "Cantidad de Horas");
            }
            else
            {
                actualSla.Descripcion = txtDescripcionSla.Text;
                actualSla.CantidadHoras = Int32.Parse(txtCantidadHorasSla.Text);
                OperationResult result = _repository.Update(actualSla);
                if (!result.Succes)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("El Sla ha sido actualizado exitosamente.");
                    fullDTGV();
                }
            }
        }

        private void btnBorrarSla_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescripcionSla.Text) &&
                String.IsNullOrWhiteSpace(txtCantidadHorasSla.Text))
            {
                MessageBox.Show("Debe llenar el campo de Descriccion y " +
                    "Cantidad de Horas");
            }
            else
            {

                actualSla = _repository.getById(Int32.Parse(txtIdSla.Text));

                OperationResult result = _repository.Delete(actualSla);
                if (!result.Succes)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("El Sla ha sido ekiminado exitosamente.");
                    fullDTGV();
                }
            }
        }
    }
}
