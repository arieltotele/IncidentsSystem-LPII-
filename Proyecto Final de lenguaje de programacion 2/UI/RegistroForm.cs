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
    public partial class RegistroForm : Form
    {

        UsuarioidRepository _repository = new UsuarioidRepository();
        Usuarioid actualDepart;

        PuestoRepository _repositoryPuesto = new PuestoRepository();
        Puesto actualPuesto;
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {
            fullDTGV();
        }

        private void fullDTGV()
        {
            dtgvUsuario.DataSource = _repository.getAll();
        }

        private void btnCrearPrioridad_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPuestoId.Text) ||
                String.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                String.IsNullOrWhiteSpace(txtApellidoUsuario.Text) ||
                String.IsNullOrWhiteSpace(txtCedulaUsuario.Text) ||
                String.IsNullOrWhiteSpace(txtCorreoUsuario.Text)||
                String.IsNullOrWhiteSpace(txtTelefonoUsuario.Text) ||
                String.IsNullOrWhiteSpace(pickerFechaNacimiento.Text) ||
                String.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                String.IsNullOrWhiteSpace(txtPasswordUser.Text))
            {
                MessageBox.Show("Debe llenar todos los campos (Salvo Usuario ID).");
            }
            else
            {
                actualPuesto = _repositoryPuesto.getById(Int32.Parse(txtPuestoId.Text));

                if (actualPuesto == null)
                {
                    MessageBox.Show("El Puesto asignado no existe.");
                }
                else
                {

                    Usuarioid usuario = new Usuarioid()
                    {

                        Id = 0,
                        puestoId = actualPuesto.Id,
                        Nombre = txtNombreUsuario.Text,
                        Apellido = txtApellidoUsuario.Text,
                        Cedula = txtCedulaUsuario.Text,
                        Correo = txtCorreoUsuario.Text,
                        Telefono = txtTelefonoUsuario.Text,
                        FechaNacimineto = DateTime.Parse(pickerFechaNacimiento.Text),
                        nombreusuario = txtNombreUsuario.Text,
                        contraseña = txtPasswordUser.Text,
                        Estatus = "A",
                        Borrado = 0,
                        FechaRegistro = DateTimeOffset.Now,
                        Creadopor = 0,
                        Modificadopor = 0
                    };
                    _repository.Create(usuario);

                    MessageBox.Show("La prioridad ha sido registrado exitosamente.");
                    fullDTGV();
                }
            }
        }
    }
}
