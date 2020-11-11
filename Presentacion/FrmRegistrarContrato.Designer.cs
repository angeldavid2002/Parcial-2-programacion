namespace Presentacion
{
    partial class FrmRegistrarContrato
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
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.DateTimePickerFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.TxtValorContrato = new System.Windows.Forms.TextBox();
            this.TxtNombreContratista = new System.Windows.Forms.TextBox();
            this.TxtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.PanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelPrincipal.Controls.Add(this.BtnRegistrar);
            this.PanelPrincipal.Controls.Add(this.DateTimePickerFechaContrato);
            this.PanelPrincipal.Controls.Add(this.TxtValorContrato);
            this.PanelPrincipal.Controls.Add(this.TxtNombreContratista);
            this.PanelPrincipal.Controls.Add(this.TxtNumeroIdentificacion);
            this.PanelPrincipal.Controls.Add(this.label5);
            this.PanelPrincipal.Controls.Add(this.label4);
            this.PanelPrincipal.Controls.Add(this.label3);
            this.PanelPrincipal.Controls.Add(this.label2);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Controls.Add(this.CmbTipoContrato);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(782, 553);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(352, 387);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(94, 29);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // DateTimePickerFechaContrato
            // 
            this.DateTimePickerFechaContrato.Location = new System.Drawing.Point(244, 255);
            this.DateTimePickerFechaContrato.Name = "DateTimePickerFechaContrato";
            this.DateTimePickerFechaContrato.Size = new System.Drawing.Size(347, 27);
            this.DateTimePickerFechaContrato.TabIndex = 7;
            // 
            // TxtValorContrato
            // 
            this.TxtValorContrato.Location = new System.Drawing.Point(244, 303);
            this.TxtValorContrato.Name = "TxtValorContrato";
            this.TxtValorContrato.Size = new System.Drawing.Size(347, 27);
            this.TxtValorContrato.TabIndex = 6;
            // 
            // TxtNombreContratista
            // 
            this.TxtNombreContratista.Location = new System.Drawing.Point(244, 197);
            this.TxtNombreContratista.Name = "TxtNombreContratista";
            this.TxtNombreContratista.Size = new System.Drawing.Size(347, 27);
            this.TxtNombreContratista.TabIndex = 6;
            // 
            // TxtNumeroIdentificacion
            // 
            this.TxtNumeroIdentificacion.Location = new System.Drawing.Point(244, 143);
            this.TxtNumeroIdentificacion.Name = "TxtNumeroIdentificacion";
            this.TxtNumeroIdentificacion.Size = new System.Drawing.Size(347, 27);
            this.TxtNumeroIdentificacion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor del contrato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de suscripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del contratista: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de identificacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de contrato:";
            // 
            // CmbTipoContrato
            // 
            this.CmbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoContrato.FormattingEnabled = true;
            this.CmbTipoContrato.Items.AddRange(new object[] {
            "Prestación de servicio",
            "Licitación Pública",
            "Subasta Inversa"});
            this.CmbTipoContrato.Location = new System.Drawing.Point(244, 83);
            this.CmbTipoContrato.Name = "CmbTipoContrato";
            this.CmbTipoContrato.Size = new System.Drawing.Size(347, 28);
            this.CmbTipoContrato.TabIndex = 0;
            // 
            // FrmRegistrarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRegistrarContrato";
            this.Text = "FrmRegistrarContrato";
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.DateTimePicker DateTimePickerFechaContrato;
        private System.Windows.Forms.TextBox TxtValorContrato;
        private System.Windows.Forms.TextBox TxtNombreContratista;
        private System.Windows.Forms.TextBox TxtNumeroIdentificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTipoContrato;
    }
}