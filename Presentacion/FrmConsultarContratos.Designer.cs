namespace Presentacion
{
    partial class FrmConsultarContratos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCantidadContratados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.ListFiltrados = new System.Windows.Forms.ListView();
            this.TipoContrato = new System.Windows.Forms.ColumnHeader();
            this.NumeroIdentificacion = new System.Windows.Forms.ColumnHeader();
            this.NombreContratista = new System.Windows.Forms.ColumnHeader();
            this.Fecha = new System.Windows.Forms.ColumnHeader();
            this.Costo = new System.Windows.Forms.ColumnHeader();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.CmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.PanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelPrincipal.Controls.Add(this.TxtValorTotal);
            this.PanelPrincipal.Controls.Add(this.label4);
            this.PanelPrincipal.Controls.Add(this.TxtCantidadContratados);
            this.PanelPrincipal.Controls.Add(this.label3);
            this.PanelPrincipal.Controls.Add(this.BtnGuardar);
            this.PanelPrincipal.Controls.Add(this.ListFiltrados);
            this.PanelPrincipal.Controls.Add(this.BtnConsultar);
            this.PanelPrincipal.Controls.Add(this.label2);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Controls.Add(this.DateTimeFecha);
            this.PanelPrincipal.Controls.Add(this.CmbTipoContrato);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1082, 553);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Enabled = false;
            this.TxtValorTotal.Location = new System.Drawing.Point(601, 503);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(180, 27);
            this.TxtValorTotal.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor total contratado:";
            // 
            // TxtCantidadContratados
            // 
            this.TxtCantidadContratados.Enabled = false;
            this.TxtCantidadContratados.Location = new System.Drawing.Point(206, 503);
            this.TxtCantidadContratados.Name = "TxtCantidadContratados";
            this.TxtCantidadContratados.Size = new System.Drawing.Size(194, 27);
            this.TxtCantidadContratados.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad de contratos:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(526, 129);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(127, 29);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "GuardarArchivo";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // ListFiltrados
            // 
            this.ListFiltrados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TipoContrato,
            this.NumeroIdentificacion,
            this.NombreContratista,
            this.Fecha,
            this.Costo});
            this.ListFiltrados.HideSelection = false;
            this.ListFiltrados.Location = new System.Drawing.Point(41, 164);
            this.ListFiltrados.Name = "ListFiltrados";
            this.ListFiltrados.Size = new System.Drawing.Size(1010, 318);
            this.ListFiltrados.TabIndex = 6;
            this.ListFiltrados.UseCompatibleStateImageBehavior = false;
            this.ListFiltrados.View = System.Windows.Forms.View.Details;
            // 
            // TipoContrato
            // 
            this.TipoContrato.Text = "Tipo de contrato";
            this.TipoContrato.Width = 200;
            // 
            // NumeroIdentificacion
            // 
            this.NumeroIdentificacion.Text = "Numero de identificacion";
            this.NumeroIdentificacion.Width = 200;
            // 
            // NombreContratista
            // 
            this.NombreContratista.Text = "Nombre de contratista";
            this.NombreContratista.Width = 200;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            this.Fecha.Width = 200;
            // 
            // Costo
            // 
            this.Costo.Text = "Costo";
            this.Costo.Width = 200;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(426, 129);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(94, 29);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de contrato:";
            // 
            // DateTimeFecha
            // 
            this.DateTimeFecha.Location = new System.Drawing.Point(347, 96);
            this.DateTimeFecha.Name = "DateTimeFecha";
            this.DateTimeFecha.Size = new System.Drawing.Size(383, 27);
            this.DateTimeFecha.TabIndex = 2;
            // 
            // CmbTipoContrato
            // 
            this.CmbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoContrato.FormattingEnabled = true;
            this.CmbTipoContrato.Items.AddRange(new object[] {
            "Prestación de servicio",
            "Licitación Pública",
            "Subasta Inversa"});
            this.CmbTipoContrato.Location = new System.Drawing.Point(347, 50);
            this.CmbTipoContrato.Name = "CmbTipoContrato";
            this.CmbTipoContrato.Size = new System.Drawing.Size(383, 28);
            this.CmbTipoContrato.TabIndex = 0;
            // 
            // FrmConsultarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmConsultarContratos";
            this.Text = "FrmConsultarContratos";
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.ComboBox CmbTipoContrato;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimeFecha;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCantidadContratados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListFiltrados;
        private System.Windows.Forms.ColumnHeader TipoContrato;
        private System.Windows.Forms.ColumnHeader NumeroIdentificacion;
        private System.Windows.Forms.ColumnHeader NombreContratista;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Costo;
    }
}