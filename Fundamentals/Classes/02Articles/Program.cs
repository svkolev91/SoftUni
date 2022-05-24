using System;

namespace _02Articles
{

    class Article
    {

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Rename(Article article, string newTitle)
        {
            article.Title = newTitle;
        }

        public void Edit(Article article, string newContent)
        {
            article.Content = newContent;
        }

        public void ChangeAuthor(Article article, string newAuthor)
        {
            article.Author = newAuthor;
        }

        public void PrintResult(Article article)
        {
            Console.WriteLine($"{article.Title} - {article.Content.Trim()}: {article.Author.Trim()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries);

            int numberOfCommands = int.Parse(Console.ReadLine());

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);

            for (int i = 0; i < numberOfCommands; i++)
            {
                input = Console.ReadLine()
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                string update = input[1];

                if (input[0] == "Edit")
                {
                    article.Edit(article, update);
                }
                else if (input[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(article, update);
                }
                else if (input[0] == "Rename")
                {
                    article.Rename(article,update);
                }
            }

            article.PrintResult(article);
        }
    }
}
