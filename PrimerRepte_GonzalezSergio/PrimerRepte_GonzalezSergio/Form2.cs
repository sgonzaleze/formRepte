using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerRepte_GonzalezSergio
{
    public partial class directoryForm : Form
    {
        BindingList<Fichero> ficheros2 = new BindingList<Fichero>();
        public directoryForm()
        {
            InitializeComponent();
        }
        public directoryForm(List<Fichero> ficheros)
        {
            InitializeComponent();
        }
       
        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            string ruteDirectory = string.Empty;

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                ruteDirectory = fbd.SelectedPath;
                label3.Text = fbd.SelectedPath;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormAñadir f = new FormAñadir(ficheros2);

            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);

           

        }



        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ficheros2;
            dataGridView1.Update();

       
            

        }

    }
}
