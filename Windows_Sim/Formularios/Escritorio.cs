using System.Diagnostics;
using System.Runtime.InteropServices;
using Windows_Sim.Formularios;

namespace Windows_Sim
{
    public partial class Escritorio : Form
    {
        private Point panelMouseDownLocation;
        AdministradorDeTareas administrador;
        bool menuClicked = false;

        public Escritorio()
        {
            InitializeComponent();
            administrador = new AdministradorDeTareas();

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.WindowState = FormWindowState.Maximized;


        }


        private void label1_Click(object sender, EventArgs e)
        {

            administrador.Show();



        }

        private void panelAdmiTar_MouseDown(object sender, MouseEventArgs e)
        {
            panelMouseDownLocation = e.Location;
        }

        private void panelAdmiTar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Obtener el panel en el que se está haciendo clic
                Panel? panel = sender as Panel;
                // Calcular la nueva ubicación del panel basada en la diferencia entre la ubicación actual del mouse y la ubicación donde se presionó inicialmente
                panel!.Left += e.X - panelMouseDownLocation.X;
                panel.Top += e.Y - panelMouseDownLocation.Y;
            }
        }

        private void panelChrome_DoubleClick(object sender, EventArgs e)
        {



            Navegador navegador = new Navegador();
            navegador.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (menuClicked)
            {
                menuClicked = !menuClicked;
                panel2.Visible = menuClicked;

            }
            else
            {
                menuClicked = !menuClicked;
                panel2.Visible = menuClicked;
            }

        }

        private void Explorer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Explorer explorer = new Explorer();
            explorer.Show();
        }



        private void papelera_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Papelera papelera = new Papelera();
            papelera.Show();
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            EditorTexto editorTexto = new EditorTexto();
            editorTexto.Show();
        }

        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            Reproductor reproductor = new Reproductor();
            reproductor.Show();
        }
    }
}
