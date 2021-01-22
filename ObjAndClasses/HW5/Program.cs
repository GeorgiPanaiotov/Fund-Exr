using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Message message = new Message();
                Random rand = new Random();
                Console.WriteLine($"{message.Phrases[rand.Next(0, 5)]} {message.Events[rand.Next(0, 5)]} {message.Authors[rand.Next(0, 7)]} – {message.Cities[rand.Next(0, 4)]}.");
            }
        }
    }
    public class Message
    {
        public Message()
        {
            this.Phrases = new string[]
            { "Excellent product."
            , "Such a great product."
            , "I always use that product."
            , "Best product of its category."
            , "Exceptional product."
            , "I can’t live without this product."};

            this.Events = new string[]
            { "Now I feel good."
            , "I have succeeded with this product."
            , "Makes miracles. I am happy of the results!"
            , "I cannot believe but now I feel awesome."
            , "Try it yourself, I am very satisfied."
            , "I feel great!" };

            this.Authors = new string[]
            { "Diana"
            , "Petya"
            , "Stella"
            , "Elena"
            , "Katya"
            , "Iva"
            , "Annie"
            , "Eva" };

            this.Cities = new string[]
            { "Burgas"
            , "Sofia"
            , "Plovdiv"
            , "Varna"
            , "Ruse"};

        }
        public string[] Phrases { get; set; }
        public string[] Events { get; set; }
        public string[] Authors { get; set; }
        public string[] Cities { get; set; }
    }
}
