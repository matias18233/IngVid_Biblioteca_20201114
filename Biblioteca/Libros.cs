﻿using System;
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
    public partial class frmLibros : Form {
        public frmLibros() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form formulario = new frmAgregarLibro();
            formulario.ShowDialog();
        }

        private void btnEjemplar_Click(object sender, EventArgs e) {
            Form formulario = new frmAgregarEjemplar();
            formulario.ShowDialog();
        }
    }
}
