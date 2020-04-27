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
    public partial class Algs : Form
    {
        public Algs()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
                Random rnd = new Random();
                int temp;
                int[] numbers = new int[5];
                for (int i = 0; i < numbers.Length; i++)
                {
                    temp = rnd.Next(100);
                    numbers[i] = temp;
                }
                foreach (int i in numbers)
                {
                    Random.Text = string.Join(", ", numbers);
                }
                
                Array.Sort(numbers);           
                for (int i = 0; i < numbers.Length; i++)
                {
                    ToMax.Text = string.Join(", ", numbers);
                }

                Array.Reverse(numbers);
                for (int i = 0; i < numbers.Length; i++)
                {
                ToMin.Text = string.Join(", ", numbers);                
                }
            Min.Text = Convert.ToString(numbers.Min());
                Max.Text = Convert.ToString(numbers.Max());

                Console.ReadLine();           
        }                   
    }
}

