namespace S02_Ex01_Polymorphism
{
    public class PartTimeEmployee : Employee
    {
        public double HourlyWage;
        public int HoursPerMonth;

        public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth) : base(name)
        {
            HourlyWage = hourlyWage;
            HoursPerMonth = hoursPerMonth;
        }

        public override double GetMonthlySalary()
        {
            return HourlyWage * HoursPerMonth;
        }
    }
}