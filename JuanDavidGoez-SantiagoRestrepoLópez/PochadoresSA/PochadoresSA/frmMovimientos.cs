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
    public partial class frmMovimientos : Form
    {
        public frmMovimientos(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }
        string nombre;

        private void frmMovimientos_Load(object sender, EventArgs e)
        {

            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT Cuenta,Id FROM Vincular WHERE Usuario = '" + nombre + "'";
            this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
            DataTable datos = new DataTable();
            
            this.oleDbDataAdapter1.Fill(datos);
            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                
                cbCuentaO.DataSource = datos;
                cbCuentaO.DisplayMember = "Cuenta";
                cbCuentaO.ValueMember = "Id";

                cbCuentaO.SelectedText = "Selecciona una cuenta.";

            }
            this.oleDbConnection1.Close();


        }

        private void btnMovi_Click(object sender, EventArgs e)
        {
            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT Cuenta,Id FROM Vincular WHERE Usuario = '" + nombre + "'";
            this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
          

          
            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"].ToString());
                this.oleDbDataAdapter2.SelectCommand.CommandText = "SELECT * FROM Movimientos WHERE Cuenta = '" + cbCuentaO.Text  + "'";
                this.oleDbConnection2.Open();
                this.oleDbDataAdapter2.SelectCommand.Connection = oleDbConnection2;
                DataTable fecha = new DataTable();
                this.oleDbDataAdapter2.Fill(fecha);

                DataTable valor = new DataTable();
                 this.oleDbDataAdapter2.Fill(valor);

                DataTable obser = new DataTable();
                this.oleDbDataAdapter2.Fill(obser);

                OleDbDataReader reader2 = this.oleDbDataAdapter2.SelectCommand.ExecuteReader();
                while (reader2.Read())
                {
                    
                    lbCuenta.DataSource = fecha;
                    lbCuenta.DisplayMember = "Fecha";
                    lbCuenta.ValueMember = "Id";

                   
                    lbValor.DataSource = valor;
                    lbValor.DisplayMember = "Valor";
                    lbValor.ValueMember = "Id";

                    
                    lbObser.DataSource = obser;
                    lbObser.DisplayMember = "Observacion";
                    lbObser.ValueMember ="Id";


                }
                this.oleDbConnection2.Close();



            }
            this.oleDbConnection1.Close();
            

        }

        
    }
    
}
