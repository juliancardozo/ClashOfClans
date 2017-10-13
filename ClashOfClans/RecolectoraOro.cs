﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class RecolectoraOro:IRecolectora
    {
        public String nombre { get; }

        public Int32 vida { get; }

        public Int32 nivel { get; }

        public Int32 dano { get; }

        public Aldea aldea { get; set; }


        public RecolectoraOro(Aldea aldea)
        {
            this.aldea = aldea;
            nombre = "Recolectora Oro";
            vida = 1000;
            nivel = 1;

        }

        public Int32 Recolectar()
        {
            return 50;
        }
        
    }
}