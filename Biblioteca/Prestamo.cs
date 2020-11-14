using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    public class Prestamo {
        // ATRIBUTOS
        private Ejemplar ejemplar;
        internal Ejemplar Ejemplar {
            get => ejemplar;
            set => ejemplar = value;
        }
        private Socio socio;
        internal Socio Socio {
            get => socio;
            set => socio = value;
        }
        private string fechaPrestamo;
        public string FechaPrestamo {
            get => fechaPrestamo;
            set => fechaPrestamo = value;
        }
        // CONSTRUCTOR
        public Prestamo() {
            ejemplar = new Ejemplar();
            socio = new Socio();
        }
        // METODOS
        public void agregarPrestamo(Ejemplar _ejemplar, Socio _socio) {
            Prestamo prestamo = new Prestamo();
            prestamo.Ejemplar = _ejemplar;
            prestamo.Socio = _socio;
            prestamo.FechaPrestamo = DateTime.Now.ToString("dd/MM/yyyy h:mm:ss");
            frmPrincipal.Prestamos.Add(prestamo);
        }
        public void imprimirPrestamo() {

        }
    }
}
