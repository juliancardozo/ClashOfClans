using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Gigante:ITropaNormal
    {
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }

        public Gigante()
        {
            this.nombre = "Gigante";
            this.nivel = 1;
            this.velocidad = 10;
            this.dano = 9;
            this.espacio = 1;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca el Gigante.");
        }
    }
}
