using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class CuartelOscuro:IProduccion
    {
        class Cuartel : IProduccion
        {
            public String nombre { get; }

            public Int32 vida { get; }

            public Int32 nivel { get; }

            public Int32 dano { get; }

            public Aldea aldea { get; set; }


            public Cuartel(Aldea aldea)
            {
                this.aldea = aldea;
                nombre = "Cuartel Oscuro";
                vida = 1000;
                nivel = 1;

            }

            public void GenerarOscura() { }
        }
}
