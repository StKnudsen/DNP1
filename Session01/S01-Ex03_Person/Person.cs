namespace S01_Ex03_Person
{
    public class Person
    {
        public string Name;

        public string Introduce()
        {
            // Building string with string interpolation $"..{Var}"
            return $"Hi, I am {Name}";
        }
    }
}