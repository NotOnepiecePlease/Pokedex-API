using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexAPI.Components
{
    public partial class pokebola : UserControl
    {
        public string url { get => picturePokemon.ImageLocation; set => picturePokemon.ImageLocation = value; }
        public pokebola()
        {
            InitializeComponent();
            pictureBorda.Controls.Add(picturePokemon);
            //picturePokemon.Location = new Point(0, 0);
            picturePokemon.BackColor = Color.Transparent;
        }
    }
}
