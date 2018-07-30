using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars
{
    class Program
    {
        static int  WrongCharacters (string signal)
        {
            string sos = "SOS";
            int count = 0;

                for (int i = 0; i < signal.Length; i++)
            {
                if (signal[i] != sos[i % 3]) count++;
            }
            return count;
        }
               
        static void Main(string[] args)
        {
           Console.Clear();
           Console.Write("Input SOS message:");
           string signal = Console.ReadLine();
           int number = WrongCharacters(signal);
           Console.WriteLine($"Number of changed characters is : {number}");
           Console.ReadLine();
           
        }
    }
}
