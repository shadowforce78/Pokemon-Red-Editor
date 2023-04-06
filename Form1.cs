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

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ROM = new OpenFileDialog();
            ROM.Filter = "Gameboy ROM|*.gb";

            if (ROM.ShowDialog() == DialogResult.OK)
            {
                label1.Text = ROM.SafeFileName;
            }

            // send the ROM to a variable
            byte[] ROMBytes = System.IO.File.ReadAllBytes(ROM.FileName);


            //PrintFourthFirstByte(ROM);


        }

        // function to read the ROM bytes
        public void PrintFourthFirstByte(OpenFileDialog ROM)
        {
            // read the ROM file
            byte[] ROMBytes = System.IO.File.ReadAllBytes(ROM.FileName);
            // read the first 4 bytes of the ROM
            byte[] ROMHeader = new byte[4];
            Array.Copy(ROMBytes, 0, ROMHeader, 0, 4);
            // message box to show the first 4 bytes of the ROM
            MessageBox.Show(ROMHeader[0].ToString() + ROMHeader[1].ToString() + ROMHeader[2].ToString() + ROMHeader[3].ToString());
        }










        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


    }
}
