using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Articles2._0
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

        //public void PrintResult(List<Article> article)
        //{
        //    Console.WriteLine($"{this.Title} - {this.Content.Trim()}: {this.Author.Trim()}");
        //}
    }

    class ListOfArticles
    {

        public ListOfArticles()
        {
            this.Articles = new List<Article>();
        }

        public List<Article> Articles { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            ListOfArticles listOfArticles = new ListOfArticles();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries);

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title.Trim(), content.Trim(), author.Trim());

                listOfArticles.Articles.Add(article);
            }



            string finalCommand = Console.ReadLine();

            List<Article> sortedList = new List<Article>();

            if (finalCommand == "title")
            {
                sortedList = listOfArticles.Articles.OrderBy(title => title.Title).ToList();
            }
            else if (finalCommand == "content")
            {
                sortedList = listOfArticles.Articles.OrderBy(content => content.Content).ToList();
            }
            else if (finalCommand == "author")
            {
                sortedList = listOfArticles.Articles.OrderBy(author => author.Author).ToList();
            }

            foreach (Article article in sortedList)
            {
                //sortedList.PrintResult(sortedList);
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }

        }
    }
}
