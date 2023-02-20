using System;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            
           try
            {
                Console.WriteLine("Enter year: ");
                string _yearIn = Console.ReadLine();

                Console.WriteLine("Enter month: ");
                string _monthIn = Console.ReadLine();

                Console.WriteLine("Enter month: ");
                string _dayIn = Console.ReadLine();

                var dateObject = new Date(Int32.Parse(_yearIn), Int32.Parse(_monthIn), Int32.Parse(_dayIn));
                Console.WriteLine(dateObject);


                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
