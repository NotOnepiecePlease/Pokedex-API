using Newtonsoft.Json;
using PokedexAPI.Components;
using System;
using System.Collections.Generic;
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
    public partial class frm_Pokedex : Form
    {
        private int contador = 1;
        private List<string> url_pokemons_list = new List<string>();

        public frm_Pokedex()
        {
            InitializeComponent();
            PegarImagensPokemon();
            //PreencherListaPokemon();
            //BuscarPokemao();
        }

        private void PegarImagensPokemon()
        {
            for (int i = 1; i < 897; i++)
            {
                flowLayoutPanel1.Controls.Add(new pokebola()
                {
                    url = @"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + i + ".png"
                }); ;
            }
        }

        private async Task BuscarPokemao()
        {
            //HttpClient client = new HttpClient { BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/") };
            //HttpResponseMessage response = await client.GetAsync(""+bunifuTextBox1.Text.ToLower()+"");
            //string content = await response.Content.ReadAsStringAsync();

            //// var imagePokemon = JsonConvert.DeserializeObject<Sprites>(content);
            //// var imagePokemon = JsonConvert.DeserializeObject<Sprites>(content);

            //dynamic JsonDeserialized = JsonConvert.DeserializeObject(content);
            //foreach (dynamic sprite in JsonDeserialized.sprites)
            //{
            //    if (sprite.Name == "front_default")
            //    {
            //        string url = sprite.Value;
            //        pictureBox1.ImageLocation = url;
            //        break;
            //    }
            //}
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

        private void button1_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Add(new Widget()
            //{
            //    url = @"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + contador + ".png"
            //});

            //label1.Text = @"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + contador + ".png";

            //contador++;

            // PreencherListaPokemon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label1.Text = contador.ToString();
        }
    }
}