using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        Shape currentShape = Shape.Free;
        Graphics g;
        Pen p = new Pen(Color.Black, 1);
        Point startLocation;
        Point currentLocation;
        Point endLocation;
        GraphicsPath gp = new GraphicsPath();
        Queue<Point> q=new Queue<Point>();
        Color Origin;
        Color fillcolor;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            p.Width = (float)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Free;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Line;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                p.Color = cd.Color;
                button6.BackColor = cd.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startLocation = e.Location;
            if (currentShape == Shape.Fill)
            {
                Origin = bmp.GetPixel(e.Location.X, e.Location.Y);
                FillRegion(e.Location);
            }   
        }
        private void Step(Point pp)
        {
            if (pp.X < 0) return;
            if (pp.Y < 0) return;
            if (pp.X >= pictureBox1.Width) return;
            if (pp.Y >= pictureBox1.Height) return;
            if (bmp.GetPixel(pp.X, pp.Y) != Origin) return;
            bmp.SetPixel(pp.X, pp.Y, p.Color);
            q.Enqueue(pp);
        }
        private void FillRegion(Point pp)
        {
            q.Enqueue(pp);
            while (q.Count > 0)
            {
                Point cur = q.Dequeue();
                Step(new Point(cur.X, cur.Y + 1));
                Step(new Point(cur.X + 1, cur.Y));
                Step(new Point(cur.X - 1, cur.Y));
                Step(new Point(cur.X, cur.Y - 1));
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            g.DrawPath(p, gp);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            switch (currentShape)
            {
                case Shape.Free:
                    g.DrawLine(p, startLocation, e.Location);
                    startLocation = e.Location;
                    break;
                case Shape.Line:
                    currentLocation = e.Location;
                    gp.Reset();
                    gp.AddLine(startLocation, currentLocation);
                    break;
                case Shape.Triangle:
                        currentLocation = e.Location;
                        gp.Reset();
                        Point[] points = new Point[3];
                        if (startLocation.Y < currentLocation.Y)
                        {
                            points[0] = new Point((currentLocation.X - startLocation.X) / 2 + startLocation.X, startLocation.Y);
                            points[1] = new Point(startLocation.X, currentLocation.Y);
                            points[2] = new Point(currentLocation.X, currentLocation.Y);
                        }
                        else
                        {
                            points[0] = new Point(startLocation.X, startLocation.Y);
                            points[1] = new Point(currentLocation.X, startLocation.Y);
                            points[2] = new Point((currentLocation.X - startLocation.X) / 2 + startLocation.X, currentLocation.Y);
                        }
                        gp.AddPolygon(points);
                        break;
                case Shape.Rectangle:
                    currentLocation = e.Location;
                        gp.Reset();
                        int width = 0;
                        int height = 0;
                        if (startLocation.Y < currentLocation.Y)
                        {
                            width = (int)Math.Sqrt((startLocation.X - currentLocation.X) * (startLocation.X - currentLocation.X));
                            height = (int)Math.Sqrt((startLocation.Y - currentLocation.Y) * (startLocation.Y - currentLocation.Y));
                        }
                        else
                        {
                            width = (int)Math.Sqrt((startLocation.X - currentLocation.X) * (startLocation.X - currentLocation.X));
                            height = (int)Math.Sqrt((startLocation.Y - currentLocation.Y) * (startLocation.Y - currentLocation.Y));
                        }
                        gp.AddRectangle(new Rectangle(startLocation.X, startLocation.Y, width, height));
                        break;
                case Shape.Ellipse:
                    currentLocation = e.Location;
                    gp.Reset();
                    gp.AddEllipse(startLocation.X, startLocation.Y, currentLocation.X - startLocation.X, currentLocation.Y - startLocation.Y);
                    break;
            }
            pictureBox1.Refresh();
            toolStripLabel1.Text = string.Format("X:{0},Y:{1}", e.X, e.Y);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(p, gp);
        }

        private void triangle_click(object sender, EventArgs e)
        {
            currentShape = Shape.Triangle;
            //pictureBox1.Cursor = Cursor.Size;
        }

        private void rectangle_click(object sender, EventArgs e)
        {
            currentShape = Shape.Rectangle;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Fill;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Ellipse;
        }

        private void save_click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //if (System.IO.File.Exists(sfd.FileName))
                //  System.IO.File.Delete(sfd.FileName);

                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void open_click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap newimage = new Bitmap(ofd.FileName);
                Bitmap cloneimage = newimage.Clone() as Bitmap;
                newimage.Dispose();
                pictureBox1.Image = cloneimage;
                g = Graphics.FromImage(pictureBox1.Image);
            }
        }

        private void pictureBox1MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private Random _rnd = new Random();

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        /*private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int radius = 15;
            using (Graphics g = this.CreateGraphics())
            {
                for (int i = 0; i < 100; ++i)
                {
                    double theta = _rnd.NextDouble() * (Math.PI * 2);
                    double r = _rnd.NextDouble() * radius;

                    double x = e.X + Math.Cos(theta) * r;
                    double y = e.Y + Math.Sin(theta) * r;

                    g.DrawEllipse(Pens.Black, new Rectangle((int)x - 1, (int)y - 1, 1, 1));
                }
            }
        }*/
    }
    enum Shape { Free, Line, Ellipse, Rectangle, Triangle, Pipetka, Fill };
}
