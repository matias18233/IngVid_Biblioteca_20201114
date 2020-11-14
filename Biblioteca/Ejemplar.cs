using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    public class Ejemplar {
        // ATRIBUTOS
        private Libro libro;
        internal Libro Libro {
            get => libro;
            set => libro = value;
        }
        private int edicion;
        public int Edicion {
            get => edicion;
            set => edicion = value;
        }
        private string ubicacion;
        public string Ubicacion {
            get => ubicacion;
            set => ubicacion = value;
        }
        // CONSTRUCTOR
        public Ejemplar() {
            Libro = new Libro();
        }
        // METODOS
        public Ejemplar agregarEjemplar(Libro _libro, int _edicion, string _ubicacion) {
            Ejemplar ejemplar = new Ejemplar();

            ejemplar.Libro = _libro;
            ejemplar.edicion = _edicion;
            ejemplar.ubicacion = _ubicacion;

            return ejemplar;
        }

    }
}
