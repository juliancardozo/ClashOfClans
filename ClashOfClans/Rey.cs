using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Rey:IHeroe
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Rey()
        {
            this.nombre = "Rey";
            this.nivel = 1;
            this.velocidad = 50;
            this.dano = 50;
            this.espacio = 1;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca el Rey.");
        }
    }
}
