using System;
using System.Collections;
using System.Collections.Generic;
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

                Console.WriteLine("Type your ID");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                string firstname = Console.ReadLine();

                Console.WriteLine("Type your last name");
                string lastname = Console.ReadLine();

                Console.WriteLine("Are you active?");
                bool isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your salary");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    LastName = lastname,
                    BirthDate = new Date(Convert.ToInt32(_yearIn), Convert.ToInt32(_monthIn), Convert.ToInt32(_dayIn)),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive = isActive,
                    Salary = salary
                };

                //Console.WriteLine(salaryEmployee);

                Console.WriteLine("");

                Console.WriteLine("********************");
                Console.WriteLine("*Commision Employee*");
                Console.WriteLine("********************");

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                firstname = Console.ReadLine();

                Console.WriteLine("Type your last name");
                lastname = Console.ReadLine();

                Console.WriteLine("Are you active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your commision percentage");
                float commisionPercentege = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your sales");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                Employee commisionEmployee = new CommisionEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    LastName = lastname,
                    BirthDate = new Date(Convert.ToInt32(_yearIn), Convert.ToInt32(_monthIn), Convert.ToInt32(_dayIn)),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive = isActive,
                    ComissionPercentage = commisionPercentege,
                    Sales = sales
                };

                //Console.WriteLine(commisionPercentege);

                Console.WriteLine("");

                Console.WriteLine("********************");
                Console.WriteLine("*Contractor Employee*");
                Console.WriteLine("********************");

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                firstname = Console.ReadLine();

                Console.WriteLine("Type your last name");
                lastname = Console.ReadLine();

                Console.WriteLine("Are you active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your number of hours");
                float hours = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your value per hour");
                decimal hourValue = Convert.ToDecimal(Console.ReadLine());

                Employee contractorEmployee = new ContractorEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    LastName = lastname,
                    BirthDate = new Date(Convert.ToInt32(_yearIn), Convert.ToInt32(_monthIn), Convert.ToInt32(_dayIn)),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive = isActive,
                    Hours = hours,
                    HourValue = hourValue
                };

                //Console.WriteLine(contractorEmployee);

                Console.WriteLine("");

                Console.WriteLine("*****************************");
                Console.WriteLine("*base and commision Employee*");
                Console.WriteLine("*****************************");

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                firstname = Console.ReadLine();

                Console.WriteLine("Type your last name");
                lastname = Console.ReadLine();

                Console.WriteLine("Are you active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your commision percentage");
                commisionPercentege = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your sales");
                sales = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter your salary base");
                decimal salaryBase = Convert.ToDecimal(Console.ReadLine());

                Employee baseCommisionEmployee = new BaseCommisionEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    LastName = lastname,
                    BirthDate = new Date(Convert.ToInt32(_yearIn), Convert.ToInt32(_monthIn), Convert.ToInt32(_dayIn)),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive = isActive,
                    ComissionPercentage = commisionPercentege,
                    Sales = sales,
                    Base = salaryBase
                };

                //Console.WriteLine(baseCommisionEmployee);

                ICollection<Employee> employees = new List<Employee>()
                {
                    salaryEmployee, 
                    commisionEmployee, 
                    contractorEmployee, 
                    baseCommisionEmployee
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
