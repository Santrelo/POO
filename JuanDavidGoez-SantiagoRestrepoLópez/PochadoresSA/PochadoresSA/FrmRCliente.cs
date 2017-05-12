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
    public partial class FrmRCliente : Form
    {
        public FrmRCliente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmAdmin log = new FrmAdmin();
            log.Show();
            FrmRCliente cerrar = new FrmRCliente();
            this.Hide();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO Usuarios (Usuario,Contraseña,Cedula,Nombre,Direccion,Telefono,Email,TipoPersona) VALUES ('" + this.txbUsuario.Text + "','" + this.txbContraseña.Text + "' , '" + this.txbCedula.Text + "','" + this.txbNombre.Text + "','" + this.txbDireccion.Text + "','" + this.txbTelefono.Text + "','" + this.txbEmail.Text + "','" + "user" + "')";
                this.oleDbConnection1.Open();
                this.oleDbDataAdapter1.InsertCommand.Connection = oleDbConnection1;
                this.oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
                this.oleDbConnection1.Close();
                MessageBox.Show("Registro agregado exitosamente");  //inform the user
                this.txbUsuario.Text = "";
                this.txbContraseña.Text = "";
                this.txbCedula.Text = "";
                this.txbNombre.Text = "";
                this.txbDireccion.Text = "";
                this.txbTelefono.Text = "";
                this.txbEmail.Text = "";
                
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
                this.oleDbDataAdapter1.DeleteCommand.CommandText = "DELETE FROM Usuarios WHERE Usuario ='" + this.txbUsuario.Text + "'";

               
                this.oleDbConnection1.Open();
                
                this.oleDbDataAdapter1.DeleteCommand.Connection = oleDbConnection1;
                this.oleDbDataAdapter1.DeleteCommand.ExecuteNonQuery();
                this.oleDbConnection1.Close();
                MessageBox.Show("Registro eliminado correctamente");
                this.txbUsuario.Text = "";
                this.txbContraseña.Text = "";
                this.txbCedula.Text = "";
                this.txbNombre.Text = "";
                this.txbDireccion.Text = "";
                this.txbTelefono.Text = "";
                this.txbEmail.Text = "";

            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                this.oleDbConnection1.Close();
                MessageBox.Show(exp.ToString());
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombre = txbUsuario.Text;
            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM Usuarios WHERE Usuario = '" + nombre + "'";
            this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
               

                txbUsuario.Text = reader["Usuario"].ToString();
                txbContraseña.Text = reader["Contraseña"].ToString();
                txbCedula.Text = reader["Cedula"].ToString();
                txbNombre.Text = reader["Nombre"].ToString();
                txbDireccion.Text = reader["Direccion"].ToString();
                txbTelefono.Text = reader["Telefono"].ToString();
                txbEmail.Text = reader["Email"].ToString();
            }
            this.oleDbConnection1.Close();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String nombre = txbUsuario.Text;
            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM Usuarios WHERE Usuario = '" + nombre + "'";
            this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"].ToString());
                try
                {
                    this.oleDbDataAdapter2.UpdateCommand.CommandText =
                         "UPDATE Usuarios SET " +
                        " Contraseña ='" + this.txbContraseña.Text +
                        "', Cedula ='" + this.txbCedula.Text +
                        "', Nombre ='" + this.txbNombre.Text +
                        "', Direccion ='" + this.txbDireccion.Text +
                        "', Telefono ='" + this.txbTelefono.Text + "', Email ='" +
                        this.txbEmail.Text + "'" +
                        " WHERE  Id =" + id;

                    this.oleDbConnection2.Open();
                    this.oleDbDataAdapter2.UpdateCommand.Connection = oleDbConnection2;
                    this.oleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                    this.oleDbConnection2.Close();
                    MessageBox.Show("Registro actualizado correctamente.");
                    this.txbUsuario.Text = "";
                    this.txbContraseña.Text = "";
                    this.txbCedula.Text = "";
                    this.txbNombre.Text = "";
                    this.txbDireccion.Text = "";
                    this.txbTelefono.Text = "";
                    this.txbEmail.Text = "";
                }
                catch (System.Data.OleDb.OleDbException exp)
                {
                    this.oleDbConnection2.Close();
                    MessageBox.Show(exp.ToString());
                }

            }
            this.oleDbConnection1.Close();
            

        }
    }
}
