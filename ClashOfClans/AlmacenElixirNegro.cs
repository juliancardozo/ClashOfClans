using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public class AlmacenElixirNegro :IAlmacen
    {
        public String nombre { get; }
        public Int32 vida { get; }
        public Int32 nivel { get; }
        public Int32 dano { get; }
        public Aldea aldea { get; set; }
        public Int32 capacidadMaxima { get; set; }
        public Int32 capacidadDisponible { get; set; }
        public Int32 cantidadMaxima { get; set; }


        public AlmacenElixirNegro(Aldea Aldea)
        {
            this.aldea = aldea;
            nombre = "Almacen Elixir Negro";
            vida = 1000;
            nivel = 1;
            capacidadMaxima = 2500;
            capacidadDisponible = 0;
            cantidadMaxima = 1;
        }

        public void AlmacenarElixirNegro(Int32 elixirNegro)
        {
            capacidadDisponible += elixirNegro;
            if(capacidadDisponible > capacidadDisponible)
            {
                capacidadDisponible = capacidadDisponible;
            }
        }

        public void ExtraerElixirNegro(Int32 elixirNegro)
        {
            capacidadDisponible -= elixirNegro;
        }
    }
}
