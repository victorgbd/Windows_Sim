using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows_Sim.Formularios
{
    public partial class EditorTexto : Form
    {
        private string raiz = "raiz";
        string rutaCompleta = "";
        string filePath="";
        public EditorTexto()
        {
            InitializeComponent();
            bool exists = Directory.Exists(raiz); if (!exists) Directory.CreateDirectory(raiz);
            rutaCompleta = Path.Combine(Environment.CurrentDirectory, raiz);
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog() { InitialDirectory = rutaCompleta, Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*", FilterIndex = 1, RestoreDirectory = true })
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        filePath = openFileDialog1.FileName;
                        string fileContent = File.ReadAllText(filePath);

                        richTextBox1.Text = fileContent;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al leer el archivo: " + ex.Message);
                    }
                }
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (filePath.Length > 0)
            {
                try
                {
                    File.WriteAllText(filePath, richTextBox1.Text);
                    MessageBox.Show("El archivo se guardó exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
    }
}
