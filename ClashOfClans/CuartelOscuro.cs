using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class CuartelOscuro:IProduccion
    {
        
            public String nombre { get; }

            public Int32 vida { get; }

            public Int32 nivel { get; }

            public Int32 dano { get; }

            public Aldea aldea { get; set; }


            public CuartelOscuro(Aldea aldea)
            {
                this.aldea = aldea;
                nombre = "Cuartel Oscuro";
                vida = 1000;
                nivel = 1;

            }

            public void GenerarOscura() { }
        }
}
