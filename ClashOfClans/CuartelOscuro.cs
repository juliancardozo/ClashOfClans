﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class CuartelOscuro:IProduccion
    {
        class Cuartel : IProduccion
        {
            private String Nombre;
            public String nombre { get { return Nombre; } }
            private Int32 Vida;
            public Int32 vida { get { return Vida; } }
            private Int32 Nivel;
            public Int32 nivel { get { return Nivel; } }

            public String Aldea;
            public String aldea { get { return Aldea; } set { value = Aldea; } }


            public Cuartel(String Aldea)
            {
                this.Aldea = Aldea;
                Nombre = "Cuartel Oscuro";
                Vida = 1000;
                Nivel = 1;

            }

            public void GenerarOscura() { }
        }
}
