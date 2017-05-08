namespace PochadoresSA
{
    partial class frmMovimientos
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
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.cbCuentaO = new System.Windows.Forms.ComboBox();
            this.btnMovi = new System.Windows.Forms.Button();
            this.lbCuenta = new System.Windows.Forms.ListBox();
            this.lbValor = new System.Windows.Forms.ListBox();
            this.lbObser = new System.Windows.Forms.ListBox();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.SuspendLayout();
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\JuanDavidGoez-SantiagoRestrepoLó" +
    "pez\\PochadoresSA\\PochadoresSA\\DbPonchadores1.accdb";
            // 
            // cbCuentaO
            // 
            this.cbCuentaO.FormattingEnabled = true;
            this.cbCuentaO.Location = new System.Drawing.Point(33, 12);
            this.cbCuentaO.Name = "cbCuentaO";
            this.cbCuentaO.Size = new System.Drawing.Size(131, 21);
            this.cbCuentaO.TabIndex = 0;
            // 
            // btnMovi
            // 
            this.btnMovi.Location = new System.Drawing.Point(194, 12);
            this.btnMovi.Name = "btnMovi";
            this.btnMovi.Size = new System.Drawing.Size(131, 20);
            this.btnMovi.TabIndex = 1;
            this.btnMovi.Text = "Mostrar movimientos";
            this.btnMovi.UseVisualStyleBackColor = true;
            this.btnMovi.Click += new System.EventHandler(this.btnMovi_Click);
            // 
            // lbCuenta
            // 
            this.lbCuenta.FormattingEnabled = true;
            this.lbCuenta.Location = new System.Drawing.Point(27, 53);
            this.lbCuenta.Name = "lbCuenta";
            this.lbCuenta.Size = new System.Drawing.Size(110, 134);
            this.lbCuenta.TabIndex = 2;
            // 
            // lbValor
            // 
            this.lbValor.FormattingEnabled = true;
            this.lbValor.Location = new System.Drawing.Point(143, 53);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(110, 134);
            this.lbValor.TabIndex = 3;
            // 
            // lbObser
            // 
            this.lbObser.FormattingEnabled = true;
            this.lbObser.Location = new System.Drawing.Point(259, 53);
            this.lbObser.Name = "lbObser";
            this.lbObser.Size = new System.Drawing.Size(110, 134);
            this.lbObser.TabIndex = 4;
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\JuanDavidGoez-SantiagoRestrepoLó" +
    "pez\\PochadoresSA\\PochadoresSA\\DbPonchadores1.accdb";
            // 
            // frmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 253);
            this.Controls.Add(this.lbObser);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbCuenta);
            this.Controls.Add(this.btnMovi);
            this.Controls.Add(this.cbCuentaO);
            this.Name = "frmMovimientos";
            this.Text = "frmMovimientos";
            this.Load += new System.EventHandler(this.frmMovimientos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Windows.Forms.ComboBox cbCuentaO;
        private System.Windows.Forms.Button btnMovi;
        private System.Windows.Forms.ListBox lbCuenta;
        private System.Windows.Forms.ListBox lbValor;
        private System.Windows.Forms.ListBox lbObser;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
    }
}