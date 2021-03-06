﻿using System;
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
    public partial class FrmVisualizarContratos : Form
    {
        public FrmVisualizarContratos()
        {
            InitializeComponent();
        }
        private void MostrarDatos()
        {
            ContratoServices contratoServices = new ContratoServices();
            if (ListaVacia()==false)
            {
                MessageBox.Show("Carga completada", "");
                foreach (var Contrato in contratoServices.ConsultarTodos().contratos)
                {
                    string[] row = { Contrato.tipoContrato,Contrato.numeroIdentificacion,
                                    Contrato.nombreContratista,Contrato.fechaSuscripcion.ToString(),
                                    Contrato.valorContrato.ToString()};
                    ListViewItem lista = new ListViewItem(row);
                    ListTodos.Items.Add(lista);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos en la lista","Error!");
            }
            
        }
        private bool ListaVacia()
        {
            ContratoServices contratoServices = new ContratoServices();
            return contratoServices.ConsultarTodos().listaVacia;
        }
        private void BtnConsultarTodos_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
