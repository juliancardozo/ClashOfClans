using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{

    /// <summary>
    /// Si en el metodo almacenar se supera la capacidad maxima, se iguala y el metodo devuelve un Int32 indicando cuanto se almaceno.
    /// </summary>
    /// 

    public class AlmacenElixirRojo :IAlmacen
    {
        public String nombre { get; }
        public Int32 vida { get; }
        public Int32 nivel { get; }
        public Int32 dano { get; }
        public Aldea aldea { get; set; }
        public Int32 capacidadMaxima { get; set;}
        public Int32 disponible { get; set;}
        public Int32 cantidadMaxima { get; set; }

        public AlmacenElixirRojo(Aldea aldea)
        {
            this.aldea = aldea;
            nombre = "Almacen Elixir Rojo";
            vida = 1000;
            nivel = 1;
            capacidadMaxima = 2500;
            disponible = 0;
            cantidadMaxima = 4;
        }
        public Int32 AlmacenarElixirRojo(Int32 elixirRojo)
        {
            Int32 disponibleAntes = disponible;
            disponible += elixirRojo;
            if(disponible > capacidadMaxima)
            {
                disponible = capacidadMaxima;
            }

            // Devuelvo lo almacenado
            return (disponible - disponibleAntes);
        }

        public void ExtraerElixirRojo(Int32 elixirRojo)
        {
            disponible -= elixirRojo;
        }
    }
}
