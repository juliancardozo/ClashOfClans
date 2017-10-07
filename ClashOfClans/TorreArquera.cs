using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class TorreArquera:IDefensivo
    {
        private String nom;
        public String nombre { get { return nom; } }
        private Int32 vid;
        public Int32 vida { get { return vid; } }
        private Int32 niv;
        public Int32 nivel { get { return niv; } }
        private Int32 dan;
        public Int32 dano { get { return dan; } }

        public void AtacarTerrestre()
        {
            Console.WriteLine("Estoy atacando");
        }
}
