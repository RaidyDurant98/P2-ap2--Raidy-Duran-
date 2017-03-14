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
    public partial class TiposEmailConsultaForm : Form
    {
        public TiposEmailConsultaForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            FiltrartextBox.Clear();
            FiltrarcomboBox.Text = null;
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
                CamposVacioserrorProvider.SetError(FiltrarcomboBox, "por favor seleccionar una opcion.");
                interruptor = false;
            }

            return interruptor;
        }

        private void Filtrarbutton_Click(object sender, EventArgs e)
        {
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                FiltrardataGridView.DataSource = BLL.TiposEmailBLL.GetListAll();
            }
            else
            {
                if (!Validar())
                {
                    MessageBox.Show("por favor Seleccionar/Llenar el campo vacio.");
                    Limpiar();
                }
                else
                {
                    if (FiltrarcomboBox.SelectedIndex == 0)
                    {
                        FiltrardataGridView.DataSource = BLL.TiposEmailBLL.GetList(p => p.Descripcion == FiltrartextBox.Text);
                    }
                }
            }
        }

        private void TiposEmailConsultaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
