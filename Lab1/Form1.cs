using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            О_программе eee = new О_программе();
            eee.ShowDialog();
        }

        private void массивыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Массивы eee = new Массивы();
            eee.ShowDialog();
        }

        private void множестваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Множества eee = new Множества();
            eee.ShowDialog();
        }

        private void типыДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Типы_данных eee = new Типы_данных();
            eee.ShowDialog();
        }

        private void служебныеСловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Служебные_слова eee = new Служебные_слова();
            eee.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://devdocs.io/cpp/");

        }
    }
}
