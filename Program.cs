using System;

namespace CheckA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text:");
            string text = Console.ReadLine();
            bool check = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='a')
                {
                    check = true;
                    break;
                }
            }
            if (check == true)
            {
                Console.WriteLine("There is a symbol in the text");

            }
            else 
            {
                Console.WriteLine("a symbol is not found in the text");

            }
                
        }
    }
}
