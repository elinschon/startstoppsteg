using System;

namespace startstoppsteg
{
    class Program
    {
        static int Input(string prompt)
        {
            bool inmatat = false;
            int number = 0;

            while (!inmatat)
            {
                Console.WriteLine(prompt);
                inmatat = int.TryParse(Console.ReadLine(), out number);

                if (!inmatat)
                {
                    Console.WriteLine("Ange ett heltal, tack!");
                }
            }

            return number;
        }
        static void Main(string[] args)
        {
            int start = 0;
            int stop = 0;
            int step = 0;

            start = Input("Ange ett tal för START: ");

            while (stop < start)
            {
                stop = Input("Ange ett tal för STOPP: ");
                if (stop < start)
                {
                    Console.WriteLine("Stopp måste vara högre än start, pucko.");
                }
            }            

            step = Input("Ange ett tal för STEG: ");

            for (int i = start; i < stop; i+= step)
            {
                Console.WriteLine(i);
            }
        }
    }
}
