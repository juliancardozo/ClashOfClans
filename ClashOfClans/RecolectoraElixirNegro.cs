using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class RecolectoraElixirNegro:IRecolectora
    {
        public String nombre { get; }

        public Int32 vida { get; }

        public Int32 nivel { get; }

        public Int32 dano { get; }

        public Aldea aldea { get; set; }
        public Int32 cantidadMaxima { get; set; }


        public RecolectoraElixirNegro(Aldea aldea)
        {
            this.aldea = aldea;
            nombre = "Recolectora Elixir Negro";
            vida = 1000;
            nivel = 1;
            cantidadMaxima = 3;
        }
        public RecolectoraElixirNegro() { }

        public Int32 Recolectar()
        {
            return 50;
        }
    }
}
