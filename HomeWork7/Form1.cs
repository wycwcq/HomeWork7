using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBoxPen();
        }
        public void ComboBoxPen()
        {
            comboBoxPen.Items.Add("Blue");
            comboBoxPen.Items.Add("Red");
            comboBoxPen.Items.Add("Black");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                //graphics = this.CreateGraphics();
                graphics = panel1.CreateGraphics();
                graphics.Clear(panel1.BackColor);
            }
            int deep = Convert.ToInt32(textBox1.Text);
            int leng = Convert.ToInt32(TextBoxLeng.Text);
            drawCayleyTree(deep, 300, 410, leng, -Math.PI / 2);
        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
            {
                return;
            }
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            per1 = Convert.ToDouble(textBoxPer1.Text);
            per2 = Convert.ToDouble(textBoxPer2.Text);
            th1 = Convert.ToDouble(trackBarth1.Value) * Math.PI / 180;
            th2 = Convert.ToDouble(trackBarth2.Value) * Math.PI / 180;
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            string color = Convert.ToString(comboBoxPen.Text);
            if (color == "Red")
            {
                graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
            }
            if (color == "Blue")
            {
                graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
            }
            if (color == "Black")
            {
                graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxPen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                //graphics = this.CreateGraphics();
                graphics = panel1.CreateGraphics();
                graphics.Clear(panel1.BackColor);
            }
            int deep = Convert.ToInt32(textBox1.Text);
            int leng = Convert.ToInt32(TextBoxLeng.Text);
            drawCayleyTree(deep, 300, 410, leng, -Math.PI / 2);
        }
    }
}
