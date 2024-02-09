using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Windows_Sim
{
    public partial class Escritorio : Form
    {
        private Point panelMouseDownLocation;
        List<DataCPUProcesos> listaProcesos = new List<DataCPUProcesos>();
        AdministradorDeTareas administrador;
        bool menuClicked = false;

        public Escritorio()
        {
            InitializeComponent();
            listaProcesos.Add(new DataCPUProcesos("Admin Tareas", "0.1%"));
            administrador = new AdministradorDeTareas(listaProcesos);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.WindowState = FormWindowState.Maximized;


        }
        public List<DataCPUProcesos> listadProcesos
        {
            get { return listaProcesos; }
            set { listaProcesos = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!administrador.IsDisposed)
            {
                administrador.Show();
            }
            else
            {
                listaProcesos.Add(new DataCPUProcesos("Admin Tareas", "0.1%"));
                administrador = new AdministradorDeTareas(listaProcesos);

                administrador.indexProcess = listadProcesos.Count - 1;
                administrador.Show();
            }

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
            listaProcesos.Add(new DataCPUProcesos("Navegador", "0.1%"));

            administrador.listadProcesos = listaProcesos;

            Navegador navegador = new Navegador();
            navegador.indexProcess = listadProcesos.Count - 1;
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

    }
}
