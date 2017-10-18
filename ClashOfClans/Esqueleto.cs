﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Esqueleto:ITropaNormal
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Int32 elixirRojo { get; }


        public Esqueleto(Aldea aldea)
        {
            this.nombre = "Esqueleto";
            this.nivel = 1;
            this.velocidad = 35;
            this.dano = 25;
            this.espacio = 1;
            this.elixirRojo = 15;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca el Esqueleto.");
        }
    }
}
