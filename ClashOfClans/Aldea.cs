using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public class Aldea
    {
        public List<IDefensivo> defensivos;
        public List<ITerrestre> terrestres;
        public List<IAntiaereo> antiaereos;
        public List<Cuartel> cuartelesNormal;
        public List<CuartelOscuro> cuartelesOscuro;
        public readonly Ayuntamiento ayuntamiento;
        public readonly Castillo castillo;
        public List<Campamento> campamentos;
        public List<AlmacenOro> almacenesOro;
        public List<AlmacenElixirRojo> almacenesElixirRojo;
        public List<AlmacenElixirNegro> almacenesElixirNegro;
        public List<RecolectoraOro> recolectorasOro;
        public List<RecolectoraElixirRojo> recolectorasElixirRojo;
        public List<RecolectoraElixirNegro> recolectorasElixirNegro;

        public List<ITropaNormal> tropasNormales;
        public List<ITropaOscura> tropasOscuras;
        public Warden Warden { get; set; }
        public Rey Rey { get; set; }
        public Reina Reina { get; set; }
        public string nombreClan;

        public Dictionary<String, IFactoryTropaNormal> constructoresTropaNormal;
        public Dictionary<String, IFactoryTropaOscura> constructoresTropaOscuro;
        public Dictionary<String, IFactoryDefensivo> constructoresEdificiosDefensivo;

        public Aldea(String nombreClan)
        {
            this.nombreClan = nombreClan;
            this.ayuntamiento = new Ayuntamiento(this);
            this.castillo = new Castillo(this);

            tropasNormales = new List<ITropaNormal>();
            tropasOscuras = new List<ITropaOscura>();

            defensivos = new List<IDefensivo>();
            terrestres = new List<ITerrestre>();
            antiaereos = new List<IAntiaereo>();
            cuartelesNormal = new List<Cuartel>();
            cuartelesOscuro = new List<CuartelOscuro>();
            almacenesOro = new List<AlmacenOro>();
            almacenesElixirRojo = new List<AlmacenElixirRojo>();
            almacenesElixirNegro = new List<AlmacenElixirNegro>();
            recolectorasOro = new List<RecolectoraOro>();
            recolectorasElixirRojo = new List<RecolectoraElixirRojo>();
            recolectorasElixirNegro = new List<RecolectoraElixirNegro>();
            campamentos = new List<Campamento>();

            constructoresTropaNormal = new Dictionary<string, IFactoryTropaNormal>();
            constructoresTropaNormal.Add("Arquera", new FactoryArquera());
            constructoresTropaNormal.Add("Barbaro", new FactoryBarbaro());
            constructoresTropaNormal.Add("Gigante", new FactoryGigante());
            constructoresTropaNormal.Add("Mago", new FactoryMago());
            constructoresTropaNormal.Add("Curandera", new FactoryCurandera());
            constructoresTropaNormal.Add("DragonBebe", new FactoryDragonBebe());
            constructoresTropaNormal.Add("Pekka", new FactoryPekka());
            constructoresTropaNormal.Add("Dragon", new FactoryDragon());
            constructoresTropaNormal.Add("Minero", new FactoryMinero());
            constructoresTropaNormal.Add("Globo", new FactoryGlobo());
            constructoresTropaNormal.Add("Duende", new FactoryDuende());
            constructoresTropaNormal.Add("Esqueleto", new FactoryEsqueleto());

            constructoresTropaOscuro = new Dictionary<string, IFactoryTropaOscura>();
            constructoresTropaOscuro.Add("Esbirro", new FactoryEsbirro());
            constructoresTropaOscuro.Add("Lava", new FactoryLava());
            constructoresTropaOscuro.Add("LanzaRocas", new FactoryLanzaRoca());
            constructoresTropaOscuro.Add("MontaPuercos", new FactoryMontaPuerco());

            constructoresEdificiosDefensivo = new Dictionary<string, IFactoryDefensivo>();
            constructoresEdificiosDefensivo.Add("TorreArqueta", new FactoryTorreArquera());
            constructoresEdificiosDefensivo.Add("Canones", new FactoryCanon());
            constructoresEdificiosDefensivo.Add("TorreMago", new FactoryTorreMago());
            constructoresEdificiosDefensivo.Add("Antiaereo", new FactoryAntiAereo());
            constructoresEdificiosDefensivo.Add("Tesla", new FactoryTesla());
            constructoresEdificiosDefensivo.Add("Ballesta", new FactoryBallesta());
            constructoresEdificiosDefensivo.Add("TorreInfierno", new FactoryTorreInfierno());
            constructoresEdificiosDefensivo.Add("Muro", new FactoryMuro());
            constructoresEdificiosDefensivo.Add("Aguila", new FactoryAguila());

        }

        public Int32 OroDisponible()
        {
            Int32 total = 0;
            if (ayuntamiento != null){ total += ayuntamiento.almacenOro;  }
            if (castillo != null) { total += castillo.almacenOro; }
            if (almacenesOro.Count > 0)
            {
                foreach (AlmacenOro almancen in almacenesOro) { total += almancen.disponible; }
            }

            return total;
        }

        public Int32 ElixirRojoDisponible()
        {
            Int32 total = 0;
            if (ayuntamiento != null) { total += ayuntamiento.almacenElixirRojo; }
            if (castillo != null) { total += castillo.almacenElixirRojo; }
            if (almacenesElixirRojo.Count > 0){
                foreach (AlmacenElixirRojo almancen in almacenesElixirRojo) { total += almancen.disponible; }
            }

            // Resto el usado por las tropas normales
            if(tropasNormales.Count > 0)
            {
                foreach (ITropaNormal tropa in tropasNormales) { total -= tropa.elixirRojo; }
            }

            return total;
        }

        public Int32 ElixirNegroDisponible()
        {
            Int32 total = 0;
            if (castillo != null) { total += castillo.almacenElixirNegro; }
            if (almacenesElixirNegro.Count > 0)
            {
                foreach (AlmacenElixirNegro almancen in almacenesElixirNegro) { total += almancen.disponible; }
            }

            // Resto el usado por las tropas oscuras
            if(tropasOscuras.Count > 0)
            {
                foreach (ITropaOscura tropa in tropasOscuras) { total -= tropa.elixirNegro; }
            }

            return total;
        }

        public Int32 EspaciosDisponibles()
        {
            Int32 total = 0;
            if(campamentos.Count > 0)
            {
                foreach (Campamento campamento in campamentos) { total += campamento.espacio; }
            }
            if (castillo != null){ total += castillo.espacio; }

            // Resto las tropas
            if (tropasNormales.Count > 0)
            {
                foreach (ITropaNormal tropa in tropasNormales) { total -= tropa.espacio; }
            }
            if(tropasOscuras.Count > 0)
            {
                foreach (ITropaOscura tropa in tropasOscuras) { total -= tropa.espacio; }
            }

            return total;
        }

        public void crearEdificioDefensivo(String edificioNombre)
        {
            IDefensivo edificio = constructoresEdificiosDefensivo[edificioNombre].Instanciar(this);
            Int32 cantidad = 0;
            if (defensivos.Count > 0) {
                foreach (IDefensivo e in defensivos)
                {
                    if (e.nombre == edificio.nombre)
                    {
                        cantidad++;
                    }
                }
            }

            if (cantidad < edificio.cantidadMaxima || edificio.cantidadMaxima != 0)
            {
                this.defensivos.Add(edificio);
            }
        }

        public void crearEdificioTerrestre()
        {
            ITerrestre edificio = new Canon(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.terrestres.Count < edificio.cantidadMaxima || edificio.cantidadMaxima != 0)
            {
                this.terrestres.Add(edificio);
            }
        }

        public void crearEdificioAntiAereo()
        {
            IAntiaereo edificio = new Antiaereo(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.antiaereos.Count < edificio.cantidadMaxima || edificio.cantidadMaxima != 0)
            {
                this.antiaereos.Add(edificio);
            }
        }

        public void crearEdificioCuartelNormal()
        {
            Cuartel cuartel = new Cuartel(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.cuartelesNormal.Count < cuartel.cantidadMaxima || cuartel.cantidadMaxima != 0)
            {
                this.cuartelesNormal.Add(cuartel);
            }
        }

        public void crearEdificioCuartelOscuro()
        {
            CuartelOscuro cuartel = new CuartelOscuro(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.cuartelesOscuro.Count < cuartel.cantidadMaxima || cuartel.cantidadMaxima != 0)
            {
                this.cuartelesOscuro.Add(cuartel);
            }
        }

        public void crearEdificioCampamento()
        {
            Campamento campamento = new Campamento(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.campamentos.Count < campamento.cantidadMaxima || campamento.cantidadMaxima != 0)
            {
                this.campamentos.Add(campamento);
            }
        }

        public void crearEdificioAlmacenOro()
        {
            AlmacenOro almacen = new AlmacenOro(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.almacenesOro.Count < almacen.cantidadMaxima || almacen.cantidadMaxima != 0)
            {
                this.almacenesOro.Add(almacen);
            }
        }

        public void crearEdificioElixirRojo()
        {
            AlmacenElixirRojo almacen = new AlmacenElixirRojo(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.almacenesElixirRojo.Count < almacen.cantidadMaxima || almacen.cantidadMaxima != 0)
            {
                this.almacenesElixirRojo.Add(almacen);
            }
        }

        public void crearEdificioElixirNegro()
        {
            AlmacenElixirNegro almacen = new AlmacenElixirNegro(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.almacenesElixirNegro.Count < almacen.cantidadMaxima || almacen.cantidadMaxima != 0)
            {
                this.almacenesElixirNegro.Add(almacen);
            }
        }

        public void crearEdificioRecolectoraOro()
        {
            RecolectoraOro recolectora = new RecolectoraOro(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.recolectorasOro.Count < recolectora.cantidadMaxima || recolectora.cantidadMaxima != 0)
            {
                this.recolectorasOro.Add(recolectora);
            }
        }

        public void crearEdificioRecolectoraElixirRojo()
        {
            RecolectoraElixirRojo recolectora = new RecolectoraElixirRojo(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.recolectorasElixirRojo.Count < recolectora.cantidadMaxima || recolectora.cantidadMaxima != 0)
            {
                this.recolectorasElixirRojo.Add(recolectora);
            }
        }

        public void crearEdificioRecolectoraElixirNegro()
        {
            RecolectoraElixirNegro recolectora = new RecolectoraElixirNegro(this);
            // Controlo la cantidad maxima de edificios de este tipo
            if (this.recolectorasElixirNegro.Count < recolectora.cantidadMaxima || recolectora.cantidadMaxima != 0)
            {
                this.recolectorasElixirNegro.Add(recolectora);
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
