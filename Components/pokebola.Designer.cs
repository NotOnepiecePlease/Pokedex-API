
namespace PokedexAPI.Components
{
    partial class pokebola
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBorda = new System.Windows.Forms.PictureBox();
            this.picturePokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBorda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBorda
            // 
            this.pictureBorda.BackColor = System.Drawing.Color.Transparent;
            this.pictureBorda.Image = global::PokedexAPI.Properties.Resources.bordaPokebolaComFundo;
            this.pictureBorda.Location = new System.Drawing.Point(-18, -9);
            this.pictureBorda.Name = "pictureBorda";
            this.pictureBorda.Size = new System.Drawing.Size(157, 139);
            this.pictureBorda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBorda.TabIndex = 9;
            this.pictureBorda.TabStop = false;
            // 
            // picturePokemon
            // 
            this.picturePokemon.BackColor = System.Drawing.Color.Silver;
            this.picturePokemon.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/254.png";
            this.picturePokemon.Location = new System.Drawing.Point(-2, -8);
            this.picturePokemon.Name = "picturePokemon";
            this.picturePokemon.Size = new System.Drawing.Size(164, 148);
            this.picturePokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picturePokemon.TabIndex = 10;
            this.picturePokemon.TabStop = false;
            // 
            // pokebola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBorda);
            this.Controls.Add(this.picturePokemon);
            this.Name = "pokebola";
            this.Size = new System.Drawing.Size(122, 119);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBorda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBorda;
        private System.Windows.Forms.PictureBox picturePokemon;
    }
}
