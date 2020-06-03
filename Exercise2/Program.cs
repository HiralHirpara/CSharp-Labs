using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------- Second program --------------------------
            Console.WriteLine("Enter list");
            var list = Console.ReadLine().Split();
            var accending = 1; var decending = 1;
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (int.Parse(list[i]) >= int.Parse(list[i + 1]))
                {
                    decending++;
                }
                else
                {
                    accending++;
                }
            }
            if (accending == list.Length || decending == list.Length)
            {
                Console.WriteLine("Your list is sorted.");
            }
            else
            {
                Console.WriteLine("Your list is not sorted.");
            }
        }
    }
}
