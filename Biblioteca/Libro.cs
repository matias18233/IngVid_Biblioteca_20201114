using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    class Libro {
        // ATRIBUTOS
        private string nombre;
        public string Nombre {
            get => nombre;
            set => nombre = value;
        }
        private string isbn;
        public string Isbn {
            get => isbn;
            set => isbn = value;
        }
        private string autor;
        public string Autor {
            get => autor;
            set => autor = value;
        }
        List<Ejemplar> ejemplares;
        public List<Ejemplar> Ejemplares {
            get => ejemplares;
            set => ejemplares = value;
        }
        // CONSTRUCTOR
        public Libro() {
            Ejemplares = new List<Ejemplar>();
        }
    }
}
