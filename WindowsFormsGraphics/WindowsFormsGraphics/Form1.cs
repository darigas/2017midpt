using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush1 = new SolidBrush(Color.Black);
            Rectangle rect1 = new Rectangle(0, 0, 600, 500);
            e.Graphics.FillRectangle(brush1, rect1);
            Rectangle rect2 = new Rectangle(10, 10, 580, 480);
            SolidBrush brush2 = new SolidBrush(Color.SlateBlue);
            e.Graphics.FillRectangle(brush2, rect2);
            SolidBrush brush3 = new SolidBrush(Color.White);
            e.Graphics.FillEllipse(brush3, 60, 60, 30, 30);
            e.Graphics.FillEllipse(brush3, 400, 80, 30, 30);
            e.Graphics.FillEllipse(brush3, 90, 380, 30, 30);
            e.Graphics.FillEllipse(brush3, 280, 360, 30, 30);
            e.Graphics.FillEllipse(brush3, 280, 40, 30, 30);
            e.Graphics.FillEllipse(brush3, 530, 150, 30, 30);
            e.Graphics.FillEllipse(brush3, 480, 240, 30, 30);
            e.Graphics.FillEllipse(brush3, 500, 400, 30, 30);
            int x = 300;
            int y = 200;
            SolidBrush brush4 = new SolidBrush(Color.Green);
            Point[] points = {
                             new Point(x, y),
                             new Point(x+15, y-5),
                             new Point(x+20, y-20),
                             new Point(x+25, y-5),
                             new Point(x+40, y),
                             };
            Point[] pointz = {
                             new Point(x, y),
                             new Point(x+15, y+5),
                             new Point(x+20, y+20),
                             new Point(x+25, y+5),
                             new Point(x+40, y),
                             };
            e.Graphics.FillClosedCurve(brush4, pointz);
            e.Graphics.FillClosedCurve(brush4, points);
            Rectangle rect3 = new Rectangle(300, 250, 40, 50);
            SolidBrush brush5 = new SolidBrush(Color.Yellow);
            Pen pen1 = new Pen(Color.Yellow);
            e.Graphics.FillRectangle(brush5, rect3);
            Point [] pointsp = {
                                   new Point (300, 250),
                                   new Point (320, 230), 
                                   new Point (340, 250),
                               };
            e.Graphics.FillPolygon(brush5, pointsp);
        }
    }
}
