using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    public class Card
    {
        string face;
        string suit;
        public Card(string face,string suit)
        {
            Suit = suit;
            Face = face;
        }
        public string Face { get => face; private set {if (!isFaceValid(value)) { throw new Exception("Invalid card!"); }face = value; } }
        public string Suit { get => suit; set {if(!isSuitValid(value)) { throw new Exception("Invalid card!"); } suit = value; } }

        bool isFaceValid(string value)
        {
            if (value == "2" || value == "3" || value == "4" || value == "5" || value == "6" || value == "7" || value == "8" || value == "9" || value == "10" || value == "J" || value == "Q" || value == "K" || value == "A")
            {
                return true;
            }
            return false;
        }
        bool isSuitValid(string value)
        {
            if (value == "S" || value == "H" || value == "D" || value == "C")
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            switch (suit)
            {
                case "S":return $"[{face}\u2660]";
                case "H": return $"[{face}\u2665]";
                case "D": return $"[{face}\u2666]";
                case "C": return $"[{face}\u2663]";
            }
            return null;
        }
    }
    class Program
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split(", ");
            List<Card> cards = new();
            foreach (var item in tokens)
            {
                string[] temp = item.Split();
                string face = temp[0];
                string suit = temp[1];
                try
                {
                    Card card = new(face,suit);
                    cards.Add(card);
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
           foreach (var item in cards)
            {
                Console.Write($"{item.ToString()} ");
            }
        }
    }
}