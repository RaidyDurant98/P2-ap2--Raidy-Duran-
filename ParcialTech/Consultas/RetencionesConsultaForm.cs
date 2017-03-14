using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParcialTech.Consultas
{
    public partial class RetencionesConsultaForm : Form
    {
        public RetencionesConsultaForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            FiltrarcomboBox.Text = null;
            FiltrartextBox.Clear();
        }

        public bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(FiltrartextBox.Text))
            {
                CamposVacioserrorProvider.SetError(FiltrartextBox, "por favor llenar el campo.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(FiltrarcomboBox.Text))
            {
                CamposVacioserrorProvider.SetError(FiltrartextBox, "por favor seleccionar un campo.");
                interruptor = false;
            }

            return interruptor;
        }

        private void RetencionesConsultaForm_Load(object sender, EventArgs e)
        {

        }

        private void Filtrarbutton_Click(object sender, EventArgs e)
        {
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                FiltrardataGridView.DataSource = BLL.RetencionesBLL.GetListAll();
            }
            else
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor Seleccionar/Llenar los campos vacios.");
                    Limpiar();
                }
                else
                {
                    if (FiltrarcomboBox.SelectedIndex == 0)
                    {
                        FiltrardataGridView.DataSource = BLL.RetencionesBLL.GetList(p => p.Descripcion == FiltrartextBox.Text);
                    }
                }
            }
        }
    }
}
