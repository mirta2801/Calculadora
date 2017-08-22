using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora_6a.Libreria;

namespace calculadora_6A.windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculadora_6a.Libreria.metodos misMetodos = new Calculadora_6a.Libreria.metodos();
            MessageBox.Show(misMetodos.saludo());
        }
    }
}
