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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario(String nombre)
        {
            InitializeComponent();

            this.nombre = nombre;
            
        }
        string nombre;
        private void btnTransferir_Click(object sender, EventArgs e)
        {
           
            frmTransfer log = new frmTransfer(nombre);
            log.Show();

            FrmUsuario log1 = new FrmUsuario(nombre);
            this.Hide();

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
