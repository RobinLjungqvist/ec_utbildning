using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18
{
    class Registry
    {
        List<Employee> employeeRegistry = new List<Employee>();
        Logger employeeLog = new Logger();

        public void AddEmployeeToRegistry()
        {

            Console.Write("Please enter employee first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter employee last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter employee Social Security Number(YYMMDDXXXX): ");
            string socNR = validateSocNR();

            Console.Write("Please enter employee hourly wage: ");
            int hourlyWage;
            string wage = Console.ReadLine();
            try
            {
                hourlyWage = int.Parse(wage);


                Employee TempEmp = new Employee(firstName, lastName, socNR, hourlyWage);
                employeeRegistry.Add(TempEmp);
                DateTime thisInstant = DateTime.Now;
                string logMessage = string.Format($"Name: {TempEmp.FullName} " +
                                                  $"\r\nSSN: {TempEmp.SocialSecurityNumber} has been added." +
                                                  $"\r\nTime: {thisInstant.ToString()}");
                employeeLog.Log(logMessage);
                Console.WriteLine(logMessage);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


        }

        public void RemoveEmployeeFromRegistry(string input)
        {
            for (int i = 0; i < employeeRegistry.Count; i++)
            {
                if (employeeRegistry[i].SocialSecurityNumber == input)
                {
                    DateTime thisInstant = DateTime.Now;
                    string logPostEntry = string.Format($"Name: {employeeRegistry[i].FullName} "+
                                                        $"\r\nSSN: {employeeRegistry[i].SocialSecurityNumber} has been removed." +
                                                        $"\r\nTime: {thisInstant.ToString()} ");
                    employeeLog.Log(logPostEntry);
                    Console.WriteLine(logPostEntry);
                    employeeRegistry.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }
        public void ShowRegistry()
        {
            if (employeeRegistry.Count != 0)
            {
                foreach (Employee item in employeeRegistry)
                {
                    item.PrintEmployee();
                } 
            }
            else
            {
                Console.WriteLine("The registry is empty.");
            }
        }
        public List<Employee> FilterRegistry()
        {
            Console.WriteLine("Please enter the birth year you want to sort after with two digits.");
            List<Employee> newList = new List<Employee>();
            var input = Console.ReadLine();
            if (input.Length == 2 && Char.IsDigit(input[0]) && Char.IsDigit(input[1]))
            {
                if (employeeRegistry.Count != 0)
                {
                    foreach (Employee item in employeeRegistry)
                    {
                        if (item.SocialSecurityNumber.StartsWith(input))
                        {
                            newList.Add(item);
                            
                        }
                        
                    }
                } 
            }
            else
            {
                Console.WriteLine("You entered more than two digits or your input wasn't digits.");
                return newList;
            }
            return newList;

        }
        public void PrintFilteredRegistry(List<Employee> listInput)
        {
            if (listInput.Count != 0)
            {
                foreach (var employee in listInput)
                {
                    employee.PrintEmployee();
                }
            }
            else
            {
                Console.WriteLine("Search yielded no results.");
            }
        }

        public string validateSocNR()
        {
            string input = Console.ReadLine();
            long result = 0;
            if(long.TryParse(input, out result))
            {
                if (input.Length == 10)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Your Social security number must be 10 digits.");
                    return validateSocNR();
                }
            }
            else
            {
                Console.WriteLine("Your Social security number must be digits.");
                return validateSocNR();
            }
            return string.Empty;
        }

    }
}
