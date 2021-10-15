namespace S02_Ex01_Polymorphism
{
    public abstract class Employee
    {
        public string Name;
        public abstract double GetMonthlySalary();

        protected Employee(string name)
        {
            Name = name;
        }
    }
}