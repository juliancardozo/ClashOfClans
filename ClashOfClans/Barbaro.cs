using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Barbaro:ITropaNormal
    {
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }

        public Barbaro(String nombre, Int32 nivel, Int32 velocidad, Int32 dano, Int32 espacio ) {
            this.nombre = nombre;
            this.nivel = nivel;
            this.velocidad = velocidad;
            this.dano = dano;
            this.espacio = espacio;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca el barbaro.");
        }
    }
}
