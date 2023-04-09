using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Red_Editor
{
    internal class PokemonNames
    {



        public void DisplayPokeNames(OpenFileDialog ROM)
        {
            List<string> pokemonNames = new List<string>();
            foreach (var pokemonName in pokemonNames)
            {
                MessageBox.Show(pokemonName);
            }
        }
    }
}
