using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times_table
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entrez un nombre pour connaître sa table de multiplication : ");

            try
            {
                int numInput = Convert.ToInt32(Console.ReadLine());

                for(int i = 1; i <= 10; i++) {
                    int result = i * numInput;
                    Console.WriteLine($"{i} * {numInput} = {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            }


            Console.ReadLine();

        }
    }
}
