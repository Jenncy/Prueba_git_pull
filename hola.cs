using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_git_pull
{
    public partial class hola : Form
    {
        public hola()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOla");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hola2 hola = new hola2();
            hola.Show();
        }
    }
}
