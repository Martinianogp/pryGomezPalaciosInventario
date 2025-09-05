using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGomezPalaciosInventario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBd = new clsConexionBD();
            clsConexionBd.ConectarBD();
            clsConexionBd.cargarCategorias(cboCategoria);
        }
    }


}
