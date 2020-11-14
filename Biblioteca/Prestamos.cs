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
    public partial class frmPrestamos : Form {
        public frmPrestamos() {
            InitializeComponent();
        }
        private void frmPrestamos_Load(object sender, EventArgs e) {
            limpiarPantalla();
        }
        public void limpiarPantalla() {
            lstPrestamos.Items.Clear();
            foreach (Prestamo prestamo in frmPrincipal.Prestamos) {
                lstPrestamos.Items.Add(prestamo.FechaPrestamo);
            }
            lblFecha.Text = "";
            lblNombre.Text = "";
            lblIsbn.Text = "";
            lblAutor.Text = "";
            lblSocio.Text = "";
            lblCodigo.Text = "";
        }

        private void lstPrestamos_SelectedIndexChanged(object sender, EventArgs e) {
            int seleccionado = lstPrestamos.SelectedIndex;
            int contador = 0;
            foreach (Prestamo prestamo in frmPrincipal.Prestamos) {
                if (contador == seleccionado) {
                    lblFecha.Text = prestamo.FechaPrestamo;
                    lblNombre.Text = prestamo.Ejemplar.Libro.Nombre;
                    lblIsbn.Text = prestamo.Ejemplar.Libro.Isbn;
                    lblAutor.Text = prestamo.Ejemplar.Libro.Autor;
                    lblSocio.Text = prestamo.Socio.Apellido + " " + prestamo.Socio.Nombre;
                    lblCodigo.Text = Convert.ToString(prestamo.Socio.CodSocio);
                }
                contador = contador + 1;
            }
        }
    }
}
