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
            txtCuota.Text = "";
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
                if (error == false) {
                    codigo = txtCodigo.Text;
                    if ("".Equals(codigo)) {
                        error = true;
                        mensaje = "No se ha especificado un código";
                    } else {
                        // validar el código
                    }
                    if (error == false) {
                        vip = radioVip.Checked;
                        clasico = radioClasico.Checked;
                        if (vip == true) {
                            cuota = txtCuota.Text;
                            if ("".Equals(cuota)) {
                                error = true;
                                mensaje = "No se ha especificado un valor de cuota";
                            } else {
                                // Validar cuota
                            }
                        } else if (clasico == true) {
                            // Listo para guardar
                        } else {
                            error = true;
                            mensaje = "No se ha especificado un tipo de socio";
                        }
                    }
                }
            }
            if (error == true) {
                mostrarMensaje(titulo, mensaje);
            } else {
                if (vip == true) {
                    Vip vip_O = new Vip();

                    vip_O = vip_O.agregarSocioVip(nombre, apellido, Convert.ToInt32(codigo), float.Parse(cuota));

                    frmPrincipal.Socios.Add(vip_O);
                } else if (clasico == true) {
                    Clasico clasico_O = new Clasico();

                    clasico_O = clasico_O.agregarSocioClasico(nombre, apellido, Convert.ToInt32(codigo));
                    
                    frmPrincipal.Socios.Add(clasico_O);
                }
                mensaje = "Socio almacenado correctamente";
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
