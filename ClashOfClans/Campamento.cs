using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Campamento:IEdificio
    {
        private String nom;
        public String nombre { get { return nom; } }
        private Int32 vid;
        public Int32 vida { get { return vid; } }
        private Int32 niv;
        public Int32 nivel { get { return niv; } }

        public Int32 capacidad;

        public Campamento(Int32 capacidad)
        {
            this.capacidad = capacidad;
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
