using BLL;
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
    public partial class TiposEmailsRegistroForm : Form
    {
        public TiposEmailsRegistroForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            tipoIdTextBox.Clear();
            descripcionTextBox.Clear();
            CamposVacioserrorProvider.Clear();

            descripcionTextBox.Focus();
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                CamposVacioserrorProvider.SetError(descripcionTextBox, "El campo esta vacio.");
                return false;
            }

            return true;
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            TiposEmails tipo = new TiposEmails();

            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacio.");
            }
            else
            {
                tipo.Descripcion = descripcionTextBox.Text;

                if (TiposEmailBLL.Guardar(tipo))
                    MessageBox.Show("El tipo email se guardo con exito.");
                else
                    MessageBox.Show("El tipo email no se pudo guardar.");
            }

            Limpiar();
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tipoIdTextBox.Text))
            {
                MessageBox.Show("El id a evaluar esta vacio.");
            }
            else
            {
                int id = Utilidades.TOINT(tipoIdTextBox.Text);
                var tipo = TiposEmailBLL.Buscar(p => p.TipoId == id);

                if (tipo != null)
                {
                    descripcionTextBox.Text = tipo.Descripcion;
                }
                else
                {
                    MessageBox.Show("No existe ningun tipo con ese id.");
                    Limpiar();
                }
            }
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (!Validar() || string.IsNullOrEmpty(tipoIdTextBox.Text))
            {
                MessageBox.Show("Hay campos vacios.");
            }
            else
            {
                int id = Utilidades.TOINT(tipoIdTextBox.Text);

                if (BLL.TiposEmailBLL.Eliminar(BLL.TiposEmailBLL.Buscar(p => p.TipoId == id)))
                {
                    Limpiar();
                    MessageBox.Show("Tipo de email eliminado con exito.");
                }
                else
                    MessageBox.Show("No se pudo eliminar tipo de email.");
            }
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TiposEmailsRegistroForm_Load(object sender, EventArgs e)
        {

        }
    }
}
