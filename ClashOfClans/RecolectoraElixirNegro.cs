using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public class RecolectoraElixirNegro :IRecolectora
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

        public void Recolectar()
        {
            Int32 cantidad = 200;
            // Recorro los almacenes depositandolo que puedo
            foreach (AlmacenElixirNegro almacen in aldea.almacenesElixirNegro)
            {
                if (cantidad > 0)
                {
                    Int32 colocado = almacen.AlmacenarElixirNegro(cantidad);
                    cantidad -= colocado;
                }
            }
        }
    }
}
