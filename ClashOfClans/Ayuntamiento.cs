using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Ayuntamiento : IEdificio
    {
        private String Nombre;
        public String nombre { get { return Nombre; } }
        private Int32 Vida;
        public Int32 vida { get { return Vida; } }
        private Int32 Nivel;
        public Int32 nivel { get { return Nivel; } }
        public Int32 almacenOro;
        public Int32 almacenElixirRojo;
        public String Aldea;
        public String aldea { get { return Aldea; } set { value = Aldea; } }

        public Ayuntamiento(String Aldea)
        {
            this.Aldea = Aldea;
            Nombre = "Ayuntamiento";
            almacenElixirRojo = 0;
            almacenOro = 0;
            Vida = 1500;
            Nivel = 0;

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
    }

        
}
