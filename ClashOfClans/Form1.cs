using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClashOfClans
{
    public partial class Form1 : Form
    {
        Aldea miAldea = new Aldea("miAldea");
        public Form1()
        {
            InitializeComponent();
            ActualizarRecursos();

        }

        private void ActualizarRecursos()
        {
            this.oroAldea.Text = (miAldea.OroDisponible()).ToString();
            this.elixirRojoAldea.Text = (miAldea.ElixirRojoDisponible()).ToString();
            this.elixirNegroAldea.Text = (miAldea.ElixirNegroDisponible()).ToString();
            this.espacioLibreAldea.Text = (miAldea.EspaciosDisponibles()).ToString();
        }

        private void antiaereoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioAntiAereo();
            String[] nuevo = { "AntiAereo" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listAntiaereo.Items.Add(nuevoAgregar);
        }

        private void recolectorasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void crearAldeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void cuartelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioCuartelNormal();
            String[] nuevo = { "Cuartel"};
            var nuevoCuartelAgregar = new ListViewItem(nuevo);
            listCuarteles.Items.Add(nuevoCuartelAgregar);
        }

        private void arqueraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Arquera");

                String[] nuevoItem = { "Arquera" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void barbaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Barbaro");
                String[] nuevoItem = { "Barbaro" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Curandera");
                String[] nuevoItem = { "Curandera" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void dragonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Dragon");
                String[] nuevoItem = { "Dragon" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void dragonBebéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("DragonBebe");
                String[] nuevoItem = { "DragonBebe" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void duendeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Duende");
                String[] nuevoItem = { "Duende" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void esqueletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Esqueleto");
                String[] nuevoItem = { "Esqueleto" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void giganteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Gigante");
                String[] nuevoItem = { "Gigante" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void globoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Globo");
                String[] nuevoItem = { "Globo" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void mineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Minero");
                String[] nuevoItem = { "Minero" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void magoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Mago");
                String[] nuevoItem = { "Mago" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void pekkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal.Count > 0)
            {
                miAldea.cuartelesNormal[0].crearTropa("Pekka");
                String[] nuevoItem = { "Pekka" };
                var nuevo = new ListViewItem(nuevoItem);
                listTropasNormales.Items.Add(nuevo);
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void cuartelOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.crearEdificioCuartelOscuro()) { 
                String[] nuevo = { "CuartelOscuro" };
                var nuevoCuartelAgregar = new ListViewItem(nuevo);
                listCuartelesOscuros.Items.Add(nuevoCuartelAgregar);
            }
        }

        private void almacenDeOroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.crearEdificioAlmacenOro()) { 
                String[] nuevoCuartel = { "AlmacenOro" };
                var nuevoCuartelAgregar = new ListViewItem(nuevoCuartel);
                listView6.Items.Add(nuevoCuartelAgregar);
            }
        }

        private void almacenDeElixirRojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.crearEdificioElixirRojo())
            {
                String[] nuevoCuartel = { "AlmacenER" };
                var nuevoCuartelAgregar = new ListViewItem(nuevoCuartel);
                listView5.Items.Add(nuevoCuartelAgregar);
            }
        }

        private void almacenDeElixirNegroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.crearEdificioElixirNegro()) { 
                String[] nuevoCuartel = { "AlmacenEN" };
                var nuevoCuartelAgregar = new ListViewItem(nuevoCuartel);
                listView4.Items.Add(nuevoCuartelAgregar);
            }
        }

        private void recolectarOroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.recolectorasOro.Count > 0) { 
            miAldea.recolectorasOro[0].Recolectar();
            this.ActualizarRecursos();
            } else
            {
                MessageBox.Show("No hay ninguna recolectora de Oro en esta Aldea.");
            }
        }

        private void recolectarElixirRojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.recolectorasElixirRojo.Count > 0)
            {
                miAldea.recolectorasElixirRojo[0].Recolectar();
                this.ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No hay ninguna recolectora de Elixir Rojo en esta Aldea.");
            }
            
        }

        private void recolectarElixirNegroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.recolectorasElixirNegro.Count > 0)
            {
                miAldea.recolectorasElixirNegro[0].Recolectar();
                this.ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No hay ninguna recolectora de Elixir Negro en esta Aldea.");
            }
           
        }

        private void campamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.crearEdificioCampamento()) { 
                String[] nuevo = { "Campamento" };
                var nuevoAgregar = new ListViewItem(nuevo);
                listCampamentos.Items.Add(nuevoAgregar);
            }
        }

        private void terrestresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.crearEdificioTerrestre()) { 
                String[] nuevo = { "Campamento" };
                var nuevoAgregar = new ListViewItem(nuevo);
                listTerrestres.Items.Add(nuevoAgregar);
            }
        }

        private void torreMagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.crearEdificioTerrestre())
            {
                String[] nuevo = { "TorreMago" };
                var nuevoAgregar = new ListViewItem(nuevo);
                listView2.Items.Add(nuevoAgregar);
            }
        }

        private void torreArqueraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.crearEdificioDefensivo("TorreArquera")) { 
                String[] nuevo = { "TorreArquera" };
                var nuevoAgregar = new ListViewItem(nuevo);
                listView2.Items.Add(nuevoAgregar);
            }
        }

        private void torreInfiernoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.crearEdificioDefensivo("TorreInfierno")) { 
                String[] nuevo = { "TorreInfierno" };
                var nuevoAgregar = new ListViewItem(nuevo);
                listView2.Items.Add(nuevoAgregar);
            }
        }

        private void muroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.crearEdificioDefensivo("Muro")) { 
                String[] nuevo = { "Muro" };
                var nuevoAgregar = new ListViewItem(nuevo);
                listView2.Items.Add(nuevoAgregar);
            }
        }

        private void teslaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (miAldea.crearEdificioDefensivo("Tesla")) { 
                String[] nuevo = { "Tesla" };
                var nuevoAgregar = new ListViewItem(nuevo);
                listView2.Items.Add(nuevoAgregar);
            }
        }

        private void águilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioDefensivo("Aguila");
            String[] nuevo = { "Aguila" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listView2.Items.Add(nuevoAgregar);
        }

        private void ballestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioDefensivo("Ballesta");
            String[] nuevo = { "Ballesta" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listView2.Items.Add(nuevoAgregar);
        }

        private void crearRecolectoraDeOroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioRecolectoraOro();
            String[] nuevo = { "RecolectoraOro" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listRecolectoraOro.Items.Add(nuevoAgregar);
        }

        private void crearRecolectoraDeElixirRojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioRecolectoraOro();
            String[] nuevo = { "RecolectoraER" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listRecolectoraElixirRojo.Items.Add(nuevoAgregar);
        }

        private void crearRecolectoraDeElixirNegroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioRecolectoraOro();
            String[] nuevo = { "RecolectoraEN" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listView3.Items.Add(nuevoAgregar);
        }

        private void esbirroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesOscuro.Count > 0)
            {
                miAldea.cuartelesOscuro[0].crearTropaOscura("Esbirro");
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles oscuros en esta aldea.");
            }
        }

        private void lavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesOscuro.Count > 0)
            {
                miAldea.cuartelesOscuro[0].crearTropaOscura("Lava");
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles oscuros en esta aldea.");
            }
        }

        private void lanzaRocasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesOscuro.Count > 0)
            {
                miAldea.cuartelesOscuro[0].crearTropaOscura("LanzaRocas");
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles oscuros en esta aldea.");
            }
        }

        private void montaPuercosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesOscuro.Count > 0)
            {
                miAldea.cuartelesOscuro[0].crearTropaOscura("montaPuercos");
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles oscuros en esta aldea.");
            }
        }

        private void brujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesOscuro.Count > 0)
            {
                miAldea.cuartelesOscuro[0].crearTropaOscura("Bruja");
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles oscuros en esta aldea.");
            }
        }

        private void golemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesOscuro.Count > 0)
            {
                miAldea.cuartelesOscuro[0].crearTropaOscura("Golem");
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles oscuros en esta aldea.");
            }
        }

        private void valkiriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesOscuro.Count > 0)
            {
                miAldea.cuartelesOscuro[0].crearTropaOscura("Valkiria");
                ActualizarRecursos();
            }
            else
            {
                MessageBox.Show("No tiene cuarteles oscuros en esta aldea.");
            }
        }
    }
}
