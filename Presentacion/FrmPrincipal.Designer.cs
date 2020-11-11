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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Consultar Contratos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "Visualizar Contratos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelIzquierdo.Controls.Add(this.button2);
            this.PanelIzquierdo.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.Panel PanelPrincipal;
    }
}

