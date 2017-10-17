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

        List<Canon> Canones;
        List<Antiaereo> Antiaereos;
        List<TorreMago> TorresMago;
        List<TorreArquera> TorresArquera;
        List<TorreInfierno> TorresInfierno;
        List<Muro> Muros;
        List<Tesla> Teslas;
        List<Aguila> Aguilas;
        List<Ballesta> Ballestas;
        List<Cuartel> Cuarteles;
        List<CuartelOscuro> CuartelesOscuro;
        readonly Ayuntamiento Ayuntamiento;
        readonly Castillo Castillo;
        List<Campamento> Campamentos;
        List<AlmacenOro> AlmacenesOro;
        List<AlmacenElixirRojo> AlmacenesElixirRojo;
        List<AlmacenElixirNegro> AlmacenesElixirNegro;
        List<RecolectoraOro> RecolectorasOro;
        List<RecolectoraElixirRojo> RecolectorasElixirRojo;
        List<RecolectoraElixirNegro> RecolectorasElixirNegro;

        readonly Warden Warden;
        readonly Rey Rey;
        readonly Reina Reina;

        // Normales
        List<Barbaro> Barbaros;
        List<Arquera> Arqueras;
        List<Gigante> Gigantes;
        List<Mago> Magos;
        List<Curandera> Curanderas;
        List<DragonBebe> DragonesBebe;
        List<Dragon> Dragones;
        List<Minero> Mineros;
        List<Pekka> Pekkas;
        List<Globo> Globos;
        List<Duende> Duendes;
        List<Esqueleto> Esqueletos;

        // Oscuras
        List<Esbirro> Esbirros;
        List<MontaPuerco> MontasPuerco;
        List<Golem> Golems;
        List<Valkiria> Valkirias;
        List<Bruja> Brujas;
        List<LanzaRoca> LanzaRocas;
        List<Lava> Lavas;

        Dictionary<String, IFactory> constructores;

        public Aldea()
        {

            almacenOro = 1000;
            almacenElixirRojo = 800;
            almacenElixirNegro = 500;

            Canones = new List<Canon>();
            Antiaereos = new List<Antiaereo>();
            TorresMago = new List<TorreMago>();
            TorresArquera = new List<TorreArquera>();
            TorresInfierno = new List<TorreInfierno>();
            Muros = new List<Muro>();
            Teslas = new List<Tesla>();
            Aguilas = new List<Aguila>();
            Ballestas = new List<Ballesta>();
            Cuarteles = new List<Cuartel>();
            CuartelesOscuro = new List<CuartelOscuro>();
            Campamentos = new List<Campamento>();
            AlmacenesOro = new List<AlmacenOro>();
            AlmacenesElixirRojo = new List<AlmacenElixirRojo>();
            AlmacenesElixirNegro = new List<AlmacenElixirNegro>();
            RecolectorasOro = new List<RecolectoraOro>();
            RecolectorasElixirRojo = new List<RecolectoraElixirRojo>();
            RecolectorasElixirNegro = new List<RecolectoraElixirNegro>();

            // Normales
            Barbaros = new List<Barbaro>();
            Arqueras = new List<Arquera>();
            Gigantes = new List<Gigante>();
            Magos = new List<Mago>();
            Curanderas = new List<Curandera>();
            DragonesBebe = new List<DragonBebe>();
            Dragones = new List<Dragon>();
            Mineros = new List<Minero>();
            Pekkas = new List<Pekka>();
            Mineros = new List<Minero>();
            Globos = new List<Globo>();
            Duendes = new List<Duende>();
            Esqueletos = new List<Esqueleto>();

            // Oscuras
            Esbirros = new List<Esbirro>();
            MontasPuerco = new List<MontaPuerco>();
            Golems = new List<Golem>();
            Valkirias = new List<Valkiria>();
            Brujas = new List<Bruja>();
            LanzaRocas = new List<LanzaRoca>();
            Lavas = new List<Lava>();

            constructores = new Dictionary<string, IFactory>;
            constructores.Add("Arquera", new FactoryArquera(this));

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
