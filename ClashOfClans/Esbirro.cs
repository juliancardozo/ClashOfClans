using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Esbirro:ITropaOscura
    {
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }

        public Esbirro()
        {
            this.nombre = "Esbirro";
            this.nivel = 1;
            this.velocidad = 25;
            this.dano = 3;
            this.espacio = 1;
        }
        public void Atacar()
        {
            Console.WriteLine("Ataca el Esbirro.");
        }
    }
}
