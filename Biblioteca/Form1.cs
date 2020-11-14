using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void btnSocios_Click(object sender, EventArgs e) {
            Form formulario = new frmSocios();
            formulario.ShowDialog();
        }

        private void btnLibros_Click(object sender, EventArgs e) {
            Form formulario = new frmLibros();
            formulario.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            Form formulario = new frmPrestamos();
            formulario.ShowDialog();
        }
    }
}
