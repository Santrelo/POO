namespace PochadoresSA
{
    partial class frmTransfer
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbValor = new System.Windows.Forms.TextBox();
            this.cbCuentad = new System.Windows.Forms.TextBox();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.cbCuentao = new System.Windows.Forms.ComboBox();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection3 = new System.Data.OleDb.OleDbConnection();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tus Cuentas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuenta Destino";
            // 
            // cbValor
            // 
            this.cbValor.Location = new System.Drawing.Point(111, 115);
            this.cbValor.Name = "cbValor";
            this.cbValor.Size = new System.Drawing.Size(125, 20);
            this.cbValor.TabIndex = 4;
            // 
            // cbCuentad
            // 
            this.cbCuentad.Location = new System.Drawing.Point(200, 69);
            this.cbCuentad.Name = "cbCuentad";
            this.cbCuentad.Size = new System.Drawing.Size(125, 20);
            this.cbCuentad.TabIndex = 5;
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
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(111, 188);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(112, 27);
            this.btnTransferir.TabIndex = 7;
            this.btnTransferir.Text = "Transeferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // cbCuentao
            // 
            this.cbCuentao.DisplayMember = "Usuario";
            this.cbCuentao.FormattingEnabled = true;
            this.cbCuentao.Location = new System.Drawing.Point(12, 69);
            this.cbCuentao.Name = "cbCuentao";
            this.cbCuentao.Size = new System.Drawing.Size(125, 21);
            this.cbCuentao.TabIndex = 8;
            this.cbCuentao.ValueMember = "Usuario";
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
            // oleDbDataAdapter3
            // 
            this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
            this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
            this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbConnection3
            // 
            this.oleDbConnection3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\JuanDavidGoez-SantiagoRestrepoLó" +
    "pez\\PochadoresSA\\PochadoresSA\\DbPonchadores1.accdb";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 301);
            this.Controls.Add(this.cbCuentao);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.cbCuentad);
            this.Controls.Add(this.cbValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cbValor;
        private System.Windows.Forms.TextBox cbCuentad;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.ComboBox cbCuentao;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
        private System.Data.OleDb.OleDbConnection oleDbConnection3;
    }
}