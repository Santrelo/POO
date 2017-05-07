using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace PochadoresSA
{
    public partial class frmTransfer : Form
    {

        public frmTransfer(string nombre)
        {


            InitializeComponent();
            this.nombre = nombre;


        }
        string nombre;
        private void frmTransfer_Load(object sender, EventArgs e)
        {


            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT Cuenta FROM Vincular WHERE Usuario = '" + nombre + "'";
            this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
            DataTable datos = new DataTable();

            this.oleDbDataAdapter1.Fill(datos);
            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            while (reader.Read())
            {

                cbCuentao.DataSource = datos;
                cbCuentao.DisplayMember = "Cuenta";
                cbCuentao.ValueMember = "Usuario";

                cbCuentao.SelectedText = "Selecciona una cuenta.";

            }
            this.oleDbConnection1.Close();


        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (cbCuentao.Text == "" || cbValor.Text == "" || cbCuentad.Text == "")
            {
                if (cbCuentao.Text == "")
                {
                    MessageBox.Show("Seleccione una de sus cuentas");
                }
                if (cbValor.Text == "")
                {
                    MessageBox.Show("ingrese el valor de la transferencia");
                }
                if (cbCuentad.Text == "")
                {
                    MessageBox.Show("ingrese la cuenta destino");
                }
            }
            else
            {
                this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT Valor FROM Vincular WHERE Usuario = '" + nombre + "' and Cuenta ='" + cbCuentao.Text + "';";
                this.oleDbConnection1.Open();

                this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;

                OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();

                Boolean ExistenciaRegistro = reader.HasRows;

                if (ExistenciaRegistro)
                {

                    while (reader.Read())
                    {
                        int valor = Convert.ToInt32(reader["Valor"].ToString());
                        if (valor > Convert.ToInt32(cbValor.Text))
                        {

                            MessageBox.Show("su saldo actual es $"+valor+" y va a transferir $"+ Convert.ToInt32(cbValor.Text)+" a la cuenta #"+cbCuentad.Text);
                            this.oleDbConnection1.Close();

                        }
                        else
                        {
                            MessageBox.Show("No es posible tranferir esta cantidad debido a que su saldo es " + valor);
                        }
                    }

                }
                else
                {
                 this.oleDbConnection1.Close();

                }
            }


        }
    }
}
