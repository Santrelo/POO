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
            this.btnRCliente.BackColor = System.Drawing.Color.Red;
            this.btnRCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRCliente.ForeColor = System.Drawing.Color.Black;
            this.btnRCliente.Location = new System.Drawing.Point(171, 180);
            this.btnRCliente.Name = "btnRCliente";
            this.btnRCliente.Size = new System.Drawing.Size(99, 48);
            this.btnRCliente.TabIndex = 0;
            this.btnRCliente.Text = "Registrar Cliente";
            this.btnRCliente.UseVisualStyleBackColor = false;
            this.btnRCliente.Click += new System.EventHandler(this.btnRCliente_Click);
            // 
            // btnRCuenta
            // 
            this.btnRCuenta.BackColor = System.Drawing.Color.Red;
            this.btnRCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRCuenta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRCuenta.Location = new System.Drawing.Point(276, 180);
            this.btnRCuenta.Name = "btnRCuenta";
            this.btnRCuenta.Size = new System.Drawing.Size(104, 48);
            this.btnRCuenta.TabIndex = 1;
            this.btnRCuenta.Text = "Registrar Cuenta";
            this.btnRCuenta.UseVisualStyleBackColor = false;
            this.btnRCuenta.Click += new System.EventHandler(this.btnRCuenta_Click);
            // 
            // btnRVincular
            // 
            this.btnRVincular.BackColor = System.Drawing.Color.Red;
            this.btnRVincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRVincular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRVincular.Location = new System.Drawing.Point(385, 180);
            this.btnRVincular.Name = "btnRVincular";
            this.btnRVincular.Size = new System.Drawing.Size(104, 48);
            this.btnRVincular.TabIndex = 2;
            this.btnRVincular.Text = "Vincular";
            this.btnRVincular.UseVisualStyleBackColor = false;
            this.btnRVincular.Click += new System.EventHandler(this.btnRVincular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(416, 257);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 33);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PochadoresSA.Properties.Resources.frmadmin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 448);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRVincular);
            this.Controls.Add(this.btnRCuenta);
            this.Controls.Add(this.btnRCliente);
            this.DoubleBuffered = true;
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRCliente;
        private System.Windows.Forms.Button btnRCuenta;
        private System.Windows.Forms.Button btnRVincular;
        private System.Windows.Forms.Button btnSalir;
    }
}