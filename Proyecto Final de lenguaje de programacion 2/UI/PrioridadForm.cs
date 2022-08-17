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
    public partial class PrioridadForm : Form
    {

        PrioridadRepository _repository = new PrioridadRepository();
        Prioridad actualPriori;

        SlaRepository _repositorySla = new SlaRepository();
        Sla actualSla;
        public PrioridadForm()
        {
            InitializeComponent();
        }

        private void PrioridadForm_Load(object sender, EventArgs e)
        {
            fullDTGV();
        }
        private void fullDTGV()
        {
            dtgvPrioridad.DataSource = _repository.getAll();
        }

        private void btnCrearPrioridad_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombrePrioridad.Text) &&
                String.IsNullOrWhiteSpace(txtSlaIdPrioridad.Text))
            {
                MessageBox.Show("Debe llenar el campo de Nombre");
            }
            else
            {
                actualSla = _repositorySla.getById(Int32.Parse(txtSlaIdPrioridad.Text));

                if (actualSla == null)
                {
                    MessageBox.Show("El Sla asignado no existe.");
                }
                else
                {

                    Prioridad prioridad = new Prioridad()
                    {

                        Id = 0,
                        Nombre = txtNombrePrioridad.Text,
                        Sla = actualSla,
                        SladId = actualSla.Id,
                        Estatus = "A",
                        Borrado = 0,
                        FechaRegistro = DateTimeOffset.Now,
                        Creadopor = 0,
                        Modificadopor = 0
                    };
                    _repository.Create(prioridad);

                    MessageBox.Show("La prioridad ha sido registrado exitosamente.");
                    fullDTGV();
                }
            }
        }

        private void btnBuscarPrioridad_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPrioridadID.Text))
            {
                fullDTGV();
            }
            else
            {
                actualPriori = _repository.getById(Int32.Parse(txtPrioridadID.Text));

                if (actualPriori == null)
                {
                    MessageBox.Show("Esta prioridad no existe");
                }
                else
                {
                    txtNombrePrioridad.Text = actualPriori.Nombre;
                    txtSlaIdPrioridad.Text = actualPriori.SladId.ToString();

                }

            }
        }

        private void btnActualizarPrioridad_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombrePrioridad.Text) ||
                String.IsNullOrWhiteSpace(txtSlaIdPrioridad.Text))
            {
                MessageBox.Show("Debe llenar los campo de Nombre y Sla Id");
            }
            else
            {
                actualPriori.Nombre = txtNombrePrioridad.Text;
                actualPriori.SladId = Int32.Parse(txtSlaIdPrioridad.Text);
                OperationResult result = _repository.Update(actualPriori);
                if (!result.Succes)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("La prioridad ha sido actualizado exitosamente.");
                    fullDTGV();
                }
            }
        }
    }
}
