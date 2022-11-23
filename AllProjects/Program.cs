namespace AllProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex01 Your first program
            //Assignment is to make a simple program that could read inputs and write them out agian
            Console.Write("Indtastet navn: ");
            string? Name = Console.ReadLine();
            Console.Write("Indtastet alder: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Navn: "+ Name);
            Console.WriteLine("Alder: " + Age);
            // $"her inde bliver det printet som normal, men hvis man smider {Age} ind vil det blive printet somom du skrev " + Age + "
            Console.WriteLine($"{Name} er {Age} år gammel");
        }
    }
}