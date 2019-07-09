using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YulianTest.models;

namespace YulianTest
{
    
    class Program
    {
        public static double AverageSalaryFirstTen(List<Employee> emps, int limit)
        {
            double SalarySum = new double();

                

            for (int i = 0; i < limit; i++)
            {
                SalarySum += double.Parse(emps[i].employee_salary);
            }

            return SalarySum / limit;

        }

        public static double HighestSalary(List<Employee> emps, int limit)
        {
            double CurrentHighest = new double();
            CurrentHighest = 0;


            for (int i = 0; i < limit; i++)
            {
                var CurrentEmpSalary = double.Parse(emps[i].employee_salary);

                if ( CurrentEmpSalary > CurrentHighest) { CurrentHighest = CurrentEmpSalary; }
            }

            return CurrentHighest;



        }


        static void Main(string[] args)
        {



            const string Url = "http://dummy.restapiexample.com/api/v1/employees";

            var json = new WebClient().DownloadString(Url);


            var employees = JsonConvert.DeserializeObject<List<Employee>>(json);



            //var status = employees[0].id;
            Console.WriteLine(" id |   Name        |          Salary   |  Age    ");
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < 10; i++)
            {
                StringBuilder SbName = new StringBuilder();
                StringBuilder SbSalary = new StringBuilder();

                var CurrentName = employees[i].employee_name;
                var CurrentSalary = employees[i].employee_salary;


                SbName.Append(CurrentName.PadRight(20));
                SbSalary.Append(CurrentSalary.PadRight(7));

                Console.Write(" {0}   ", employees[i].id);
                Console.Write(" {0}   ", SbName);
                Console.Write(" {0}   ", SbSalary);
                Console.Write(" {0}   ", employees[i].employee_age);
                Console.WriteLine("\n");


            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Salary Average is: {0}" , AverageSalaryFirstTen(employees, 10 ).ToString() );
            Console.WriteLine("Highest Salary is: {0}", HighestSalary(employees, 10 ).ToString());
            Console.ReadKey();


        }
    }
}
