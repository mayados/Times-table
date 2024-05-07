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

            Console.Write("Enter a number to know its multiplication table : ");

            try
            {
                int numInput = Convert.ToInt32(Console.ReadLine());

                for(int i = 1; i <= 10; i++) {
                    int result = i * numInput;
                    Console.WriteLine($"{i} * {numInput} = {result}");
                }
            }
            catch (FormatException) 
            {
                Console.WriteLine("Please enter a whole number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too big or too small");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            }


            Console.ReadLine();

        }
    }
}
