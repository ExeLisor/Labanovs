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
    public partial class NOD : Form
    {
        public NOD()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int nod = 0;
            int i = 1;
            a = Convert.ToInt32(firstnum.Text);
            b = Convert.ToInt32(secondnum.Text);            
            while (i < (a * b))
            {
                if (a % i == 0 && b % i == 0)
                {
                    nod = i;                  
                }
                i++;
            }
            Result.Text = Convert.ToString(nod);
        }
    }
}
       
    

