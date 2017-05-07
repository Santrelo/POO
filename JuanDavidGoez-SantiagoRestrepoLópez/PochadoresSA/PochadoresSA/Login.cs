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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();


        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            String nombre = txbUsuario.Text;
            String clave = txbContraseña.Text;
            String tipo = "admin";


            string EspacioEnBlanco = "";

            if (txbUsuario.Text == EspacioEnBlanco || txbContraseña.Text == EspacioEnBlanco)
            {
                if (txbUsuario.Text == EspacioEnBlanco)
                {
                    MessageBox.Show("No Ingreso nada En El Campo Usuario");
                }
                if (txbContraseña.Text == EspacioEnBlanco)
                {
                    MessageBox.Show("No Ingreso nada En El Campo Contraseña");
                }
            }
            else
            {

                if (tipo == "admin")
                {


                    this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM Usuarios WHERE Usuario = '" + nombre + "' and Contraseña ='" + clave + "' and TipoPersona ='" + tipo + "';";
                    this.oleDbConnection1.Open();

                    this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;

                    OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();

                    Boolean ExistenciaRegistro = reader.HasRows;


                    if (ExistenciaRegistro)
                    {

                        while (reader.Read())
                        {
                           
                            FrmAdmin log = new FrmAdmin();
                            log.Show();
                            Login cerrar = new Login();
                            this.Hide();

                        }

                    }
                    else
                    {
                        this.oleDbConnection1.Close();
                        tipo = "user";
                    }
                }
                if (tipo == "user")
                {

                    this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM Usuarios WHERE Usuario = '" + nombre + "' and Contraseña ='" + clave + "' and TipoPersona ='" + tipo + "';";
                    this.oleDbConnection1.Open();

                    this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;

                    OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();

                    Boolean ExistenciaRegistro = reader.HasRows;


                    if (ExistenciaRegistro)
                    {

                        while (reader.Read())
                        {


                            FrmUsuario log = new FrmUsuario(nombre);
                            log.Show();
                            Login cerrar = new Login();
                            this.Hide();
                          

                        }

                    }
                    else
                    {
                        this.oleDbConnection1.Close();
                        if (txbUsuario.Text == nombre)
                        {
                            if (txbUsuario.Text == clave)
                            {

                            }
                            else
                            {
                                MessageBox.Show("clave Incorrecta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario Incorrecta");
                        }
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

   
}



