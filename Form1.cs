using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Deber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\descarga.jpg" );
            this.BackgroundImage = img;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var materia = Materia_text.Text;
            var tarea = tarea_text.Text;

            if (materia != "" && tarea !="") { 

                string cadena = materia + " " + tarea;

                Lista_tareas.Items.Add(cadena);
                LimpiarCajas();
                MessageBox.Show("Se agrego correctamente");


            }
            else
            {
                MessageBox.Show("Complete los Campos");
            }



          
        }
    
        public void LimpiarCajas() {
            tarea_text.Text = "";
            Materia_text.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Lista_tareas.SelectedIndex != -1)
            {
                DialogResult dialogResult= MessageBox.Show ("Esta seguro que quiere eliminar la tarea " ,"" , MessageBoxButtons.YesNo); 
                if (dialogResult == DialogResult.Yes)
                {
                    Lista_tareas.Items.RemoveAt(Lista_tareas.SelectedIndex);
                    Lista_tareas.Items.Remove(Lista_tareas.SelectedIndex);
                    MessageBox.Show("Se elimino con exito");
                }
                else
                {
                    MessageBox.Show("Se canceló con exito");
                }
            }
            else
            {
                MessageBox.Show("Operación invalida");
            }
        }
    }
}

