using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animal = { "Zebra", "Ant", "Owl", "Lion", "Tiger" };
            string[] animals = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] places = { "Africa", "New Zealand", "Jamaica", "India" };
            //using for loop

            for (int i = 0; i < animal.Length; i++)             
            {
                Console.WriteLine(animal[i]);
            }
       //using foreach loop
            Console.WriteLine("\n Using foreach loop ");

            foreach (string i in animal)
            {
                Console.WriteLine(i);
            }
         //using dowhile loop
            Console.WriteLine("\n Using dowhile loop ");
            int j = 0;
            do
            {
               Console.WriteLine(animal[j]);
                j++;
            } while (j < animal.Length);
            
          //using foreach loop
            Console.WriteLine("\n Using while loop ");
            int k=0;
            while (k < animal.Length)
            {
                Console.WriteLine(animal[k]);
                k++;
            }
            //sorting an array alphabetically
            Console.WriteLine("\n Sorted array alphabetically");
            Array.Sort<string>(animal);
            foreach(string l in animal)
            {
                Console.WriteLine(l);
            }

            Console.WriteLine("\n Sorted array alphabetically animals");
            Array.Sort<string>(animals);
            foreach (string l in animals)
            {
                Console.WriteLine(l);
            }

            Console.WriteLine("\n Sorted array alphabetically palaces");
            Array.Sort<string>(places);
            foreach (string l in places)
            {
                Console.WriteLine(l);
            }

        }
    }
}
