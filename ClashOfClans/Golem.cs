using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Golem:ITropaOscura
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Int32 elixirRojo { get; }


        public Golem(Aldea aldea)
        {
            this.nombre = "Golem";
            this.nivel = 1;
            this.velocidad = 45;
            this.dano = 30;
            this.espacio = 10;
            this.elixirRojo = 50;
        }
        public void Atacar()
        {
            Console.WriteLine("Ataca el Golem.");
        }
    }
}
