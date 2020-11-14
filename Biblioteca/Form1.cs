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
    public partial class frmPrincipal : Form {
        // ATRIBUTOS
        static List<Libro> libros = new List<Libro>();
        public static List<Libro> Libros {
            get => libros;
            set => libros = value;
        }
        
        static List<Socio> socios = new List<Socio>();
        public static List<Socio> Socios {
            get => socios;
            set => socios = value;
        }
        /*
        static List<Vip> vip = new List<Vip>();
        public static List<Vip> Vip {
            get => vip;
            set => vip = value;
        }
        */
        // CONSTRUCTOR
        public frmPrincipal() {
            InitializeComponent();
            
        }
        // METODOS
        private void btnSocios_Click(object sender, EventArgs e) {
            Form formulario = new frmSocios();
            formulario.ShowDialog();
        }
        private void btnLibros_Click(object sender, EventArgs e) {
            Form formulario = new frmLibros();
            formulario.ShowDialog();
        }
        private void btnPrestamos_Click(object sender, EventArgs e) {
            Form formulario = new frmPrestamos();
            formulario.ShowDialog();
        }
        private void frmPrincipal_Load(object sender, EventArgs e) {
            
        }
        private void button1_Click(object sender, EventArgs e) {
            string cadena = Convert.ToString(Libros.Count);
            mostrarMensaje("Cantidad de libros: ", cadena);
            int contador = 1;
            foreach (Libro libro in Libros) {
                cadena = "El libro: " + Convert.ToString(contador) + " tiene: ";
                mostrarMensaje(cadena, Convert.ToString(libro.Ejemplares.Count()));
                contador = contador + 1;
            }
        }
        public void mostrarMensaje(string titulo, string mensaje) {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e) {
            string cadena = Convert.ToString(Socios.Count);
            mostrarMensaje("Cantidad de socios: ", cadena);
            int contador = 1;
            foreach (Socio socio in Socios) {
                cadena = "El socio: " + Convert.ToString(contador) + " tiene: ";
                mostrarMensaje(cadena, Convert.ToString(socio.Retirados.Count()));
                contador = contador + 1;
            }
        }
    }
}
