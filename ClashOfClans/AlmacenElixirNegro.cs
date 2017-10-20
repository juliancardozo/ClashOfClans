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
        public Int32 disponible { get; set; }
        public Int32 cantidadMaxima { get; set; }


        public AlmacenElixirNegro(Aldea Aldea)
        {
            this.aldea = aldea;
            nombre = "Almacen Elixir Negro";
            vida = 1000;
            nivel = 1;
            capacidadMaxima = 2500;
            disponible = 0;
            cantidadMaxima = 1;
        }

        public Int32 AlmacenarElixirNegro(Int32 elixirNegro)
        {
            Int32 cantidadAntes = disponible;
            disponible += elixirNegro;
            if(disponible > capacidadMaxima)
            {
                disponible = capacidadMaxima;
            }

            return (disponible - cantidadAntes);
        }

        public void ExtraerElixirNegro(Int32 elixirNegro)
        {
            disponible -= elixirNegro;
        }
    }
}
