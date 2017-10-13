using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class RecolectoraElixirRojo:IRecolectora
    {
        private String Nombre;
        public String nombre { get { return Nombre; } }
        private Int32 Vida;
        public Int32 vida { get { return Vida; } }
        private Int32 Nivel;
        public Int32 nivel { get { return Nivel; } }
        public String Aldea;
        public String aldea { get { return Aldea; } set { value = Aldea; } }

        public RecolectoraElixirRojo(String Aldea)
        {
            this.Aldea = Aldea;
            Nombre="Recolectora Elixir Rojo";
            Vida = 1000;
            Nivel = 1;

        }

        public RecolectoraElixirRojo() { }

        public Int32 Recolectar()
        {
            return 50;
        }
    }
}
