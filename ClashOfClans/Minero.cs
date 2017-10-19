using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Minero:ITropaNormal
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Int32 elixirRojo { get; }

        public Minero(Aldea aldea)
        {
            this.nombre = "Minero";
            this.nivel = 1;
            this.velocidad = 20;
            this.dano = 25;
            this.espacio = 2;
            this.elixirRojo = 15;
        }
        public void Atacar()
        {
            Console.WriteLine("Ataca el Minero.");
        }
    }
}
