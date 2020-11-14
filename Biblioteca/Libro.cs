using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    public class Libro {
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
        private List<Ejemplar> ejemplares;
        internal List<Ejemplar> Ejemplares {
            get => ejemplares;
            set => ejemplares = value;
        }

        // CONSTRUCTOR
        public Libro() {
            Ejemplares = new List<Ejemplar>();
        }
        // METODOS
        public Libro agregarLibro(string _nombre, string _isbc, string _autor) {
            Libro libro = new Libro();

            libro.Nombre = _nombre;
            libro.Isbn = _isbc;
            libro.autor = _autor;

            return libro;
        }
    }
}
