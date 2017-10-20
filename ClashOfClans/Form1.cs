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
            }
            else
            {
                MessageBox.Show("No tiene cuarteles en esta aldea.");
            }
        }

        private void dragonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Dragon");
            }
        }

        private void dragonBebéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("DragonBebe");
            }
        }

        private void duendeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Duende");
            }
        }

        private void esqueletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Esqueleto");
            }
        }

        private void giganteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Gigante");
            }
        }

        private void globoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Globo");
            }
        }

        private void mineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Minero");
            }
        }

        private void magoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Mago");
            }
        }

        private void pekkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Pekka");
            }
        }

        private void cuartelOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioCuartelOscuro();
            String[] nuevo = { "CuartelOscuro" };
            var nuevoCuartelAgregar = new ListViewItem(nuevo);
            listCuartelesOscuros.Items.Add(nuevoCuartelAgregar);
        }

        private void almacenDeOroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioAlmacenOro();
            String[] nuevoCuartel = { "AlmacenOro" };
            var nuevoCuartelAgregar = new ListViewItem(nuevoCuartel);
            listView6.Items.Add(nuevoCuartelAgregar);
        }

        private void almacenDeElixirRojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioElixirRojo();
            String[] nuevoCuartel = { "AlmacenER" };
            var nuevoCuartelAgregar = new ListViewItem(nuevoCuartel);
            listView5.Items.Add(nuevoCuartelAgregar);
        }

        private void almacenDeElixirNegroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioElixirNegro();
            String[] nuevoCuartel = { "AlmacenEN" };
            var nuevoCuartelAgregar = new ListViewItem(nuevoCuartel);
            listView4.Items.Add(nuevoCuartelAgregar);
        }

        private void recolectarOroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.recolectorasOro[0].Recolectar();
            this.ActualizarRecursos();
        }

        private void recolectarElixirRojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.recolectorasElixirRojo[0].Recolectar();
            this.ActualizarRecursos();
        }

        private void recolectarElixirNegroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.recolectorasElixirNegro[0].Recolectar();
            this.ActualizarRecursos();
        }

        private void campamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioCampamento();
            String[] nuevo = { "Campamento" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listCampamentos.Items.Add(nuevoAgregar);
        }

        private void terrestresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioTerrestre();
            String[] nuevo = { "Campamento" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listTerrestres.Items.Add(nuevoAgregar);
        }

        private void torreMagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioDefensivo("TorreMago");
            String[] nuevo = { "TorreMago" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listView2.Items.Add(nuevoAgregar);
        }

        private void torreArqueraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioDefensivo("TorreArquera");
            String[] nuevo = { "TorreArquera" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listView2.Items.Add(nuevoAgregar);
        }

        private void torreInfiernoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioDefensivo("TorreInfierno");
            String[] nuevo = { "TorreInfierno" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listView2.Items.Add(nuevoAgregar);
        }

        private void muroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioDefensivo("Muro");
            String[] nuevo = { "Muro" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listView2.Items.Add(nuevoAgregar);
        }

        private void teslaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioDefensivo("Tesla");
            String[] nuevo = { "Tesla" };
            var nuevoAgregar = new ListViewItem(nuevo);
            listView2.Items.Add(nuevoAgregar);
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



    }
}
