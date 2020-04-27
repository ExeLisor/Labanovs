using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laban1
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NOD evklid = new NOD();
            evklid.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zenon zenon = new Zenon();
            zenon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Algs min = new Algs();
            min.Show();
        }
    }
}
