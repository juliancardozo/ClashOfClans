using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Globo:ITropaNormal
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }

        public Globo()
        {
            this.nombre = "Globo";
            this.nivel = 1;
            this.velocidad = 5;
            this.dano = 25;
            this.espacio = 1;
        }
        public void Atacar()
        {
            Console.WriteLine("Ataca el Globo.");
        }
    }
}
