using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public class Castillo:IEdificio
    {
        public String nombre { get; }

        public Int32 vida { get; }

        public Int32 nivel { get; }

        public Int32 dano { get; }

        public Aldea aldea { get; set; }
        public Int32 cantidadMaxima { get; set; }
    

        public Int32 almacenOro;
        public Int32 almacenElixirRojo;
        public Int32 almacenElixirNegro;
        public Int32 espacio;
        public String nombreCastillo;
               
        public Castillo(Aldea aldea)
        {
            almacenOro = 0;
            almacenElixirRojo = 0;
            almacenElixirNegro = 0;
            espacio = 1000;
            nombreCastillo= "Castillo del Clan";
            this.aldea = aldea;
            nombre = "Castillo";
            almacenElixirRojo = 0;
            almacenOro = 0;
            vida = 1500;
            nivel = 0;
            cantidadMaxima = 1;
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
