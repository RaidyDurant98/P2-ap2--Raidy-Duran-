using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParcialTech.Registros
{
    public partial class EmpleadosRegistroForm : Form
    {
        public EmpleadosRegistroForm()
        {
            InitializeComponent();
        }

        private void EmpleadosRegistroForm_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            empleadoIdMaskedTextBox.Clear();
            nombresTextBox.Clear();
            fechaNacimientoDateTimePicker.Value = DateTime.Today;
            sueldoMaskedTextBox.Clear();
            CamposVacioserrorProvider.Clear();

            nombresTextBox.Focus();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(nombresTextBox.Text))
            {
                CamposVacioserrorProvider.SetError(nombresTextBox, "Llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(sueldoMaskedTextBox.Text))
            {
                CamposVacioserrorProvider.SetError(sueldoMaskedTextBox, "Llenar el campo vacio.");
                interruptor = false;
            }

            return interruptor;
        }

        private Entidades.Empleados LlenarCampos()
        {
            var empleado = new Entidades.Empleados();

            empleado.Nombres = nombresTextBox.Text;
            empleado.FechaNacimiento = fechaNacimientoDateTimePicker.Value;
            empleado.Sueldo = Utilidades.TOINT(sueldoMaskedTextBox.Text);

            return empleado;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios.");
            }
            else
            {
                var empleado = new Empleados();

                empleado = LlenarCampos();

                if (empleado != null)
                {
                    if (BLL.EmpleadosBLL.Guardar(empleado))
                        MessageBox.Show("El empleado se guardo.");
                    else
                        MessageBox.Show("El empleado no se pudo guardar.");

                }

                Limpiar();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(empleadoIdMaskedTextBox.Text))
            {
                MessageBox.Show("No ahi ningun Id para poder evaluar.");
            }
            else
            {
                int id = Utilidades.TOINT(empleadoIdMaskedTextBox.Text);
                var empleado = new Empleados();

                empleado = BLL.EmpleadosBLL.Buscar(p => p.EmpleadoId == id);

                if (empleado != null)
                {
                    nombresTextBox.Text = empleado.Nombres;
                    fechaNacimientoDateTimePicker.Value = empleado.FechaNacimiento;
                    sueldoMaskedTextBox.Text = empleado.Sueldo.ToString();
                }
                else
                {
                    MessageBox.Show("No existe ningun empleado con ese Id.");
                    Limpiar();
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar() || string.IsNullOrEmpty(empleadoIdMaskedTextBox.Text))
            {
                MessageBox.Show("No se puede eliminar porque hay campos vacios.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(empleadoIdMaskedTextBox.Text);

                if (BLL.EmpleadosBLL.Eliminar(BLL.EmpleadosBLL.Buscar(p => p.EmpleadoId == id)))
                {
                    Limpiar();
                    MessageBox.Show("El empleado se elimino con exito.");
                }
                else
                {
                    MessageBox.Show("El empleado no se pudo eliminar.");
                }
            }
        }
    }
}
