using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    public class Vip : Socio {
        // ATRIBUTOS
        private float cuota;
        public float Cuota {
            get => cuota;
            set => cuota = value;
        }
        // CONSTRUCTOR
        public Vip() {
            LimitePrestamo = 15;
        }
        // METODOS
        public Vip agregarSocioVip(string _nombre, string _apellido, int _codSocio, float _cuota) {
            Vip vip = new Vip();

            vip.Nombre = _nombre;
            vip.Apellido = _apellido;
            vip.CodSocio = _codSocio;
            vip.Cuota = _cuota;

            return vip;
        }
    }
}
