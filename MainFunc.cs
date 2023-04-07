using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Red_Editor
{
    internal class MainFunc
    {
        public void DisplayPokeNames(OpenFileDialog ROM)
        {
            // read the ROM file
            byte[] ROMBytes = System.IO.File.ReadAllBytes(ROM.FileName);
            // get the offset of the first pokemon name
            int offset = 0x3D5E;
            // get the length of the first pokemon name
            int length = 0x0A;
            // get the first pokemon name
            string pokeName = System.Text.Encoding.ASCII.GetString(ROMBytes, offset, length);
            // display the first pokemon name
            MessageBox.Show(pokeName);

        }
    }
}
