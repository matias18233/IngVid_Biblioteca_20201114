using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    public class Clasico : Socio {
        // CONSTRUCTOR
        public Clasico() {
            LimitePrestamo = 3;
        }
        // METODOS
        public Clasico agregarSocioClasico(string _nombre, string _apellido, int _codSocio) {
            Clasico clasico = new Clasico();

            clasico.Nombre = _nombre;
            clasico.Apellido = _apellido;
            clasico.CodSocio = _codSocio;

            return clasico;
        }
    }
}
