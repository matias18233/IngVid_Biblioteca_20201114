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
        public bool consultarDisponibles(Libro _libro) {
            bool control;
            if (_libro.Ejemplares.Count() > 0) {
                control = true;
            } else {
                control = false;
            }
            return control;
        }
        public Ejemplar egresoEjemplar(int contador) {
            Ejemplar ejemplar = new Ejemplar();
            ejemplar = frmPrincipal.Libros[contador].Ejemplares.ElementAt(0);
            frmPrincipal.Libros[contador].Ejemplares.RemoveAt(0);
            return ejemplar;
        }
        public void ingresoEjemplar(Ejemplar _ejemplar, int contador) {
            frmPrincipal.Libros[contador].Ejemplares.Add(_ejemplar);
        }
    }
}
