using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Duende:ITropaNormal
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Int32 elixirRojo { get; }

        public Duende(Aldea aldea)
        {
            this.nombre = "Duende";
            this.nivel = 1;
            this.velocidad = 35;
            this.dano = 15;
            this.espacio = 1;
            this.elixirRojo = 11;
        }
        public void Atacar()
        {
            Console.WriteLine("Ataca el duende.");
        }
    }
}
