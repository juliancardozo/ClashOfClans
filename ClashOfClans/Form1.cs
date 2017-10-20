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

        Aldea miAldea;

        public Form1()
        {
            InitializeComponent();

            listCuarteles.Columns.Add("Nombre");
            listCuarteles.Columns.Add("Nivel");

            listCuartelesOscuros.Columns.Add("Nombre");
            listCuartelesOscuros.Columns.Add("Nivel");
        }

        private void antiaereoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recolectorasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recolectoraOroToolStripMenuItem_Click(object sender, EventArgs e)
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
            miAldea = new Aldea();
            int oro = miAldea.almacenOro;
            this.oroAldea.Text = oro.ToString();
            //todo Metodo para hallar espacioLibre

            int elixirRojo = miAldea.almacenElixirRojo;
            this.elixirRojoAldea.Text = elixirRojo.ToString();

            int elixirNegro = miAldea.almacenElixirNegro;
            this.elixirNegroAldea.Text = elixirNegro.ToString();

        }

        private void cuartelToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Cuartel c = miAldea.crearEdificioCuartelNormal();
            String[] nuevoCuartel = { c.nombre, c.nivel.ToString() };
            var nuevoCuartelAgregar = new ListViewItem(nuevoCuartel);
            listCuarteles.Items.Add(nuevoCuartelAgregar);
        }

        private void arqueraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Arquera");
            }
        }

        private void barbaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Barbaro");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (miAldea.cuartelesNormal != null)
            {
                //TODO
                //Esto está mal pero no se como resolverlo rápido.
                miAldea.cuartelesNormal[0].crearTropa("Curandera");
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
    }
}
