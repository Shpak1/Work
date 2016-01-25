using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics graph;
        Pen pen_back;
        Pen pen_force;
        Move_Circle [] circles;
        int step = 100;
        Random rnd = new Random();
        int padding = 50;
        int size = 40;
        int radius = 10;
        int number = 0;
        Brush brush_back;
        Brush brush_fore;

        int[,] coords = {
            {0,0},{1,0},{2,0},
            {0,1},{1,1},{2,1},
            {0,2},{2,1},{2,2}
        };
        int[,] balls =
        {
            {4, 4, 4, 4, 4, 4 }, //1
            {2, 2, 2, 6, 6, 6 }, //2
            {2, 2, 4, 4, 6, 6 }, //3
            {2, 2, 0, 8, 6, 6 }, //4
            {4, 2, 0, 8, 6, 4 }, //5
            {3, 2, 0, 8, 6, 5 }, //6
        };

        public Form1()
        {
            InitializeComponent();
            InitGraph();
            Initcircles();
            drow_circle(brush_fore, circles);
        }
        public void InitGraph()
        {
            bmp = new Bitmap(Box.Width, Box.Height);
            graph = Graphics.FromImage(bmp);
            pen_force = new Pen(Color.Black);
            pen_back = new Pen(Color.White);
            brush_back = new SolidBrush(pen_back.Color);
            brush_fore = new SolidBrush(pen_force.Color);
            graph.Clear(pen_back.Color);
            graph.DrawRectangle(pen_force, 
                padding - 2*radius, 
                padding - 2*radius, 
                size * 2 + 4 * radius, 
                size * 2 + 4 * radius);
            Box.Image = bmp;

        }
        public void Initcircles()
        {
            circles = new Move_Circle[6];
            for(int j = 0; j < 6;j++)
                circles[j] = new Move_Circle(
                    size*coords[4,0], 
                    size*coords[4,1], 
                    radius);
        }

        public void move_circles(int number)
        {
            for (int j = 0; j < 6; j++)
                circles[j].MoveTo(
                    size * coords[balls[number - 1, j], 0],
                    size * coords[balls[number - 1, j], 1]);

        }

        public void drow_circle( Brush brush, Circle circle)
        {
            graph.FillEllipse(brush,
                                   circle.x - circle.radius + padding, 
                                   circle.y - circle.radius + padding, 
                                   circle.radius * 2, 
                                   circle.radius * 2);

        }
        public void drow_circle(Brush brush, Circle[] circles)
        {
            foreach (Circle c in circles)
                drow_circle(brush, c );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nr;
            do
                nr = rnd.Next(1, 7);
            while (nr == number);
            number = nr;
            move_circles(number);
            step = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (step >= 100)
                return;
            step+=20;
            for (int j = 0; j < 6; j++)
            {
                drow_circle(brush_back, circles[j]);
                circles[j].step(step);
                drow_circle(brush_fore, circles[j]);
            }
            Box.Image = bmp;
        }
    }
}
