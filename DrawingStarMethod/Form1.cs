using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        Pen blackPen= new Pen(Color.Black);
        List<Star> stars = new List<Star>();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 50; i++)
            {
                CreateStar();
            }
            
        }

        public void CreateStar()
        {
            int x = randGen.Next(0, this.Width);
            int y = randGen.Next(0, this.Height);
            int size = randGen.Next(10, 50);

            int r = randGen.Next(0, 256);
            int g = randGen.Next(0, 256);
            int b = randGen.Next(0, 256);

            Pen starPen = new Pen(Color.FromArgb(r, g, b));

            Star newStar = new Star(starPen, x, y, size);
            stars.Add(newStar);

        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            foreach (Star s in stars)
            {
                e.Graphics.DrawPolygon(s.starPen, s.starPoints);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void starTimer_Tick(object sender, EventArgs e)
        {
            foreach (Star s in stars)
            {
                s.Move();

                if (s.x > this.Width)
                {
                    s.x = 0 - (int)s.size;
                }

                if (s.y > this.Height)
                {
                    s.y = 0 - (int)s.size;
                }
            }

            Refresh();
        }
    }
}
