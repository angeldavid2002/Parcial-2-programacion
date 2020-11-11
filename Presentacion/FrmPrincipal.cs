using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void LimpiarPanel()
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }
        }
        private void AbrirForm(Form form)
        {
            form.TopLevel = false;
            this.PanelPrincipal.Controls.Add(form);
            form.Show();
        }
        private void BtnRegistrarContrato_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmRegistrarContrato form = new FrmRegistrarContrato();
            AbrirForm(form);
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmVisualizarContratos form = new FrmVisualizarContratos();
            AbrirForm(form);
        }

        private void BtnConsultarContratos_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            FrmConsultarContratos form = new FrmConsultarContratos();
            AbrirForm(form);
        }
    }
}
