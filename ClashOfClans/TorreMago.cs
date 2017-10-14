using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class TorreMago:IDefensivo
    {
        private String Nombre;
        public String nombre { get { return Nombre; } }
        private Int32 Vida;
        public Int32 vida { get { return Vida; } }
        private Int32 Nivel;
        public Int32 nivel { get { return Nivel; } }
        private Int32 Dano;
        public Int32 dano { get { return Dano; } }
        public String Aldea;
        public String aldea { get { return Aldea; } set { value = Aldea; } }

        public TorreMago(String Aldea)
        {
            this.Aldea = Aldea;
            Nombre = "Torre Mago";
            Vida = 1200;
            Nivel = 1;
            Dano = 200;
        }

        public void AtacarTerrestre()
        {
            Console.WriteLine("Estoy atacando");
        }
    }
}
