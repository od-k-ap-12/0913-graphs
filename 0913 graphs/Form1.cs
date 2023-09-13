using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0913_graphs
{
    public partial class Form1 : Form
    {
        Pen pen;
        Pen pengrid;
        Bitmap bmp;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 5);
            pengrid = new Pen(Color.Black, 1);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image = bmp);
            g.DrawLine(pen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            g.DrawLine(pen, pictureBox1.Width / 2, pictureBox1.Height, pictureBox1.Width / 2, 0);
            for(int i = 0; i < 500; i+=10)
            {
                g.DrawLine(pengrid, 0, i, pictureBox1.Width, i);
                g.DrawLine(pengrid, i, pictureBox1.Height, i, 0);
            }
            g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 5);
            pengrid = new Pen(Color.Black, 1);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image = bmp);
            g.DrawLine(pen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            g.DrawLine(pen, pictureBox1.Width / 2, pictureBox1.Height, pictureBox1.Width / 2, 0);
            for (int i = 0; i < 500; i += 10)
            {
                g.DrawLine(pengrid, 0, i, pictureBox1.Width, i);
                g.DrawLine(pengrid, i, pictureBox1.Height, i, 0);
            }
            g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            if (comboBox1.SelectedIndex == 0)
            {
                for (int i = -250; i < 250; i++)
                {
                    g.FillEllipse(new SolidBrush(Color.Red), i * (-1), i, 5, 5);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                for (int i = -250; i < 250; i++)
                {
                    g.FillEllipse(new SolidBrush(Color.Red), i * (-1), -(i * i), 5, 5);
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                for (int i = -250; i < 250; i++)
                {
                    g.FillEllipse(new SolidBrush(Color.Red), i, -(i * i * i), 5, 5);
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                for (int i = 0; i < 250; i++)
                {
                    g.FillEllipse(new SolidBrush(Color.Red), i, -(Convert.ToInt32(Math.Sqrt(i))), 5, 5);
                }
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                for (int i = 0; i < 250; i++)
                {
                    g.FillEllipse(new SolidBrush(Color.Red), -i, -i, 5, 5);
                    g.FillEllipse(new SolidBrush(Color.Red), i, -i, 5, 5);
                }
            }

        }
    }
}
