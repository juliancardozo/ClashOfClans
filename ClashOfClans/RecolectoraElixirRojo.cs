using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public class RecolectoraElixirRojo :IRecolectora
    {
        public String nombre { get; }
        public Int32 vida { get; }
        public Int32 nivel { get; }
        public Int32 dano { get; }
        public Aldea aldea { get; set; }
        public Int32 cantidadMaxima { get; set; }

        public RecolectoraElixirRojo(Aldea aldea)
        {
            this.aldea = aldea;
            nombre="Recolectora Elixir Rojo";
            vida = 1000;
            nivel = 1;
            cantidadMaxima = 6;
        }

        public void Recolectar()
        {
            Int32 cantidad = 200;
            // Recorro los almacenes depositandolo que puedo
            foreach(AlmacenElixirRojo almacen in aldea.almacenesElixirRojo)
            {
                if(cantidad > 0)
                {
                    Int32 colocado = almacen.AlmacenarElixirRojo(cantidad);
                    cantidad -= colocado;
                }
            }
        }
    }
}
