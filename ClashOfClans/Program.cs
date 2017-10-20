using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClashOfClans
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            Aldea aldea = new Aldea("Sparta");

            Int32 oro = aldea.OroDisponible();
            Console.WriteLine("Oro disponible: " + oro);
            aldea.crearEdificioAlmacenOro();
            aldea.crearEdificioAlmacenOro();
            aldea.crearEdificioRecolectoraOro();

            aldea.recolectorasOro[1].Recolectar();
            Int32 oroNuevo = aldea.OroDisponible();
            Console.WriteLine("Oro disponible: " + oroNuevo);

        }
    }
}
