namespace GA_FieldsProperties_DavidAbarca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John Doe"; // Testing setter
            Console.WriteLine(person.Name); // Testing getter
            Console.WriteLine(person.ReadOnlyName); // Testing read-only property
        }
    }
}