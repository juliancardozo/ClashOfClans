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
            ITropa t = aldea.constructores[tropa].Instanciar(aldea);

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
            bool recursosDisponible = false;



        }
    }
}
