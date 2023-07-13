namespace Shapes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            try
            {
                if (number < 0)
                {
                    throw new Exception("Invalid number.");
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Goodbye.");
        }
    }
}