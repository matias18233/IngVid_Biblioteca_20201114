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
    public partial class frmAgregarLibro : Form {
        
        // CONSTRUCTOR
        public frmAgregarLibro() {
            InitializeComponent();
        }
        // METODOS
        private void btnLimpiar_Click(object sender, EventArgs e) {
            limpiarPantalla();
        }
        public void limpiarPantalla() {
            txtNombre.Text = "";
            txtIsbn.Text = "";
            txtAutor.Text = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e) {
            // Variables útiles para mostrar mensajes
            bool error = false;
            string mensaje = "";
            string titulo = "";

            string nombre = "";
            string isbn = "";
            string autor = "";
            // Validación de campos
            nombre = txtNombre.Text;
            if ("".Equals(nombre)) {
                error = true;
                mensaje = "No se ha ingresado un nombre";
                titulo = "Atención!";
            }
            if (error == false) {
                isbn = txtIsbn.Text;
                if ("".Equals(isbn)) {
                    error = true;
                    mensaje = "No se ha ingresado un ISBN";
                    titulo = "Atención!";
                }
                if (error == false) {
                    autor = txtAutor.Text;
                    if ("".Equals(autor)) {
                        error = true;
                        mensaje = "No se ha ingresado un autor";
                        titulo = "Atención!";
                    }
                }
            }
            if (error == true) {
                mostrarMensaje(titulo, mensaje);
            } else {
                Libro libro = new Libro();
                libro = libro.agregarLibro(nombre, isbn, autor);

                // Almacenamiento de libro

                frmPrincipal.Libros.Add(libro);
                mensaje = "Libro almacenado correctamente";
                titulo = "Genial!";
                mostrarMensaje(titulo, mensaje);
                limpiarPantalla();
            }
        }
        public void mostrarMensaje(string titulo, string mensaje) {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
