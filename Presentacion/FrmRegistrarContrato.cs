using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Presentacion
{
    public partial class FrmRegistrarContrato : Form
    {
        static Contrato contrato;
        public FrmRegistrarContrato()
        {
            InitializeComponent();
        }
        private void GuardarContrato(Contrato contrato)
        {
            ContratoServices contratoServices = new ContratoServices();
            contratoServices.Guardar(contrato);
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            contrato = new Contrato();
            contrato.tipoContrato = CmbTipoContrato.SelectedItem.ToString();
            contrato.numeroIdentificacion = TxtNumeroIdentificacion.Text;
            contrato.nombreContratista = TxtNombreContratista.Text;
            contrato.fechaSuscripcion = DateTimePickerFechaContrato.Value.Date;
            contrato.valorContrato = Convert.ToDouble(TxtValorContrato.Text);
            GuardarContrato(contrato);
        }
    }
}
