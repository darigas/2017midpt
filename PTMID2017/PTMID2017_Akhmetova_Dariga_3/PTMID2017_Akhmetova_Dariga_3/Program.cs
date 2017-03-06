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
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Press 1 to move the train");
            string b = Console.ReadLine();
            if (b == "1")
            {
                Console.Clear();
                Train train = new Train();
                Thread t = new Thread(new ThreadStart(train.Move));
                t.Start();
            }
        }
    }
}
