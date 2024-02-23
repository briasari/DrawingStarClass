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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);

            int x = 100;
            int y = 50;

            float size = Convert.ToSingle(200);
            float scale = size / 206;

            PointF[] starPoints = new PointF[10];
            starPoints[0] = new PointF(0 * scale + x, 74 * scale + y);
            starPoints[1] = new PointF(79 * scale + x, 74 * scale + y);
            starPoints[2] = new PointF(103 * scale + x, 0 * scale + y);
            starPoints[3] = new PointF(127 * scale + x, 74 * scale + y);
            starPoints[4] = new PointF(206 * scale + x, 74 * scale + y);
            starPoints[5] = new PointF(142 * scale + x, 122 * scale + y);
            starPoints[6] = new PointF(166 * scale + x, 196 * scale + y);
            starPoints[7] = new PointF(103 * scale + x, 150 * scale + y);
            starPoints[8] = new PointF(39 * scale + x, 196 * scale + y);
            starPoints[9] = new PointF(64 * scale + x, 122 * scale + y);

            e.Graphics.DrawPolygon(blackPen, starPoints);
            e.Graphics.DrawRectangle(blackPen, x, y, size, size); // to test position and size
        }
    }
}
