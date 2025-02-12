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
        Point[] star = new Point[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            ///The following line of code demonstrates how to get input
            ///and convert it to a float value. Use this to help you in 
            ///Parts 2 - 4 where you need to get inputs from the 
            ///user and store them in float variables. This code is 
            ///not needed for Part 1.

            ///float size = Convert.ToSingle(sizeInput.Text); 
            
            Graphics g = this.CreateGraphics(); //for part 4 this gets moved to the custom methods.
            Pen blackPen = new Pen(Color.Black);

            float x = Convert.ToSingle(xInput.Text);
            float y = Convert.ToSingle(yInput.Text);

            DrawStar();

            //e.Graphics.DrawPolygon(star, star, blackPen);
            Refresh();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {

        }

        public void DrawStar(Pen starPen, float x, float y, float pixels)
        {
            star[0] = new Point(65, 0);
            star[1] = new Point(80, 50);
            star[2] = new Point(130, 50);
            star[3] = new Point(90, 80);
            star[4] = new Point(105, 130);
            star[5] = new Point(65, 100);
            star[6] = new Point(25, 130);
            star[7] = new Point(40, 80);
            star[8] = new Point(0, 50);
            star[9] = new Point(50, 50);
        }

    }
}
