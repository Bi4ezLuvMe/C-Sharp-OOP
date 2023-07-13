using System.Security.Principal;

namespace _02.EnterNumbers
{
    class Program
    {
        static void Main()
        {
            string[] temp = Console.ReadLine().Split(",");
            Dictionary<int, double> balances = new();
            int temp2 = 0;
            foreach (string s in temp)
            {
                string[] temp1 = s.Split("-");
                int accNum = int.Parse(temp1[0]);
                double balance = double.Parse(temp1[1]);
                balances.Add(accNum, balance);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                try
                {
                    string[] tokens = command.Split();
                    if (tokens[0] == "Deposit")
                    {
                        int accNum = int.Parse(tokens[1]);
                        double sum = double.Parse(tokens[2]);
                        if (!balances.ContainsKey(accNum))
                        {
                            throw new Exception("Invalid account!");
                        }
                        balances[accNum] += sum;
                        Console.WriteLine($"Account {accNum} has new balance: {balances[accNum]:f2}");
                    }
                    else if (tokens[0] == "Withdraw")
                    {
                        int accNum = int.Parse(tokens[1]);
                        double sum = double.Parse(tokens[2]);
                        if (!balances.ContainsKey(accNum))
                        {
                            throw new Exception("Invalid account!");
                        }
                        if (balances[accNum] < sum)
                        {
                            throw new Exception("Insufficient balance!");
                        }
                        balances[accNum] -= sum;
                        Console.WriteLine($"Account {accNum} has new balance: {balances[accNum]:f2}");
                    }
                    else
                    {
                        throw new Exception("Invalid command!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Enter another command");
                command = Console.ReadLine();
            }
        }
    }
}