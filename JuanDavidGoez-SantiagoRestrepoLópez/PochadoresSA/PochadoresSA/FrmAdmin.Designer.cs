namespace PochadoresSA
{
    partial class FrmAdmin
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
            this.btnRCliente = new System.Windows.Forms.Button();
            this.btnRCuenta = new System.Windows.Forms.Button();
            this.btnRVincular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRCliente
            // 
            this.btnRCliente.Location = new System.Drawing.Point(92, 56);
            this.btnRCliente.Name = "btnRCliente";
            this.btnRCliente.Size = new System.Drawing.Size(96, 33);
            this.btnRCliente.TabIndex = 0;
            this.btnRCliente.Text = "Registrar Cliente";
            this.btnRCliente.UseVisualStyleBackColor = true;
            this.btnRCliente.Click += new System.EventHandler(this.btnRCliente_Click);
            // 
            // btnRCuenta
            // 
            this.btnRCuenta.Location = new System.Drawing.Point(92, 95);
            this.btnRCuenta.Name = "btnRCuenta";
            this.btnRCuenta.Size = new System.Drawing.Size(96, 33);
            this.btnRCuenta.TabIndex = 1;
            this.btnRCuenta.Text = "Registrar Cuenta";
            this.btnRCuenta.UseVisualStyleBackColor = true;
            this.btnRCuenta.Click += new System.EventHandler(this.btnRCuenta_Click);
            // 
            // btnRVincular
            // 
            this.btnRVincular.Location = new System.Drawing.Point(92, 134);
            this.btnRVincular.Name = "btnRVincular";
            this.btnRVincular.Size = new System.Drawing.Size(96, 33);
            this.btnRVincular.TabIndex = 2;
            this.btnRVincular.Text = "Vincular";
            this.btnRVincular.UseVisualStyleBackColor = true;
            this.btnRVincular.Click += new System.EventHandler(this.btnRVincular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(183, 208);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 29);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRVincular);
            this.Controls.Add(this.btnRCuenta);
            this.Controls.Add(this.btnRCliente);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRCliente;
        private System.Windows.Forms.Button btnRCuenta;
        private System.Windows.Forms.Button btnRVincular;
        private System.Windows.Forms.Button btnSalir;
    }
}