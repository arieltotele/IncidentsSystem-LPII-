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
    public partial class Historial_de_IncidentesForm : Form
    {

        HistorialncidenteRepository _repository = new HistorialncidenteRepository();
        Historial_Incidente actualHistorial;

        IncidenteRepository _repositoryIncidente = new IncidenteRepository();
        Incidente actualIncidente;

        public Historial_de_IncidentesForm()
        {
            InitializeComponent();
        }

        private void Historial_de_IncidentesForm_Load(object sender, EventArgs e)
        {
            fullDTGV();
        }

        private void fullDTGV()
        {
             dtgvHistorial.DataSource = _repository.getAll();
        }

        private void btnCrearHistorial_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIncidenteIdHistorial.Text) &&
                String.IsNullOrWhiteSpace(txtComentarioHistorial.Text))
            {
                MessageBox.Show("Debe llenar el campo de Nombre");
            }
            else
            {
                actualIncidente = _repositoryIncidente.getById(Int32.Parse(txtIncidenteIdHistorial.Text));

                if (actualIncidente == null)
                {
                    MessageBox.Show("El Incidente asignado no existe.");
                }
                else
                {

                    Historial_Incidente historial = new Historial_Incidente()
                    {

                        Id = 0,
                        Comentario = txtComentarioHistorial.Text,
                        IncidenteId = actualIncidente.Id,
                        Estatus = "A",
                        Borrado = 0,
                        FechaRegistro = DateTimeOffset.Now,
                        Creadopor = 0,
                        Modificadopor = 0
                    };
                    _repository.Create(historial);

                    MessageBox.Show("El historial ha sido registrado exitosamente.");
                    fullDTGV();
                }
            }
        }

        private void btnBuscarHistorial_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIdHistorial.Text))
            {
                fullDTGV();
            }
            else
            {
                actualHistorial = _repository.getById(Int32.Parse(txtIdHistorial.Text));

                if (actualHistorial == null)
                {
                    MessageBox.Show("Este historial no existe");
                }
                else
                {
                    txtIncidenteIdHistorial.Text = actualHistorial.IncidenteId.ToString();
                    txtComentarioHistorial.Text = actualHistorial.Comentario;

                }

            }
        }

        private void btnActualizarHistorial_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIncidenteIdHistorial.Text) ||
                String.IsNullOrWhiteSpace(txtComentarioHistorial.Text))
            {
                MessageBox.Show("Debe llenar los campo de Incidente Id y Comentario");
            }
            else
            {
                actualHistorial.Comentario = txtComentarioHistorial.Text;
                actualHistorial.IncidenteId = Int32.Parse(txtIncidenteIdHistorial.Text);
                OperationResult result = _repository.Update(actualHistorial);
                if (!result.Succes)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("EL hisotiral ha sido actualizado exitosamente.");
                    fullDTGV();
                }
            }
        }
    }
}
