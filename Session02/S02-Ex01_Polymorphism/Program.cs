using System;

namespace S02_Ex01_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Company DNNR = new Company();

            Employee Line = new FullTimeEmployee("Line", 50000);
            DNNR.HireNewEmployee(Line);
            Employee Tina = new FullTimeEmployee("Tina", 50000);
            DNNR.HireNewEmployee(Tina);
            Employee Frederik = new FullTimeEmployee("Frederik", 50000);
            DNNR.HireNewEmployee(Frederik);
            Employee Stefan = new PartTimeEmployee("Stefan", 500, 150);
            DNNR.HireNewEmployee(Stefan);

            Console.WriteLine(DNNR.GetMonthlySalaryTotal());
        }
    }
}