using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace FormListaReproduccionG3
{
    public partial class Form1 : Form
    {
        private Musica musica;
        private ArrayList canciones;
        public Form1()
        {
            InitializeComponent();
            musica= new Musica("","","");
            listReproduccion.Items.Add(musica.Cancion);
            canciones = new ArrayList();
            canciones.Add(musica);
        }
        private void ListaCanciones()
        {
            canciones.Add(new Musica("Hit me","Molotov", " Dance and dense denso"));
            canciones.Add(new Musica("La parte de adelante ","Los Fabulosos Cadillac"," Lo esencial de los Fabulosos Cadillac"));
            canciones.Add(new Musica("Monsters ", "Starset ", "Vessels"));
            canciones.Add(new Musica("Funky town", "Lipps Inc", "Club Classics"));
            canciones.Add(new Musica("Ramito de violetas", "Mi Banda El Mexicano", "Grupo el mexicano"));
        }

        private void listReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAlbum.Text = musica.Album;
            lbArtista.Text = musica.Artista;
            lbCancion.Text = musica.Cancion;
            try
            {
                musica = (Musica)canciones[listReproduccion.SelectedIndex];
            }
            catch(ArgumentOutOfRangeException )
            {

            }
            
            

            
        }

        private void cargarCancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCanciones();
            foreach (Musica musica in canciones  )
            {
                listReproduccion.Items.Add(musica.Cancion);
            }

        }
    }
}
