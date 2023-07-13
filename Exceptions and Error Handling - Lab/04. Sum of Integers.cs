namespace _02.EnterNumbers
{
    class Program
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split();
            int sum = 0;
            foreach (string token in tokens)
            {
                try
                {
                    if (!long.TryParse(token, out long value))
                    {
                        throw new FormatException($"The element '{token}' is in wrong format!");
                    }
                    if (value > int.MaxValue || value < int.MinValue)
                    {
                        throw new OverflowException($"The element '{value}' is out of range!");
                    }
                    sum += (int)value;
                    Console.WriteLine($"Element '{value}' processed - current sum: {sum}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"Element '{token}' processed - current sum: {sum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}