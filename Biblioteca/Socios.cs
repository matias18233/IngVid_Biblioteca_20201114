using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca {
    public partial class frmSocios : Form {
        public frmSocios() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form formulario = new frmAgregarSocio();
            formulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            Form formulario = new frmDevolverEjemplar();
            formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            Form formulario = new frmRetirarEjemplar();
            formulario.ShowDialog();
        }
    }
}
