using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class LanzaRoca:ITropaOscura
    {
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }

        public void Atacar()
        {
            Console.WriteLine("Ataca el LanzaRoca.");
        }
    }
}
