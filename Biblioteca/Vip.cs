using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    class Vip : Socio {
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
    }
}
