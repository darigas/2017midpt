using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace PTMID2017_Akhmetova_Dariga_3
{
    public class Train
    {
        public string sign;
        public int dx;
        public int dy;

        public List<Point> train = new List<Point>();
        public ConsoleColor color;
        public void Draw()
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < 1000; ++i)
            {
                Console.SetCursorPosition(train[i].x, train[i].y);
                train[i].x = 0;
                Console.Write(sign);
            }
        }
        public Train()
        {
            color = ConsoleColor.Magenta;
            this.sign = "***0";
            this.train.Add(new Point(0, 0));
        }
        public void Move()
        {
            while (true)
            {
                Draw();
                Thread.Sleep(2000);
                Draw();
                //Console.WriteLine("**0");
            }
        }
    }
}
