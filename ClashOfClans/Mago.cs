using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Mago:ITropaNormal
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Int32 elixirRojo { get; }

        public Mago(Aldea aldea)
        {
            this.nombre = "Mago";
            this.nivel = 1;
            this.velocidad = 30;
            this.dano = 9;
            this.espacio = 1;
            this.elixirRojo = 14;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca el Mago.");
        }


    }
}
