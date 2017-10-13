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

        public Int32 capacidad;
      

        public Campamento(Aldea Aldea)
        {
            capacidad = 100;
            this.aldea = aldea;
            nombre = "Campamento";
            vida = 1000;
            nivel = 1;
        }

        public void IngresarTropa()
        {
            capacidad -= 1;
        }

        public void EliminarTropa()
        {
            capacidad += 1;
        }
    }
}
