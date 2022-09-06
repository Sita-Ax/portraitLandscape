namespace portraitLandscape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username ");
            string userName = Console.ReadLine();
            Console.WriteLine(userName + " put in a width of an image!");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userName + " put in a height of an image!");
            int height = Convert.ToInt32(Console.ReadLine());


            if (width >= height)
            {
                Console.WriteLine("This is a Landscape!");
            }
            else
            {
                Console.WriteLine("This is a Portrait!");
            }

        }
    }
}