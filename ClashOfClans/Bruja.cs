using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Bruja:ITropaOscura
    {
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }

        public Bruja()
        {
            this.nombre = "Bruja";
            this.nivel = 1;
            this.velocidad = 15;
            this.dano = 55;
            this.espacio = 1;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca la bruja.");
        }
    }
}
