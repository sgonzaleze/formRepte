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
    public partial class FormAñadir : Form
    {
        BindingList<Fichero> ficheros = new BindingList<Fichero>();

        String Id, Name;
        DateTime Date = DateTime.Now;

        public FormAñadir()
        {
            InitializeComponent();
        }


        public FormAñadir(BindingList<Fichero> ficheros2)
        {
            ficheros = ficheros2;
            InitializeComponent();
        }

        private void refrescarList()
        {

        }

        private void FormAñadir_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            if (radioButtonFile.Checked)
            {
                Fichero fichero = new Fichero(Id, Name, Date);

                fichero.Id = "fichero";
                fichero.Name = textBoxName.Text;
                fichero.Date = DateTime.Now;

                ficheros.Add(fichero);
            
            }else if (radioButtonDir.Checked)
            {
                Fichero directorio = new Fichero(Id, Name, Date);
                directorio.Id = "directorio";
                directorio.Name = textBoxName.Text;
                directorio.Date = DateTime.Now;
                ficheros.Add(directorio);

            }
            

          
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeProduct_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Name = textBoxName.Name;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonFile_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            refrescarList();

   
        }
    }
}
