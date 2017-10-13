using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Castillo:IEdificio
    {
        private String Nombre;
        public String nombre { get { return Nombre; } }
        private Int32 Vida;
        public Int32 vida { get { return Vida; } }
        private Int32 Nivel;
        public Int32 nivel { get { return Nivel; } }
        public String Aldea;
        public String aldea { get { return Aldea; } set { value = Aldea; } }

        public Int32 almacenOro;
        public Int32 almacenElixirRojo;
        public Int32 almacenElixirNegro;
        public Int32 espacio;
        public List<ITropa> tropas;
        public String nombreCastillo;
               
        public Castillo(String Aldea, String nombreCastillo)
        {
            almacenOro = 0;
            almacenElixirRojo = 0;
            almacenElixirNegro = 0;
            espacio = 1000;
            tropas = new List<ITropa>();
            this.nombreCastillo = nombreCastillo;
            this.Aldea = Aldea;
            Nombre = "Castillo";
            almacenElixirRojo = 0;
            almacenOro = 0;
            Vida = 1500;
            Nivel = 0;

        }
        public void IngresarOro(Int32 oro)
        {
            almacenOro += oro;
        }

        public void ExtraerOro(Int32 oro)
        {
            almacenOro -= oro;

        }

        public void IngresarElixirRojo(Int32 elixirRojo)
        {
            almacenElixirRojo += elixirRojo;
        }

        public void ExtraerElixirRojo(Int32 elixirRojo)
        {
            almacenElixirRojo -= elixirRojo;

        }
        public void IngresarElixirNegro(Int32 elixirNegro)
        {
            almacenElixirNegro += elixirNegro;
        }

        public void ExtraerElixirNegro(Int32 elixirNegro)
        {
            almacenElixirNegro -= elixirNegro;

        }
    }

}
