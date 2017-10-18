using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Pekka:ITropaNormal
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Int32 elixirRojo { get; }

        public Pekka(Aldea aldea)
        {
            this.nombre = "Pekka";
            this.nivel = 1;
            this.velocidad = 10;
            this.dano = 15;
            this.espacio = 1;
            this.elixirRojo = 10;
        }
        public void Atacar()
        {
            Console.WriteLine("Ataca el Pekka.");
        }
    }
}
