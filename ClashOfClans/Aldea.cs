using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Aldea
    {
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
        Ayuntamiento Ayuntamiento;
        Castillo Castillo;
        List<Campamento> Campamentos;
        List<AlmacenOro> AlmacenesOro;
        List<AlmacenElixirRojo> AlmacenesElixirRojo;
        List<AlmacenElixirNegro> AlmacenesElixirNegro;
        List<RecolectoraOro> RecolectorasOro;
        List<RecolectoraElixirRojo> RecolectorasElixirRojo;
        List<RecolectoraElixirNegro> RecolectorasElixirNegro;

        Warden Warden;
        Rey Rey;
        Reina Reina;

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

        public Aldea()
        {
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
        }

    }
}
