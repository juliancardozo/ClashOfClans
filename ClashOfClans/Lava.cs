using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Lava:ITropaOscura
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }

        public Lava(Aldea aldea)
        {
            this.nombre = "Lava";
            this.nivel = 1;
            this.velocidad = 55;
            this.dano = 45;
            this.espacio = 1;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca la Lava.");
        }
    }
}
