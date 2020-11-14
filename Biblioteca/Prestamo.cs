using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    class Prestamo {
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
        private DateTime fechaPrestamo;
        public DateTime FechaPrestamo {
            get => fechaPrestamo;
            set => fechaPrestamo = value;
        }
        // CONSTRUCTOR
        public Prestamo() {
            ejemplar = new Ejemplar();
            socio = new Socio();
        }
        // METODOS
        public void agregarPrestamo(Ejemplar ejemplar, Socio socio) {

        }
        public void imprimirPrestamo() {

        }
        
    }
}
