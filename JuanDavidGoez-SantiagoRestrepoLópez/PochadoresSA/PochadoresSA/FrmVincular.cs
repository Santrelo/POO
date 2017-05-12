using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PochadoresSA
{
    public partial class FrmVincular : Form
    {
        public FrmVincular()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO Vincular (Usuario, Cuenta, Valor) VALUES ('" + this.txbUsuario.Text + "','" + this.txbCuenta.Text + "' , '" + this.txbValor.Text + "')";
                this.oleDbConnection1.Open();
                this.oleDbDataAdapter1.InsertCommand.Connection = oleDbConnection1;
                this.oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
                this.oleDbConnection1.Close();
                MessageBox.Show("Registro agregado exitosamente");  //inform the user
                this.txbUsuario.Text = "";
                this.txbCuenta.Text = "";
                this.txbValor.Text = "";
               
            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                this.oleDbConnection1.Close();

                MessageBox.Show(exp.ToString());
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbCuenta.Text == "")
                {
                    MessageBox.Show("Ingrese el numero de cuenta, para poder borrar la vinculación");
                }
                else
                {


                    this.oleDbDataAdapter1.DeleteCommand.CommandText =
                        "DELETE FROM Vincular WHERE Cuenta ='" + this.txbCuenta.Text + "'";
                    this.oleDbConnection1.Open();
                    this.oleDbDataAdapter1.DeleteCommand.Connection = oleDbConnection1;
                    this.oleDbDataAdapter1.DeleteCommand.ExecuteNonQuery();
                    this.oleDbConnection1.Close();
                    MessageBox.Show("Registro eliminado correctamente");
                    this.txbUsuario.Text = "";
                    this.txbCuenta.Text = "";
                    this.txbValor.Text = "";
                }
                
                
            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                this.oleDbConnection1.Close();
                MessageBox.Show(exp.ToString());
            }

        }

        private void FrmVincular_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmVincular log = new FrmVincular();
            this.Hide();
            FrmAdmin log1 = new FrmAdmin();
            log1.Show();
        }
    }
}
