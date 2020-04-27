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
    public partial class Zenon : Form
    {
        public Zenon()
        {
            InitializeComponent();
        }
        float x1 = 0;
        float x2 = 100;
        float v1 = 0;
        float v2 = 0;
        float t = 0;
        
        //x1 и v1 - координата, скорость Зенона, x2 и v2 - координата, скорость черепахи, 
        //t - время
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(speedZenon.Text, out v1);
        } //вводим значение скорости Зенона
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(speedTort.Text, out v2);
        } //вводим значение скорости черепахи    
        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, x1, 100, 50, 50);
            e.Graphics.FillEllipse(Brushes.Green, x2, 100, 50, 50);
        }//рисуем Зенона и черепаху
         //реальность   
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 10;
        }  //запуск таймера1 с интвервалом в 10 мс.
        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            x1 = v1 * t;
            x2 = (v2 * t) + 100; // +100 для того, чтобы визуально черепаха была поотдаль от Зенона
            pictureBox1.Refresh(); // обновляем изображение, чтобы мы могли набюдать движение
        } //обычно прямолинейное движение
          //реальность   
          //аппорий
        private void timer2_Tick(object sender, EventArgs e)
        {
           float ds = x2 - x1; //считаем расстояние между зеноном и черепахой
            t = ds / v1;  //время за которое Зенон догонит черепаху
           float dt = t / 100; 
            x1 += v1 * dt;
            x2 += v2 * dt;
            pictureBox1.Refresh();
        } //необычное прямолинейное движение
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer2.Interval = 10;
        } //запуск таймера2 с интвервалом в 10 мс.          
        private void Stop_Click(object sender, EventArgs e)
        {
            x1 = 0;
            x2 = 100;
            t = 0;
            timer1.Stop();
            timer2.Stop();
            pictureBox1.Refresh();
        }
        //аппорий



    }
}
