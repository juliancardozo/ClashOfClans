using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Valkiria:ITropaOscura
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Int32 elixirNegro { get; }


        public Valkiria(Aldea aldea)
        {
            this.nombre = "Valkiria";
            this.nivel = 1;
            this.velocidad = 30;
            this.dano = 30;
            this.espacio = 1;
            this.elixirNegro = 15;
        }
        public void Atacar()
        {
            Console.WriteLine("Ataca Valkiria.");
        }
    }
}
