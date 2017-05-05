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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnRCliente_Click(object sender, EventArgs e)
        {
            FrmRCliente log = new FrmRCliente();
            log.Show();
            FrmAdmin cerrar = new FrmAdmin();
            this.Hide();

        }

        private void btnRCuenta_Click(object sender, EventArgs e)
        {
            FrmRCuenta log = new FrmRCuenta();
            log.Show();
            FrmAdmin cerrar = new FrmAdmin();
            this.Hide();
        }

        private void btnRVincular_Click(object sender, EventArgs e)
        {
            FrmVincular log = new FrmVincular();
            log.Show();
            FrmAdmin cerrar = new FrmAdmin();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            FrmAdmin cerrar = new FrmAdmin();
            this.Hide();
        }
    }
}
