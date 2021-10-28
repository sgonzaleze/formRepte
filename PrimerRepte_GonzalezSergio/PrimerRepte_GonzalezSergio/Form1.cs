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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitControl_Click(object sender, EventArgs e)
        {

        }

        private void selectControl_Click(object sender, EventArgs e)
        {
            directoryForm f = new directoryForm();

            f.Show();
        }
    }
}
