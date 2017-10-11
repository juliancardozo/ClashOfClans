using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Curandera:ITropaNormal
    {
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }

        public Curandera()
        {
            this.nombre = "Curandera";
            this.nivel = 1;
            this.velocidad = 20;
            this.dano = 19;
            this.espacio = 1;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca la curandera.");
        }
    }
}
