using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> aList = new List<int>() { 1, 2, 3, 4 };

            int[] array = new int[10];
            array.DefaultIfEmpty();
        }
    }
}
