namespace ToStringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++ )
            {
                Console.WriteLine("Enter a person name:");
                persons[i] = new Person() { Name = Console.ReadLine() };
            }
            Console.WriteLine("---------------------------------------------");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            Console.ReadKey();
        }


    }

    public class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Hi my name is {Name}!";
        }
    }
}
