using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Ballesta : IDefensivo
    {
        private String Nombre;
        public String nombre { get { return Nombre; } }
        private Int32 Vida;
        public Int32 vida { get { return Vida; } }
        private Int32 Nivel;
        public Int32 nivel { get { return Nivel; } }
        private Int32 Dano;
        public Int32 dano { get { return Dano; } }
        public Aldea Aldea;
        public Aldea aldea { get { return Aldea; } set { value = Aldea; } }

        public Ballesta(Aldea Aldea)
        {
            this.Aldea = Aldea;
            Nombre = "Ballesta";
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
