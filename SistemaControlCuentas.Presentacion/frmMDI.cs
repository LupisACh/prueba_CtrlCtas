using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaControlCuentas;

namespace SistemaControlCuentas.Presentacion
{
    public partial class frmMDI : Form
    {
        
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentas frmCta = new frmCuentas();
            frmCta.MdiParent = this;
            frmCta.Show();
        }
    }
}
