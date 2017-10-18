using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Cuartel : IProduccion
    {
        public String nombre { get; }
        public Int32 vida { get; }
        public Int32 nivel { get; }
        public Int32 dano { get; }
        public Aldea aldea { get; set; }
        public Int32 cantidadMaxima { get; set; }
        

        public Cuartel(Aldea aldea)
        {
            this.aldea = aldea;
            nombre = "Cuartel";
            vida = 1000;
            nivel = 1;

        }

        public void crearTropa(String tropa){
            ITropaNormal t = aldea.constructores[tropa].Instanciar(aldea);

            // Controlo espacios disponibles
            Int32 totalEspaciosDisponibles = 0;
            foreach (Campamento campamento in aldea.campamentos)
            {
                totalEspaciosDisponibles += campamento.espacio;
            }
            if (aldea.castillo != null)
            {
                totalEspaciosDisponibles += aldea.castillo.espacio;
            }
            bool espacioDisponible = (totalEspaciosDisponibles >= t.espacio);

            // Controlo recursos disponibles
            Int32 totalElixirRojoDisponibel = 0;
            if(aldea.ayuntamiento != null)
            {
                totalElixirRojoDisponibel += aldea.ayuntamiento.almacenElixirRojo;
            }
            foreach (Campamento campamento in aldea.campamentos)
            {
                totalEspaciosDisponibles += campamento.espacio;
            }
            bool recursosDisponibles = (totalElixirRojoDisponibel >= t.elixirRojo);

            if(totalEspaciosDisponibles && recursosDisponibles)
            {
                aldea.tropasNormales.Add(t);
            }


        }
    }
}
