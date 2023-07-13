namespace _02.EnterNumbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            while (counter != 3)
            {
                string[] command = Console.ReadLine().Split();
                try
                {
                    if (command[0] == "Replace")
                    {
                        if (int.TryParse(command[1], out int index) && int.TryParse(command[2], out int element))
                        {
                            if (index < 0 || index > numbers.Length - 1)
                            {
                                throw new Exception("The index does not exist!");
                            }
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (i == index)
                                {
                                    numbers[i] = element;
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("The variable is not in the correct format!");
                        }

                    }
                    else if (command[0] == "Print")
                    {
                        if (int.TryParse(command[1], out int startIndex) && int.TryParse(command[2], out int endIndex))
                        {
                            if (startIndex < 0 || startIndex > numbers.Length - 1)
                            {
                                throw new Exception("The index does not exist!");
                            }
                            if (endIndex < 0 || endIndex > numbers.Length - 1)
                            {
                                throw new Exception("The index does not exist!");
                            }
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                if (i == endIndex)
                                {
                                    Console.WriteLine($"{numbers[i]}");
                                }
                                else
                                {
                                    Console.Write($"{numbers[i]}, ");
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("The variable is not in the correct format!");
                        }
                    }
                    else if (command[0] == "Show")
                    {
                        if (int.TryParse(command[1], out int index))
                        {
                            if (index < 0 || index > numbers.Length - 1)
                            {
                                throw new Exception("The index does not exist!");
                            }
                            Console.WriteLine(numbers[index]);
                        }
                        else
                        {
                            throw new Exception("The variable is not in the correct format!");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    counter++;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}