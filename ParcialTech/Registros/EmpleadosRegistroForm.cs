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

        Entidades.Empleados Empleado;

        public EmpleadosRegistroForm()
        {
            InitializeComponent();
            Limpiar();
        }

        private void EmpleadosRegistroForm_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void Limpiar()
        {
            Empleado = new Empleados();

            empleadoIdMaskedTextBox.Clear();
            nombresTextBox.Clear();
            fechaNacimientoDateTimePicker.Value = DateTime.Today;
            sueldoMaskedTextBox.Clear();
            CamposVacioserrorProvider.Clear();
            DetalledataGridView.DataSource = null;
            retencionesComboBox.Text = null;

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
            if (string.IsNullOrEmpty(retencionesComboBox.Text))
            {
                CamposVacioserrorProvider.SetError(retencionesComboBox, "Llenar el campo vacio.");
                interruptor = false;
            }

            return interruptor;
        }

        private void LlenarCombo()
        {
            List<Entidades.Retenciones> lista = BLL.RetencionesBLL.GetListAll();

            retencionesComboBox.DataSource = lista;
            retencionesComboBox.DisplayMember = "Descripcion";
            retencionesComboBox.ValueMember = "RetencionId";
        }

        private Entidades.Empleados LlenarCampos()
        {
            //string retencion = retencionesComboBox.SelectedValue.ToString();

            Empleado.Nombres = nombresTextBox.Text;
            Empleado.FechaNacimiento = fechaNacimientoDateTimePicker.Value;
            Empleado.Sueldo = Utilidades.TOINT(sueldoMaskedTextBox.Text);
            Empleado.RetencionId = (int)retencionesComboBox.SelectedValue;

            return Empleado;
        }

        private void LlenarGrid(Entidades.Empleados empleado)
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = empleado.Retenciones;
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
                Limpiar();
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
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(empleadoIdMaskedTextBox.Text);
                var empleado = BLL.EmpleadosBLL.Buscar(p => p.EmpleadoId == id);

                Empleado = new Empleados();

                if (empleado != null)
                {
                    nombresTextBox.Text = empleado.Nombres;
                    fechaNacimientoDateTimePicker.Value = empleado.FechaNacimiento;
                    sueldoMaskedTextBox.Text = empleado.Sueldo.ToString();
                    retencionesComboBox.SelectedValue = empleado.RetencionId;

                    LlenarGrid(empleado);
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
            if (!Validar())
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

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Entidades.Retenciones retencion = new Retenciones();

            retencion = (Entidades.Retenciones)retencionesComboBox.SelectedItem;
            Empleado.Retenciones.Add(retencion);

            LlenarGrid(Empleado);
        }
    }
}
