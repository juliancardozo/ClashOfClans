using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Barbaro:ITropaNormal
    {
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }

        public Barbaro() {
            this.nombre = "Barbaro";
            this.nivel = 1;
            this.velocidad = 50;
            this.dano = 8;
            this.espacio = 1;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca el barbaro.");
        }
    }
}
