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
    public partial class frmDevolverEjemplar : Form {
        // CONSTRUCTOR
        public frmDevolverEjemplar() {
            InitializeComponent();
        }
        // METODOS
        private void frmDevolverEjemplar_Load(object sender, EventArgs e) {
            limpiarPantalla();
        }
        public void limpiarPantalla() {
            lstSocios.Items.Clear();
            foreach (Socio socio in frmPrincipal.Socios) {
                lstSocios.Items.Add(socio.Apellido + ", " + socio.Nombre);
            }
            lstLibros.Items.Clear();
        }
        private void lstSocios_SelectedIndexChanged(object sender, EventArgs e) {
            int seleccionado = lstSocios.SelectedIndex;
            int contador = 0;

            foreach (Socio socio in frmPrincipal.Socios) {
                if (contador == seleccionado) {
                    lstLibros.Items.Clear();
                    foreach (Ejemplar ejemplar in socio.Retirados) {
                        lstLibros.Items.Add(ejemplar.Libro.Nombre);
                    }
                }
                contador = contador + 1;
            }
        }
        public void mostrarMensaje(string titulo, string mensaje) {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnCargar_Click(object sender, EventArgs e) {
            // Variables útiles para mostrar mensajes
            bool error = false;
            string mensaje = "";
            string titulo = "";

            int seleccionado_socio = lstSocios.SelectedIndex;
            if (seleccionado_socio == -1) {
                error = true;
                mensaje = "No se ha seleccionado un socio";
                titulo = "Atención";
            }
            int seleccionado_libro = lstLibros.SelectedIndex;
            if (seleccionado_libro == -1) {
                error = true;
                mensaje = "No se ha seleccionado un libro";
                titulo = "Atención";
            }

            if (error == true) {
                mostrarMensaje(titulo, mensaje);
            } else {
                int contador = 0;
                int contador2 = 0;
                foreach (Socio socio in frmPrincipal.Socios) {
                    if (contador == seleccionado_socio) {
                        Ejemplar ejemplar = new Ejemplar();
                        ejemplar = socio.devolverEjemplar(seleccionado_socio, seleccionado_libro);
                        foreach (Libro ejemplar_O in frmPrincipal.Libros) {
                            if (ejemplar.Libro.Nombre == ejemplar_O.Nombre) {
                                ejemplar_O.ingresoEjemplar(ejemplar, contador2);
                                mensaje = "El socio regreso un ejemplar";
                                titulo = "Genial!";
                                mostrarMensaje(titulo, mensaje);
                                limpiarPantalla();
                            }
                            contador2 = contador2 + 1;
                        }
                    }
                    contador = contador + 1;
                }
            }
        }
    }
}
