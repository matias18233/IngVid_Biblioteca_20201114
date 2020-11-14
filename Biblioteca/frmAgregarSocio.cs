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
    public partial class frmAgregarSocio : Form {
        // CONSTRUCTOR
        public frmAgregarSocio() {
            InitializeComponent();
        }
        // METODOS
        private void btnLimpiar_Click(object sender, EventArgs e) {
            limpiarPantalla();
        }
        public void limpiarPantalla() {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCodigo.Text = "";
            radioVip.Checked = true;
            txtCuota.Text = "";
            lblLimite.Text = "15";
        }
        private void frmAgregarSocio_Load(object sender, EventArgs e) {
            limpiarPantalla();
        }
        private void radioClasico_CheckedChanged(object sender, EventArgs e) {
            txtCuota.Enabled = false;
            lblLimite.Text = "3";
        }
        private void radioVip_CheckedChanged(object sender, EventArgs e) {
            txtCuota.Enabled = true;
            lblLimite.Text = "15";
        }
        private void btnGuardar_Click(object sender, EventArgs e) {
            // Variables útiles para mostrar mensajes
            bool error = false;
            string mensaje = "";
            string titulo = "";

            string nombre = "";
            string apellido = "";
            string codigo = "";
            bool vip = false;
            bool clasico = false;
            string cuota = "";
            nombre = txtNombre.Text;
            if ("".Equals(nombre)) {
                error = true;
                mensaje = "No se ha especificado un nombre";
            }
            if (error == false) {
                apellido = txtApellido.Text;
                if ("".Equals(apellido)) {
                    error = true;
                    mensaje = "No se ha especificado un apellido";
                }
            }
            if (error == true) {
                mostrarMensaje(titulo, mensaje);
            } else {

            }
            
        }
        public void mostrarMensaje(string titulo, string mensaje) {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
