using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace menu2
{
    public partial class Form1 : Form
    {

        public void clearColor()
        {
            negroToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked = false;
        }

        public void clearFont()
        {
            comicToolStripMenuItem.Checked = false;
            arialToolStripMenuItem.Checked = false;
        }

        public void clearStyle()
        {
            otroToolStripMenuItem.Checked = false;
        }

        public Form1()
        {      
            InitializeComponent();
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Times New Roman", 20);
        }

        private void otroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Times New Roman", 20, System.Drawing.FontStyle.Bold);
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void cambiarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = Interaction.InputBox("Ingresa una cadena", "Por favor");
        }

        private void creditosF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por mi");
        }

        private void salirAtlF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Black;
            negroToolStripMenuItem.Checked = true;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void comicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Comic Sans MS",20);
            comicToolStripMenuItem.Checked = true;
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Arial", 20);
            comicToolStripMenuItem.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
