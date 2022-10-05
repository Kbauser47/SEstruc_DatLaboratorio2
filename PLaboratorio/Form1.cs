using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLaboratorio
{
    public partial class Form1 : Form
    {
        public Pila1 p = new Pila1();
        public Form1()
        {
            InitializeComponent();
        }

        private void btninser_Click(object sender, EventArgs e)
        {
            string x = txtnum.Text;
            if (p.Llena())
                MessageBox.Show("Error: La pila esta llena");
            else
            {
                p.Insertar(x);
                listBox1.Items.Add(x);
            }

        }
        private void btnelimina_Click(object sender, EventArgs e)
        {
            string x;
            if (p.Vacia())
                MessageBox.Show("Error: La pila de elemento esta VACIA");
            else
            {
                x = p.Eliminar();
                listBox1.Items.Remove(x);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
