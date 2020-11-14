using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    public class Socio {
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
        private int limitePrestamo;
        public int LimitePrestamo {
            get => limitePrestamo;
            set => limitePrestamo = value;
        }
        // CONSTRUCTOR
        public Socio() {
            Retirados = new List<Ejemplar>();
        }
        // METODOS
        public bool consultarLimite(Socio _socio) {
            bool control;
            if (_socio.Retirados.Count() < _socio.LimitePrestamo) {
                control = true;
            } else {
                control = false;
            }
            return control;
        }
        public Socio retirarEjemplar(Socio _socio, int contador, Ejemplar _ejemplar) {
            frmPrincipal.Socios[contador].Retirados.Add(_ejemplar);
            return _socio;
        }
        public Ejemplar devolverEjemplar(int _socio, int _ejemplar) {
            Ejemplar ejemplar = new Ejemplar();
            ejemplar = frmPrincipal.Socios[_socio].Retirados.ElementAt(_ejemplar);
            frmPrincipal.Socios[_socio].Retirados.RemoveAt(_ejemplar);
            return ejemplar;
            /*
             public Ejemplar egresoEjemplar(int contador) {
                Ejemplar ejemplar = new Ejemplar();
                ejemplar = frmPrincipal.Libros[contador].Ejemplares.ElementAt(0);
                frmPrincipal.Libros[contador].Ejemplares.RemoveAt(0);
                return ejemplar;
            }
             */
        }
    }
}
