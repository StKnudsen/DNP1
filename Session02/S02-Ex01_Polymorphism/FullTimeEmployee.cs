namespace S02_Ex01_Polymorphism
{
    public class FullTimeEmployee : Employee
    {
        public double MonthlySalary;

        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            MonthlySalary = monthlySalary;
        }

        public override double GetMonthlySalary()
        {
            return MonthlySalary;
        }
    }
}