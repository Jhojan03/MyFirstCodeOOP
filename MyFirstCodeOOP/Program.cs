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

                Console.WriteLine("Enter day: ");
                string _dayIn = Console.ReadLine();

                var dateObject = new Date(Int32.Parse(_yearIn), Int32.Parse(_monthIn), Int32.Parse(_dayIn));
                Console.WriteLine(dateObject);

                Console.WriteLine("********Testing latest implementation********");

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = Convert.ToInt32(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    BirthDate = new Date(Convert.ToInt32(_yearIn), Convert.ToInt32(_monthIn), Convert.ToInt32(_dayIn)),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive = Convert.ToBoolean(Console.ReadLine()),
                    Salary = Convert.ToDecimal(Console.ReadLine())
                };

                Console.WriteLine(salaryEmployee);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
