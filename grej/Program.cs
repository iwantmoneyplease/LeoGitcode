namespace grej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int run = 0;
            while(true)
            {
                Console.WriteLine("Välj i menyn: 1...Från GitCode  2...Från Leo  Annat...Avsluta");
                run = int.Parse(Console.ReadLine());
                if (run == 1)
                {
                    Greetings();
                }
                else if (run == 2)
                {
                    Leo();
                }
                else
                {
                    Console.WriteLine("Hej då");
                    break;
                }
            }

            static void Greetings()
            {
                Console.WriteLine("Hej från Gitcode");
            }

            static void Leo()
            {
                Console.WriteLine("Tjenare kexet, sitter du där o smular");
            }
        }
    }
}