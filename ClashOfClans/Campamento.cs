using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Campamento:IEdificio
    {
        private String Nombre;
        public String nombre { get { return Nombre; } }
        private Int32 Vida;
        public Int32 vida { get { return Vida; } }
        private Int32 Nivel;
        public Int32 nivel { get { return Nivel; } }

        public Int32 capacidad;
        public String Aldea;
        public String aldea { get { return Aldea; } set { value = Aldea; } }

        public Campamento(String Aldea)
        {
            capacidad = 100;
            this.Aldea = Aldea;
            Nombre = "Campamento";
            Vida = 1000;
            Nivel = 1;
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
