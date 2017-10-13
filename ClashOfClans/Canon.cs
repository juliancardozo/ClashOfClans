using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Canon:ITerrestre
    {
        public String nombre { get; }

        public Int32 vida { get; }

        public Int32 nivel { get; }

        public Int32 dano { get; }

        public Aldea aldea { get; set; }

        public Canon(Aldea Aldea)
        {
            this.aldea = aldea;
            nombre = "Canon";
            vida = 1000;
            nivel = 1;
            dano = 150;
        }
        public void AtacarTerrestre()
        {
            Console.WriteLine("Estoy atacando tropa terrestre");
        }

    }
}
