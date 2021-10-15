using System.Collections.Generic;

namespace S02_Ex01_Polymorphism
{
    public class Company
    {
        private List<Employee> Employees;
        
        public Company()
        { 
            Employees = new List<Employee>();
        }

        public double GetMonthlySalaryTotal()
        {
            double total = 0;

            foreach (Employee employee in Employees)
            {
                total += employee.GetMonthlySalary();
            }

            return total;
        }

        public void HireNewEmployee(Employee emp)
        {
            Employees.Add(emp);
        }
    }
}