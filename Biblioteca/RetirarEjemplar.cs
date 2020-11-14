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
    public partial class frmRetirarEjemplar : Form {
        public frmRetirarEjemplar() {
            InitializeComponent();
        }

        private void frmRetirarEjemplar_Load(object sender, EventArgs e) {
            lstSocios.Items.Clear();
            foreach (Socio socio in frmPrincipal.Socios) {
                lstSocios.Items.Add(socio.Apellido + ", " + socio.Nombre);
            }
            lstLibros.Items.Clear();
            foreach (Libro libro in frmPrincipal.Libros) {
                lstLibros.Items.Add(libro.Nombre);
            }
        }

        private void lstSocios_SelectedIndexChanged(object sender, EventArgs e) {
            // Variables útiles para mostrar mensajes
            string mensaje = "";
            string titulo = "";

            int seleccionado = lstSocios.SelectedIndex;
            int contador = 0;
            foreach (Socio socio in frmPrincipal.Socios) {
                if (contador == seleccionado) {
                    if (socio.consultarLimite(socio)) {
                        lstLibros.Enabled = true;
                    } else {
                        lstLibros.Enabled = false;
                        mensaje = "El socio seleccionado no puede retirar libros";
                        titulo = "Atención";
                        mostrarMensaje(titulo, mensaje);
                    }
                }
                contador = contador + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
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
                        foreach (Libro libro in frmPrincipal.Libros) {
                            if (contador2 == seleccionado_libro) {
                                if (libro.consultarDisponibles(libro)) {
                                    socio.retirarEjemplar(socio, contador, libro.egresoEjemplar(contador2));
                                    mensaje = "El socio hizo un retiro de un ejemplar";
                                    titulo = "Genial!";
                                    mostrarMensaje(titulo, mensaje);
                                } else {
                                    mensaje = "Este libro no cuenta con ejemplares para prestar";
                                    titulo = "Atención";
                                    mostrarMensaje(titulo, mensaje);
                                }
                            }
                            contador2 = contador2 + 1;
                        }
                    }
                    contador = contador + 1;
                }
            }
        }
        public void mostrarMensaje(string titulo, string mensaje) {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void lstLibros_SelectedIndexChanged(object sender, EventArgs e) {
            // Variables útiles para mostrar mensajes
            string mensaje = "";
            string titulo = "";

            int seleccionado = lstLibros.SelectedIndex;
            int contador = 0;
            foreach (Libro libro in frmPrincipal.Libros) {
                if (contador == seleccionado) {
                    if (libro.consultarDisponibles(libro)) {

                    } else {
                        mensaje = "Este libro no cuenta con ejemplares para prestar";
                        titulo = "Atención";
                        mostrarMensaje(titulo, mensaje);
                    }
                }
                contador = contador + 1;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
