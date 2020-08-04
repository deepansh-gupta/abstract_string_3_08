using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string  ");
            string strA = Console.ReadLine();



            Console.WriteLine("Enter a string  ");
            string strB = Console.ReadLine();



            Console.WriteLine("-----------------------");



            Console.WriteLine("String A is: {0}", strA);
            Console.WriteLine("String B is: {0}", strB);
            string str;

            int i;
            Console.WriteLine("Enter your choice ");
            i = Convert.ToInt32(Console.ReadLine());


            switch (i)
            {
                case 1:
                    str = String.Concat(strA, strB);
                    Console.WriteLine("Concatenated string is: {0}", str);
                    break;
                //break;
                case 2:
                    Console.WriteLine("String Length of frist : " + strA.Length);
                    Console.WriteLine("String Length of frist : " + strB.Length);
                    break;
                //break;
                case 3:
                    Console.WriteLine("Substring of string A " + strA.Substring(2));
                    Console.WriteLine("Substring of string B " + strB.Substring(4));
                    break;



                //break;
                case 4:
                    Console.WriteLine(strA = strA.Replace('a', 'b'));
                    Console.WriteLine(strB = strB.Replace('c', 'd'));
                    break;
                //break;
                case 5:
                    Console.WriteLine(strA = strA.ToUpper());
                    Console.WriteLine(strB = strB.ToUpper());
                    break;
                //break;

                case 6:
                    Console.WriteLine(strA = strA.ToLower());
                    Console.WriteLine(strB = strB.ToLower());
                    break;

                case 7:
                    char[] arrA = { 'J', 'a' };
                    Console.WriteLine("String = " + strA);
                    Console.WriteLine("String (after trim) = " + strA.Trim(arrA));



                    char[] arrB = { 'F', 'a' };
                    Console.WriteLine("String = " + strB);
                    Console.WriteLine("String (after trim) = " + strA.Trim(arrB));
                    
                break;
                case 8:
                    char[] separator = { ':', ' ' };
                    string[] words = strA.Split(separator);
                    foreach (string word in words)
                    {
                        Console.WriteLine(word);
                    }



                    char[] separator1 = { ';', ' ' };
                    string[] words1 = strB.Split(separator);
                    foreach (string word in words1)
                    {
                        Console.WriteLine(word);
                    }
                     break;
                case 9:

                    break;



                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
