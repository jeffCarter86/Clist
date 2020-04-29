using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        // Main Method 
        public static void Main()
        {

            List<int> list1 = new List<int>
            { 
  
            // list elements 
            1, 5, 6, 2, 4, 3

             };

            Console.WriteLine("Original List");

            foreach (int g in list1)
            {

                // Display Original List 
                Console.WriteLine(g);
            }

            foreach (int g in list1)
            {

                // Display sorted list 
                Console.WriteLine(g);
            }

            ListB<IComparer> gg = new ListB<IComparer>();


            Console.WriteLine("\nSort with a comparer:");

            // use of List<T>.Sort(IComparer<T>)  
            // method. The comparer is "gg" 
            list1.Sort(gg);

            foreach (int g in list1)
            {

                // Display sorted list 
                Console.WriteLine(g);

            }

            List<string> list2 = new List<string>();

            // list elements 
            list2.Add("A");
            list2.Add("I");
            list2.Add("G");
            list2.Add("B");
            list2.Add("E");
            list2.Add("H");
            list2.Add("F");
            list2.Add("C");
            list2.Add("J");
            list2.Add("D");

            Console.WriteLine("Original List");

            // Display Original List 
            foreach (string h in list2)
            {

                // Display Original List 
                Console.WriteLine(h);
            }

            // "ggg" is the object 
            ListB<IComparer> ggg = new ListB<IComparer>();

            Console.WriteLine("\nSort with a comparer:");

            // sort the list with a  
            // specified comparer "ggg" 
            list2.Sort(ggg);

            // Display sorted List 
            foreach (string h in list2)
            {

                // Display sorted list 
                Console.WriteLine(h);

            }

        }
    }
}


