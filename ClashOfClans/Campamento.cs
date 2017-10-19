using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Campamento:IEdificio
    {
        public String nombre { get; }

        public Int32 vida { get; }

        public Int32 nivel { get; }

        public Aldea aldea { get; set; }

        public Int32 espacio { get; set; }

        public Int32 cantidadMaxima { get; set; }


        public Campamento(Aldea Aldea)
        {
            espacio = 100;
            this.aldea = aldea;
            nombre = "Campamento";
            vida = 1000;
            nivel = 1;
            cantidadMaxima = 4;
        }

        public void IngresarTropa()
        {
            espacio -= 1;
        }

        public void EliminarTropa()
        {
            espacio += 1;
        }
    }
}
