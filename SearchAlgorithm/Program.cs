using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        //Arrray to be searched
        int[] arr = new int[20];
        //Number of elements in the array
        int n;
        //Get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elemnts in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elemnts.\n");
            }
            //Accept array elements
            Console.Writeline("");
            Console.Writeline("---------------------");
            Console.Writeline("Enter array elements ");
            Console.Writeline("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                 // accept the number to be searched 
                 Console.Write("\nenter element want you to search :");
                 int item = Convert.ToInt32(Console.ReadLine());

                // apply binary search


}
