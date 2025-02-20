using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _2025nyulobjektumok
{
    internal class Program
    {
        static List<Nyul> lista = new List<Nyul>();
        static void Main(string[] args)
        {

            Fajlbeolvasas();
            Console.ReadLine();
        }
        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("nobel.csv");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(';');
                Nyul sv = new Nyul(Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), Convert.ToInt32(st[2]));
                lista.Add(sv);
            }
            f.Close();
        }
    }
}
