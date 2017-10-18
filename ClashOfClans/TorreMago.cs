using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class TorreMago:IDefensivo
    {
        public String nombre { get; }

        public Int32 vida { get; }

        public Int32 nivel { get; }

        public Int32 dano { get; }

        public Aldea aldea { get; set; }

        public Int32 cantidadMaxima { get; set; }

        public TorreMago(Aldea aldea)
        {
            this.aldea = aldea;
            nombre = "Torre Mago";
            vida = 1200;
            nivel = 1;
            dano = 200;
        }

        public void AtacarTerrestre()
        {
            Console.WriteLine("Estoy atacando");
        }
    }
}
