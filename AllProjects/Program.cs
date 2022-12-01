namespace AllProjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Academy("UCL", "Seebladsgade");
            var p2 = new Academy("SDU", "Havnegade");

            var s1 = new Student(p, "Jens");
            var s2 = new Student(p, "Niels");
            var s3 = new Student(p, "Susan");
            var s4 = new Student(p2, "Stefan");
            var s5 = new Student(p2, "Ask");
            var s6 = new Student(p2, "Emil");

            p.Attach(s1);
            p.Attach(s2);
            p.Attach(s3);
            p2.Attach(s4);
            p2.Attach(s5);
            p2.Attach(s6);

            p.Message = "Så er der julefrokost!";
            p2.Message = "Du er med i Dream Team!";

            p.Detach(s2);

            Console.ReadLine();
        }

    }
}