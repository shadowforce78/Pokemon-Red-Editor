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
        public void DisplayFourthFirstByte(OpenFileDialog ROM)
        {
            // read the ROM file
            byte[] ROMBytes = System.IO.File.ReadAllBytes(ROM.FileName);
            // read the first 4 bytes of the ROM
            byte[] ROMHeader = new byte[4];
            Array.Copy(ROMBytes, 0, ROMHeader, 0, 4);
            // message box to show the first 4 bytes of the ROM
            _ = MessageBox.Show(
                ROMHeader[0].ToString()
                    + ROMHeader[1].ToString()
                    + ROMHeader[2].ToString()
                    + ROMHeader[3].ToString()
            );
        }
    }
}
