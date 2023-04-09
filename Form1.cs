using System;
using System.Windows.Forms;

namespace Pokemon_Red_Editor
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ROM = new OpenFileDialog();
            ROM.Filter = "Gameboy ROM|*.gb";

            if (ROM.ShowDialog() == DialogResult.OK)
            {
                label1.Text = ROM.SafeFileName;
            }

            // use the function from MainFunc.cs
            PokemonNames PokeFunction = new PokemonNames();
            PokeFunction.DisplayPokeNames(ROM);
        }

        private void tabPage4_Click(object sender, EventArgs e) { }

        private void tabPage1_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ROM saved");
        }
    }
}
