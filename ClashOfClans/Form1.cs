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
            miAldea = new Aldea("Nombre de la Aldea");
            int oro = miAldea.OroDisponible();
            this.oroAldea.Text = oro.ToString();
            
            int espacioLibre = miAldea.EspaciosDisponibles();
            this.espacioLibreAldea.Text = espacioLibre.ToString();

            int elixirRojo = miAldea.ElixirRojoDisponible();
            this.elixirRojoAldea.Text = elixirRojo.ToString();

            int elixirNegro = miAldea.ElixirNegroDisponible();
            this.elixirNegroAldea.Text = elixirNegro.ToString();

        }

        private void cuartelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miAldea.crearEdificioCuartelNormal();
            String[] nuevoCuartel = { "Cuartel"};
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
