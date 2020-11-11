namespace Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRegistrarContrato = new System.Windows.Forms.Button();
            this.BtnConsultarContratos = new System.Windows.Forms.Button();
            this.BtnVisualizar = new System.Windows.Forms.Button();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegistrarContrato
            // 
            this.BtnRegistrarContrato.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegistrarContrato.Location = new System.Drawing.Point(0, 0);
            this.BtnRegistrarContrato.Name = "BtnRegistrarContrato";
            this.BtnRegistrarContrato.Size = new System.Drawing.Size(208, 29);
            this.BtnRegistrarContrato.TabIndex = 0;
            this.BtnRegistrarContrato.Text = "Registrar Contrato";
            this.BtnRegistrarContrato.UseVisualStyleBackColor = true;
            this.BtnRegistrarContrato.Click += new System.EventHandler(this.BtnRegistrarContrato_Click);
            // 
            // BtnConsultarContratos
            // 
            this.BtnConsultarContratos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultarContratos.Location = new System.Drawing.Point(0, 58);
            this.BtnConsultarContratos.Name = "BtnConsultarContratos";
            this.BtnConsultarContratos.Size = new System.Drawing.Size(208, 29);
            this.BtnConsultarContratos.TabIndex = 0;
            this.BtnConsultarContratos.Text = "Consultar Contratos";
            this.BtnConsultarContratos.UseVisualStyleBackColor = true;
            this.BtnConsultarContratos.Click += new System.EventHandler(this.BtnConsultarContratos_Click);
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVisualizar.Location = new System.Drawing.Point(0, 29);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(208, 29);
            this.BtnVisualizar.TabIndex = 0;
            this.BtnVisualizar.Text = "Visualizar Contratos";
            this.BtnVisualizar.UseVisualStyleBackColor = true;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelIzquierdo.Controls.Add(this.BtnConsultarContratos);
            this.PanelIzquierdo.Controls.Add(this.BtnVisualizar);
            this.PanelIzquierdo.Controls.Add(this.BtnRegistrarContrato);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(208, 653);
            this.PanelIzquierdo.TabIndex = 1;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.LightBlue;
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(208, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(974, 653);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelIzquierdo);
            this.Name = "FrmPrincipal";
            this.Text = "Menu";
            this.PanelIzquierdo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrarContrato;
        private System.Windows.Forms.Button BtnConsultarContratos;
        private System.Windows.Forms.Button BtnVisualizar;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.Panel PanelPrincipal;
    }
}

