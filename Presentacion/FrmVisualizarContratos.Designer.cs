namespace Presentacion
{
    partial class FrmVisualizarContratos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnConsultarTodos = new System.Windows.Forms.Button();
            this.ListTodos = new System.Windows.Forms.ListView();
            this.TipoContrato = new System.Windows.Forms.ColumnHeader();
            this.NumeroId = new System.Windows.Forms.ColumnHeader();
            this.NombreContratista = new System.Windows.Forms.ColumnHeader();
            this.FechaSuscripcion = new System.Windows.Forms.ColumnHeader();
            this.ValorContrato = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor del contrato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de suscripción:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnConsultarTodos);
            this.panel1.Controls.Add(this.ListTodos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 553);
            this.panel1.TabIndex = 0;
            // 
            // BtnConsultarTodos
            // 
            this.BtnConsultarTodos.Location = new System.Drawing.Point(488, 488);
            this.BtnConsultarTodos.Name = "BtnConsultarTodos";
            this.BtnConsultarTodos.Size = new System.Drawing.Size(153, 30);
            this.BtnConsultarTodos.TabIndex = 1;
            this.BtnConsultarTodos.Text = "Consultar Todos";
            this.BtnConsultarTodos.UseVisualStyleBackColor = true;
            this.BtnConsultarTodos.Click += new System.EventHandler(this.BtnConsultarTodos_Click);
            // 
            // ListTodos
            // 
            this.ListTodos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TipoContrato,
            this.NumeroId,
            this.NombreContratista,
            this.FechaSuscripcion,
            this.ValorContrato});
            this.ListTodos.HideSelection = false;
            this.ListTodos.Location = new System.Drawing.Point(36, 52);
            this.ListTodos.Name = "ListTodos";
            this.ListTodos.Size = new System.Drawing.Size(1018, 430);
            this.ListTodos.TabIndex = 0;
            this.ListTodos.UseCompatibleStateImageBehavior = false;
            this.ListTodos.View = System.Windows.Forms.View.Details;
            // 
            // TipoContrato
            // 
            this.TipoContrato.Text = "Tipo de contrato";
            this.TipoContrato.Width = 200;
            // 
            // NumeroId
            // 
            this.NumeroId.Text = "Numero de identificacion";
            this.NumeroId.Width = 200;
            // 
            // NombreContratista
            // 
            this.NombreContratista.Text = "Nombre del contratista";
            this.NombreContratista.Width = 200;
            // 
            // FechaSuscripcion
            // 
            this.FechaSuscripcion.Text = "Fecha de suscripcion";
            this.FechaSuscripcion.Width = 200;
            // 
            // ValorContrato
            // 
            this.ValorContrato.Text = "Valor del contrato";
            this.ValorContrato.Width = 200;
            // 
            // FrmVisualizarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmVisualizarContratos";
            this.Text = "FrmVisualizarContratos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnConsultarTodos;
        private System.Windows.Forms.ListView ListTodos;
        private System.Windows.Forms.ColumnHeader TipoContrato;
        private System.Windows.Forms.ColumnHeader NumeroId;
        private System.Windows.Forms.ColumnHeader NombreContratista;
        private System.Windows.Forms.ColumnHeader FechaSuscripcion;
        private System.Windows.Forms.ColumnHeader ValorContrato;
    }
}