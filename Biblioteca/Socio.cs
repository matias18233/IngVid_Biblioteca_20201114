using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    class Socio {
        // ATRIBUTOS
        private string nombre;
        public string Nombre {
            get => nombre;
            set => nombre = value;
        }
        private string apellido;
        public string Apellido {
            get => apellido;
            set => apellido = value;
        }
        private int codSocio;
        public int CodSocio {
            get => codSocio;
            set => codSocio = value;
        }
        List<Ejemplar> retirados;
        internal List<Ejemplar> Retirados {
            get => retirados;
            set => retirados = value;
        }
        // CONSTRUCTOR
        public Socio() {
            Retirados = new List<Ejemplar>();
        }
        // METODOS
        public bool consultarLimite() {
            bool control;
            control = false;
            
            return control;
        }
        public Ejemplar retirarEjemplar() {
            Ejemplar ejemplar;
            ejemplar = new Ejemplar();

            return ejemplar;
        }
        private int limitePrestamo;
        public int LimitePrestamo {
            get => limitePrestamo;
            set => limitePrestamo = value;
        }
        public void devolverEjemplar(Ejemplar ejemplar) {

        }
    }
}
