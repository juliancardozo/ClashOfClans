using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Muro : IDefensivo
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

        public Muro(String Aldea)
        {
            this.Aldea = Aldea;
            Nombre = "Muro";
            Vida = 1000;
            Nivel = 1;
            Dano = 150;
        }

        public void AtacarTerrestre()
        {
            Console.WriteLine("Estoy atacando");
        }

    }
}
