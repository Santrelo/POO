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
        private int actual;
        public frmTransfer(string nombre)
        {


            InitializeComponent();
            this.nombre = nombre;
            actual = getFirstId();
            showData();
        }

        private int getFirstId()
        {
            this.oleDbDataAdapter2.SelectCommand.CommandText = "SELECT * FROM Vincular";
            this.oleDbConnection2.Open();
            this.oleDbDataAdapter2.SelectCommand.Connection = oleDbConnection2;
            OleDbDataReader reader = this.oleDbDataAdapter2.SelectCommand.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt32(reader["Id"].ToString());
            this.oleDbConnection2.Close();
            return id;
        }

        private void showData()
        {
            this.oleDbDataAdapter2.SelectCommand.CommandText = "SELECT * FROM Vincular WHERE Id =" + actual;
            this.oleDbConnection2.Open();
            this.oleDbDataAdapter2.SelectCommand.Connection = oleDbConnection2;
            OleDbDataReader reader = this.oleDbDataAdapter2.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
               
                
                
            }
            this.oleDbConnection2.Close();
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
                        int valor2 = Convert.ToInt32(cbValor.Text);
                        if (valor > 2)
                        {
                            int total = valor - valor2;

                            MessageBox.Show("su saldo actual es $" + valor + " y va a transferir $" + Convert.ToInt32(cbValor.Text) + " a la cuenta #" + cbCuentad.Text);
                            //quitar saldo. 
                            try
                            {
                                this.oleDbDataAdapter2.UpdateCommand.CommandText =
                                    "UPDATE Vincular SET " +
                                    "Valor ='" + total.ToString() +
                                     "'" +
                                    " WHERE  Id =" + actual;
                                this.oleDbConnection2.Open();
                                this.oleDbDataAdapter2.UpdateCommand.Connection = oleDbConnection2;
                                this.oleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                                this.oleDbConnection2.Close();
                                MessageBox.Show("Registro actualizado correctamente.");

                            }
                            catch (System.Data.OleDb.OleDbException exp)
                            {
                                this.oleDbConnection2.Close();
                                MessageBox.Show(exp.ToString());
                            }
                           
                            //agregar movimiento a cuenta principal.
                            try
                            {
                                int resta = -(Convert.ToInt32(cbValor.Text));
                                string hola = "R";
                                this.oleDbDataAdapter2.InsertCommand.CommandText = "INSERT INTO Movimientos (Cuenta, Valor, Observacion) VALUES ('" + cbCuentao.Text + "','" + resta.ToString() + "' , '" + hola + "')";
                                this.oleDbConnection2.Open();
                                this.oleDbDataAdapter2.InsertCommand.Connection = oleDbConnection2;
                                this.oleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                                this.oleDbConnection2.Close();
                                MessageBox.Show("Registro agregado exitosamente");  //inform the user

                            }
                            catch (System.Data.OleDb.OleDbException exp)
                            {
                                this.oleDbConnection2.Close();

                                MessageBox.Show(exp.ToString());
                            }
                            //agregamos el saldo a la cuenta destino

                            this.oleDbDataAdapter2.SelectCommand.CommandText = "SELECT Valor,Id FROM Vincular WHERE Cuenta = '" + cbCuentad.Text +  "';";
                            this.oleDbConnection2.Open();

                            this.oleDbDataAdapter2.SelectCommand.Connection = oleDbConnection2;

                            OleDbDataReader reader1 = this.oleDbDataAdapter2.SelectCommand.ExecuteReader();

                            Boolean ExistenciaRegistro1 = reader1.HasRows;

                            if (ExistenciaRegistro1)
                            {

                                while (reader1.Read())
                                {
                                    int id = Convert.ToInt32(reader1["Id"].ToString());
                                    int valor1 = Convert.ToInt32(reader1["Valor"].ToString());
                                    

                                    int total1 = valor1 + valor2;

                                    //agregar  saldo. 
                                    try
                                    {
                                        this.oleDbDataAdapter3.UpdateCommand.CommandText =
                                            "UPDATE Vincular SET " +
                                            "Valor ='" + total1.ToString() +
                                             "'" +
                                            " WHERE  Id =" + id;
                                        this.oleDbConnection3.Open();
                                        this.oleDbDataAdapter3.UpdateCommand.Connection = oleDbConnection3;
                                        this.oleDbDataAdapter3.UpdateCommand.ExecuteNonQuery();
                                        this.oleDbConnection3.Close();
                                        MessageBox.Show("Registro actualizado correctamente.");

                                    }
                                    catch (System.Data.OleDb.OleDbException exp)
                                    {
                                        this.oleDbConnection3.Close();
                                        MessageBox.Show(exp.ToString());
                                    }
                                    //agregar movimiento a cuenta destino.
                                    try
                                    {
                                        int resta = +(Convert.ToInt32(cbValor.Text));
                                        string hola = "R";
                                        this.oleDbDataAdapter3.InsertCommand.CommandText = "INSERT INTO Movimientos (Cuenta, Valor, Observacion) VALUES ('" + cbCuentad.Text + "','" + resta.ToString() + "' , '" + hola + "')";
                                        this.oleDbConnection3.Open();
                                        this.oleDbDataAdapter3.InsertCommand.Connection = oleDbConnection3;
                                        this.oleDbDataAdapter3.InsertCommand.ExecuteNonQuery();
                                        this.oleDbConnection3.Close();
                                        MessageBox.Show("Registro agregado exitosamente");  //inform the user

                                    }
                                    catch (System.Data.OleDb.OleDbException exp)
                                    {
                                        this.oleDbConnection3.Close();

                                        MessageBox.Show(exp.ToString());
                                    }


                                }

                            }
                            else
                            {
                                this.oleDbConnection2.Close();

                            }


                        }

                        else
                        {
                            MessageBox.Show("No es posible tranferir esta cantidad debido a que su saldo es " + valor);
                        }
                    }
                    this.oleDbConnection1.Close();

                }
                else
                {
                    this.oleDbConnection1.Close();

                }
                
                    
                
            }


        }

       
    }
}
