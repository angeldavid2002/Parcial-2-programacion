using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logica;
using Entidades;
namespace Presentacion
{
    public partial class FrmConsultarContratos : Form
    {
        public FrmConsultarContratos()
        {
            InitializeComponent();
        }
        private void MostrarDatosFiltrados(string tipoContrato, DateTime fecha)
        {
            ContratoServices contratoServices = new ContratoServices();
            if (ListaVacia(tipoContrato,fecha) == false)
            {
                MessageBox.Show("Carga completada", "");
                foreach (var Contrato in contratoServices.ConsultarFiltrado(tipoContrato,fecha).contratos)
                {
                    string[] row = { Contrato.tipoContrato,Contrato.numeroIdentificacion,
                                    Contrato.nombreContratista,Contrato.fechaSuscripcion.ToString(),
                                    Contrato.valorContrato.ToString()};
                    ListViewItem lista = new ListViewItem(row);
                    ListFiltrados.Items.Add(lista);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos en la lista", "Error!");
            }

        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            MostrarDatosFiltrados(CmbTipoContrato.Text,DateTimeFecha.Value.Date);
        }
        private bool ListaVacia(string tipoContrato, DateTime fecha)
        {
            ContratoServices contratoServices = new ContratoServices();
            return contratoServices.ConsultarFiltrado(tipoContrato,fecha).listaVacia;
        }
    }
}
