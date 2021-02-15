using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaControlCuentas.Negocio;

namespace SistemaControlCuentas.Presentacion
{
    public partial class frmCuentas : Form
    {
        public frmCuentas()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                NCuentas Datos = new NCuentas();
                dtgCuentas.DataSource = Datos.Listar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void frmCuentas_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
