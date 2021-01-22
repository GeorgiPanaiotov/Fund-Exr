using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Article[] article = new Article[n];

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();
                article[i] = new Article(array[0], array[1], array[2]);
            }

            string order = Console.ReadLine();

            switch (order)
            {
                case "title":
                    article = article.OrderBy(x => x.Title).ToArray();
                    foreach (var item in article)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                case "content":
                    article = article.OrderBy(x => x.Content).ToArray();
                    foreach (var item in article)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                case "author":
                    article = article.OrderBy(x => x.Author).ToArray();
                    foreach (var item in article)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
            }

        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public Article()
        {

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{this.Title} -{this.Content}:{this.Author}";
        }

    }

}

