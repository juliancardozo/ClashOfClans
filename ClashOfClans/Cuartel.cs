using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public class Cuartel : IProduccion
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
            cantidadMaxima = 4;

        }

        /// <summary>
        /// Si cumplo todos los recuros y espacios necesarios devuelvo true, sino false
        /// </summary>

        public void crearTropa(String tropa){
            ITropaNormal t = aldea.constructoresTropaNormal[tropa].Instanciar(aldea);

            if (aldea.EspaciosDisponibles() >= t.espacio && aldea.ElixirRojoDisponible() >= t.elixirRojo)
            {
                aldea.tropasNormales.Add(t);
                return true;
            }
            return false;
        }
    }
}
