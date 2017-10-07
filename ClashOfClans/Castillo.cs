using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Castillo:IEdificio
    {
        private String nom;
        public String nombre { get { return nom; } }
        private Int32 vid;
        public Int32 vida { get { return vid; } }
        private Int32 niv;
        public Int32 nivel { get { return niv; } }

        public Int32 almacenOro;
        public Int32 almacenElixirRojo;
        public Int32 almacenElixirNegro;
        public Int32 espacio;
        public List<ITropa> tropas;
        public String nombreCastillo;

        public Castillo(Int32 almacenOro, Int32 almacenElixirRojo, Int32 almacenElixirNegro, Int32 espacio, List<ITropa> tropas, String nombreCastillo)
        {
            this.almacenOro = almacenOro;
            this.almacenElixirRojo = almacenElixirRojo;
            this.almacenElixirNegro = almacenElixirNegro;
            this.espacio = espacio;
            this.tropas = new List<ITropa>();
            this.nombreCastillo = nombreCastillo;

        }
        public void IngresarOro(Int32 oro)
        {
            almacenOro += oro;
        }

        public void ExtraerOro(Int32 oro)
        {
            almacenOro -= oro;

        }

        public void IngresarElixirRojo(Int32 elixirRojo)
        {
            almacenElixirRojo += elixirRojo;
        }

        public void ExtraerElixirRojo(Int32 elixirRojo)
        {
            almacenElixirRojo -= elixirRojo;

        }
        public void IngresarElixirNegro(Int32 elixirNegro)
        {
            almacenElixirNegro += elixirNegro;
        }

        public void ExtraerElixirNegro(Int32 elixirNegro)
        {
            almacenElixirNegro -= elixirNegro;

        }
    }

}
}
