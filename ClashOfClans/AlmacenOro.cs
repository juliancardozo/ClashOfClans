﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public class AlmacenOro :IAlmacen
    {

        public String nombre { get; }
        public Int32 vida { get; }
        public Int32 nivel { get; }
        public Int32 dano { get; }
        public Aldea aldea { get; set; }
        public Int32 capacidadMaxima { get;set; }
        public Int32 capacidadDisponible { get;set; }
        public Int32 cantidadMaxima { get; set; }


        public AlmacenOro(Aldea aldea)
        {
            this.aldea = aldea;
            nombre = "Almacen Oro";
            vida = 1000;
            nivel = 1;
            capacidadMaxima = 2500;
            capacidadDisponible = 0;
            cantidadMaxima = 4;
        }

        public void AlmacenarOro(Int32 oro)
        {
            capacidadDisponible += oro;
            if(capacidadDisponible > capacidadMaxima)
            {
                capacidadDisponible = capacidadMaxima;
            }
        }

        public void ExtraerOro(Int32 oro)
        {
            capacidadDisponible -= oro;
        }
    }
}
