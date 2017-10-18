﻿using System;
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

            constructores = new Dictionary<string, IFactoryTropaNormal>;
            constructores.Add("Arquera", new FactoryArquera(this));
            constructores.Add("Barbaro", new FactoryBarbaro(this));
            constructores.Add("Gigante", new FactoryGigante(this));
            constructores.Add("Mago", new FactoryMago(this));
            constructores.Add("Curandera", new FactoryCurandera(this));
            constructores.Add("DragonBebe", new FactoryDragonBebe(this));
            constructores.Add("Pekka", new FactoryPekka(this));
            constructores.Add("Dragon", new FactoryDragon(this));
            constructores.Add("Minero", new FactoryMinero(this));
            constructores.Add("Globo", new FactoryGlobo(this));
            constructores.Add("Duende", new FactoryDuende(this));
            constructores.Add("Esqueleto", new FactoryEsqueleto(this));

            constructoresTropaOscuro = new Dictionary<string, IFactoryTropaOscura>;
            constructoresTropaOscuro.Add("Esbirro", new FactoryEsbirro(this));
            constructoresTropaOscuro.Add("Lava", new FactoryLava(this));
            constructoresTropaOscuro.Add("LanzaRocas", new FactoryLanzaRoca(this));
            constructoresTropaOscuro.Add("MontaPuercos", new FactoryMontaPuerco(this));

            constructoresEdificiosAlmacen = new Dictionary<string, IFactoryAlmacen>;
            constructoresEdificiosAlmacen.Add("AlmacenElixirNegro", new FactoryAlamcenElixirNegro());
            constructoresEdificiosAlmacen.Add("AlmacenElixirRojo", new FactoryAlmacenElixirRojo());
            constructoresEdificiosAlmacen.Add("AlmacenOro", new FactoryAlmacenOro());

            constructoresEdificiosDefensivo = new Dictionary<string, IFactoryDefensivo>;
            constructoresEdificiosDefensivo.Add("TorreArqueta", new FactoryTorreArquera());
            constructoresEdificiosDefensivo.Add("Canones", new FactoryCanon());
            constructoresEdificiosDefensivo.Add("TorreMago", new FactoryTorreMago());
            constructoresEdificiosDefensivo.Add("Antiaereo", new FactoryAntiAereo());
            constructoresEdificiosDefensivo.Add("Tesla", new FactoryTesla());
            constructoresEdificiosDefensivo.Add("Ballesta", new FactoryBallesta());
            constructoresEdificiosDefensivo.Add("TorreInfierno", new FactoryTorreInfierno());
            constructoresEdificiosDefensivo.Add("Muro", new FactoryMuro());
            constructoresEdificiosDefensivo.Add("Aguila", new FactoryAguila());

            constructoresEdificiosProduccion = new Dictionary<string, IFactoryProduccion>;
            constructoresEdificiosProduccion.Add("Cuartel", new FactoryCuartel());
            constructoresEdificiosProduccion.Add("CuartelOscuro", new FactoryCuartelOscuro());

            constructoresEdificiosRecolectora = new Dictionary<string, IFactoryRecolectora>;
            constructoresEdificiosRecolectora.Add("RecolectoraElixirNegro", new FactoryRecolectoraElixirNegro());
            constructoresEdificiosRecolectora.Add("RecolectoraElixirRojo", new FactoryRecolectoraElixirRojo());
            constructoresEdificiosRecolectora.Add("RecolectoraOro", new FactoryRecolectoraOro());

            

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

        public void crearEdificioAlmacen(String edificio)
        {
            IAlmacen t = constructores[tropa].Instanciar();

            // Controlo espacios disponibles
            bool espacioDisponible = false;
            Int32 totalEspaciosDisponibles = 0;
            foreach (Campamento campamento in Campamentos)
            {
                totalEspaciosDisponibles += campamento.espacio;
            }
            if (castillo != null)
            {
                totalEspaciosDisponibles += castillo.espacio;
            }


            // Controlo recursos disponibles
            bool recursosDisponible = false;
        }

        public void crearEdificioDefensivo(String edificio)
        {

        }
        public void crearEdificioProduccion(String edificio)
        {

        }
        public void crearEdificioRecolectora(String edificio)
        {

        }
        public void crearEdificioCampamento(String edificio)
        {

        }
        public void crearEdificioCastillo(String edificio)
        {

        }
        public void crearEdificioAyuntamiento(String edificio)
        {

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
