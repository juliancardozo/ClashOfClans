﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class MontaPuerco:ITropaOscura
    {
        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Int32 elixirNegro { get; }

        public MontaPuerco(Aldea aldea)
        {
            this.nombre = "MontaPuerco";
            this.nivel = 1;
            this.velocidad = 25;
            this.dano = 25;
            this.espacio = 2;
            this.elixirNegro = 13;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca el MontaPuerco.");
        }
    }
}
