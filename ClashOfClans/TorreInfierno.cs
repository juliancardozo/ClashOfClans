using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class TorreInfierno : IDefensivo
    {
        
        public String nombre { get; }
        
        public Int32 vida { get;}
        
        public Int32 nivel { get;  }
    
        public Int32 dano { get;  }
        
        public Aldea aldea { get; set; }

        public Int32 cantidadMaxima { get; set; }
        public TorreInfierno(Aldea aldea)
        {
            this.aldea = aldea;
            nombre = "Torre Infierno";
            vida = 1200;
            nivel = 1;
            dano = 200;
            cantidadMaxima = 0;
        }
        public void AtacarTerrestre()
        {
            Console.WriteLine("Estoy atacando");
        }
    }
}
