using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class AlmacenElixirRojo:IAlmacen
    {


        private String Nombre;
        public String nombre { get { return Nombre; } }
        private Int32 Vida;
        public Int32 vida { get { return Vida; } }
        private Int32 Nivel;
        public Int32 nivel { get { return Nivel; } }

        private Int32 capMax;
        public Int32 capacidadMaxima { get { return capMax; } set { value = capMax; } }
        private Int32 capDis;
        public Int32 capacidadDisponible { get { return capDis; } set { value = capDis; } }
        public String Aldea;
        public String aldea { get { return Aldea; } set { value = Aldea; } }


        public AlmacenElixirRojo(String Aldea)
        {
            this.Aldea = Aldea;
            Nombre = "Almacen Elixir Rojo";
            Vida = 1000;
            Nivel = 1;
            capMax = 2500;
            capDis = 2500;
        }
        public void AlmacenarElixirRojo(Int32 elixirRojo)
        {
            capacidadDisponible -= elixirRojo;
        }

        public void ExtraerElixirRojo(Int32 elixirRojo)
        {
            capacidadDisponible += elixirRojo;
        }
    }
}
