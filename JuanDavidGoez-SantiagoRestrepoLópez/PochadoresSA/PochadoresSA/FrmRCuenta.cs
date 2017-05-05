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

namespace PochadoresSA
{
    public partial class FrmRCuenta : Form
    {
       
        public FrmRCuenta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               
              


                    this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO Cuenta (NumCuenta) VALUES ('" + this.txbNumCuenta.Text + "')";
                if (txbNumCuenta.Text.Length <= 11)
                {
                    

                    this.oleDbConnection1.Open();
                    this.oleDbDataAdapter1.InsertCommand.Connection = oleDbConnection1;
                    this.oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
                    this.oleDbConnection1.Close();
                    MessageBox.Show("Se Registro Exitosamente la cuenta "+ txbNumCuenta.Text);  //inform the user
                    this.txbNumCuenta.Text = "";
                }
                else
                {
                    MessageBox.Show("El Numero de la cuenta debe contener 11 caracteres, ingresaste = "+ txbNumCuenta.Text.Length);
                }
               
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
                this.oleDbDataAdapter1.DeleteCommand.CommandText =
                                    "DELETE FROM Cuenta WHERE NumCuenta ='" + this.txbNumCuenta.Text + "'";
                this.oleDbConnection1.Open();
                this.oleDbDataAdapter1.DeleteCommand.Connection = oleDbConnection1;
                this.oleDbDataAdapter1.DeleteCommand.ExecuteNonQuery();
                this.oleDbConnection1.Close();
                MessageBox.Show("Registro eliminado correctamente");
                this.txbNumCuenta.Text = "";


            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                this.oleDbConnection1.Close();
                MessageBox.Show(exp.ToString());
            }

        }
        

    

   

    private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmAdmin log = new FrmAdmin();
            log.Show();
            FrmRCuenta cerrar = new FrmRCuenta();
            this.Hide();
        }

        
    }
}
