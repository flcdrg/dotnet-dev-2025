namespace CSDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            var firstName = "John";
            person.Name = firstName;
            person.Age = 30;

            for (int i = 0; i < 10; i++)
            {
                person.Age++;
                Console.WriteLine($"Age: {person.Age}");
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
