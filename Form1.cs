using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //BuscarPokemao();
        }

        private async Task BuscarPokemao()
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/") };
            HttpResponseMessage response = await client.GetAsync(""+bunifuTextBox1.Text.ToLower()+"");
            string content = await response.Content.ReadAsStringAsync();

            // var imagePokemon = JsonConvert.DeserializeObject<Sprites>(content);
            // var imagePokemon = JsonConvert.DeserializeObject<Sprites>(content);

            dynamic JsonDeserialized = JsonConvert.DeserializeObject(content);
            foreach (dynamic sprite in JsonDeserialized.sprites)
            {
                if (sprite.Name == "front_default")
                {
                    string url = sprite.Value;
                    pictureBox1.ImageLocation = url;
                    break;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarPokemao();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            BuscarPokemao();
        }
    }
}
