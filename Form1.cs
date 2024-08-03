

namespace Prueba
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;


    public partial class GestionTareasPendientes : Form
    {
        public GestionTareasPendientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String tarea = txtTarea.Text;
            lstTareas.Items.Add(tarea);
            txtTarea.Clear();

        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lstTareas.Items.Clear();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
           
            if (lstTareas.SelectedIndex != -1)
            {
               
                lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para eliminar.");
            }
        }

      
    }
}
