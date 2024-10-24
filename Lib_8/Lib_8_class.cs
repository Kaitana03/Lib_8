using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_8
{
    internal class Lib_8_class
    {
        public int MaxNumber(int[] mas) 
        {
            Array.Sort(mas);
            return mas[mas.Length-1];
        }
        public int[] Create(in int x)
        {
            int n = 10;
            int[] mas = new int[n];
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(0,x);
            }
            return mas;

        }
    }
}
