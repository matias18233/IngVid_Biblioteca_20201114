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
    public partial class frmAgregarEjemplar : Form {
        public frmAgregarEjemplar() {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            limpiarPantalla();
        }

        public void limpiarPantalla() {
            txtEdicion.Text = "";
            txtUbicacion.Text = "";
        }

        private void frmAgregarEjemplar_Load(object sender, EventArgs e) {
            lstLibros.Items.Clear();
            foreach (Libro libro in frmPrincipal.Libros) {
                lstLibros.Items.Add(libro.Nombre);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            // Variables útiles para mostrar mensajes
            bool error = false;
            string mensaje = "";
            string titulo = "";

            // Recuperación del libro
            int indice = lstLibros.SelectedIndex;
            string edicion = "";
            string ubicacion = "";
            if (indice == -1) {
                error = true;
                mensaje = "No se ha seleccionado un libro";
            }
            if (error == false) {
                edicion = txtEdicion.Text;
                if ("".Equals(edicion)) {
                    error = true;
                    mensaje = "No se ha especificado una edición";
                }
                if (error == false) {
                    ubicacion = txtUbicacion.Text;
                    if ("".Equals(ubicacion)) {
                        error = true;
                        mensaje = "No se ha especificado una ubicación";
                    }
                }
            }
            if (error == true) {
                mostrarMensaje(titulo, mensaje);
            } else {
                int contador = 0;
                foreach (Libro libro in frmPrincipal.Libros) {
                    if (contador == indice) {
                        Ejemplar ejemplar = new Ejemplar();
                        ejemplar = ejemplar.agregarEjemplar(libro, Convert.ToInt32(edicion), ubicacion);
                        frmPrincipal.Libros[contador].Ejemplares.Add(ejemplar);
                        break;
                    }
                    contador = contador + 1;
                }
                titulo = "Genial!";
                mensaje = "Ejemplar agregado al libro";
                mostrarMensaje(titulo, mensaje);
                limpiarPantalla();
            }
        }

        public void mostrarMensaje(string titulo, string mensaje) {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
