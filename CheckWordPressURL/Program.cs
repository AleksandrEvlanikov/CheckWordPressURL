namespace CheckWordPressURL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckURL CheckURL = new CheckURL();
            Console.WriteLine("Введите URL ");
            string urlUserInput = Console.ReadLine();

            if(CheckURL.CheckURLOnWordPress(urlUserInput))
            {
                Console.WriteLine("Сайт реализован с помощью WordPress.");
            }
            else
            {
                Console.WriteLine("Сайт не реализован с помощью WordPress.");
            }
        }
    }
}
