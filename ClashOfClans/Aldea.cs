using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public class Aldea
    {

        private Int32 almacenOro;
        private Int32 almacenElixirRojo;
        private Int32 almacenElixirNegro;

        public int AlmacenOro { get => almacenOro; set => almacenOro = value; }
        public int AlmacenElixirRojo { get => almacenElixirRojo; set => almacenElixirRojo = value; }
        public int AlmacenElixirNegro { get => almacenElixirNegro; set => almacenElixirNegro = value; }

        List<IDefensivo> defensivos;
        List<ITerrestre> terrestre;
        List<IAntiaereo> antiaereo;
        List<IProduccion> produccion;
        readonly Ayuntamiento ayuntamiento;
        readonly Castillo castillo;
        List<Campamento> campamentos;
        List<AlmacenOro> almacenesOro;
        List<AlmacenElixirRojo> almacenesElixirRojo;
        List<AlmacenElixirNegro> almacenesElixirNegro;
        List<RecolectoraOro> recolectorasOro;
        List<RecolectoraElixirRojo> recolectorasElixirRojo;
        List<RecolectoraElixirNegro> recolectorasElixirNegro;

        List<ITropaNormal> tropasNormales;
        List<ITropaOscura> tropasOscuras;
        readonly Warden Warden;
        readonly Rey Rey;
        readonly Reina Reina;

        Dictionary<String, IFactory> constructores;

        public Aldea()
        {

            almacenOro = 1000;
            almacenElixirRojo = 800;
            almacenElixirNegro = 500;

            Edificios = new List<IEdificio>();
            Tropas = new List<ITropa>();

            constructores = new Dictionary<string, IFactory>;
            constructores.Add("Arquera", new FactoryArquera(this));

        }

        public void crearTropa(String tropa)
        {
            ITropa t = constructores[tropa].Instanciar();

            // Controlo espacios disponibles
            bool espacioDisponible = false;
            Int32 totalEspaciosDisponibles = 0;
            foreach(Campamento campamento in Campamentos)
            {
                totalEspaciosDisponibles += campamento.espacio;
            }
            if(castillo != null)
            {
                totalEspaciosDisponibles += castillo.espacio;
            }


            // Controlo recursos disponibles
            bool recursosDisponible = false;


        }

        public void crearEdificio(String edificio)
        {
            if (edificio == "Ayuntamiento")
            {
                if(Ayuntamiento == null)
                {
                    Ayuntamiento Ayuntamiento = new Ayuntamiento(this);
                }
            }
            else if (edificio == "Castillo")
            {
                if(Castillo == null)
                {
                    Castillo Castillo = new Castillo(this);
                }
            }
            else if (edificio == "Canon")
            {
                Canones.Add(new Canon(this));
            }
            else if (edificio == "Antiaereo")
            {
                Antiaereos.Add(new Antiaereo(this));
            }
            else if (edificio == "TorreMago")
            {
                TorresMago.Add(new TorreMago(this));

            }
            else if (edificio == "TorreArquera")
            {
                TorresArquera.Add(new TorreArquera(this));

            }
            else if (edificio == "TorreInfierno")
            {
                TorresInfierno.Add(new TorreInfierno(this));

            }
            else if (edificio == "Muro")
            {
                Muros.Add(new Muro(this));

            }
            else if (edificio == "Tesla")
            {
                Teslas.Add(new Tesla(this));

            }
            else if (edificio == "Aguila")
            {
                Aguilas.Add(new Aguila(this));

            }
            else if (edificio == "Ballesta")
            {
                Ballestas.Add(new Ballesta(this));

            }
            else if (edificio == "Cuartel")
            {
                Cuarteles.Add(new Cuartel(this));

            }
            else if (edificio == "CuartelOscuro")
            {
                CuartelesOscuro.Add(new CuartelOscuro(this));

            }
            else if (edificio == "Campamento")
            {
                if(Campamentos.Count < 4)
                {
                    Campamentos.Add(new Campamento(this));
                }


            }
            else if (edificio == "AlmacenOro")
            {
                if(AlmacenesOro.Count < 4) { 
                    AlmacenesOro.Add(new AlmacenOro(this));
                }
            }
            else if (edificio == "AlmacenElixirRojo")
            {
                if(AlmacenesElixirRojo.Count < 4) {
                    AlmacenesElixirRojo.Add(new AlmacenElixirRojo(this));
                }
            }
            else if (edificio == "AlmacenElixirNegro")
            {
                if(AlmacenesElixirNegro.Count < 1) {
                    AlmacenesElixirNegro.Add(new AlmacenElixirNegro(this));
                }
            }
            else if (edificio == "RecolectoraOro")
            {
                if(RecolectorasOro.Count < 6) {
                    RecolectorasOro.Add(new RecolectoraOro(this));
                }
            }
            else if (edificio == "RecolectoraElixirRojo")
            {
                if(RecolectorasElixirRojo.Count < 6) {
                    RecolectorasElixirRojo.Add(new RecolectoraElixirRojo(this));
                }
            }
            else if (edificio == "RecolectoraElixirNegro")
            {
                if(RecolectorasElixirNegro.Count < 3) {
                    RecolectorasElixirNegro.Add(new RecolectoraElixirNegro(this));
                }
            }
        }

        public void crearWarden()
        {
            if(Warden == null)
            {
                Warden = new Warden(this);
            }
        }

        public void crearRey()
        {
            if (Rey == null)
            {
                Rey = new Rey(this);
            }
        }

        public void crearReina()
        {
            if (Reina == null)
            {
                Reina = new Reina(this);
            }
        }


    }
}
