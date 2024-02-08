using System.Diagnostics;

namespace Windows_Sim
{
    public partial class Escritorio : Form
    {
        private Point panelMouseDownLocation;
        public Escritorio()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdministradorDeTareas administrador = new AdministradorDeTareas();
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
            //process.start("c:\\program files\\google\\chrome\\application\\chrome.exe");
            Navegador navegador = new Navegador();
            navegador.Show();
        }
    }
}
