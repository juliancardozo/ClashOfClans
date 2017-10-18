using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class LanzaRoca:ITropaOscura
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Int32 elixirNegro { get; }

        public LanzaRoca(Aldea aldea)
        {
            this.nombre = "LanzaRoca";
            this.nivel = 1;
            this.velocidad = 15;
            this.dano = 25;
            this.espacio = 2;
            this.elixirNegro = 18;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca el LanzaRoca.");
        }
    }
}
