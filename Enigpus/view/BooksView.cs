using Enigpus.model;
using Enigpus.services.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Enigpus.view
{
    public class BooksView
    {
        private InventoryServiceImpl inventoryService = new InventoryServiceImpl();
        public void Run()
        {
            //InventoryServiceImpl inventoryService = new InventoryServiceImpl();

            Novel novel = new Novel();
            novel.Code = "A23KL";
            novel.Title = "Dark In The Sky";
            novel.Author = "Fajar";
            novel.Publisher = "Darussalam";
            novel.PublicationYear = "2025";
            inventoryService.AddBook(novel);

            Magazine magazine = new Magazine();
            magazine.Code = "B23KL";
            magazine.Title = "New Technology";
            magazine.Publisher = "Darussalam TK";
            magazine.PublicationYear = "2024";
            inventoryService.AddBook(magazine);

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("~ Enigpus Inventory Menu ~");
                Console.WriteLine("1.) Add Book");
                Console.WriteLine("2.) Find Book By Title");
                Console.WriteLine("3.) View All Book");
                Console.WriteLine("4.) Exit");
                Console.Write("Input your choice => ");
                try
                {
                    string select = Console.ReadLine();

                    switch(select)
                    {
                        case "1":
                            NewBook();
                            break;
                        case "2":
                            FindBook();
                            break;
                        case "3":
                            ShowBook(inventoryService.GetAllBooks());
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Please input valid number");
                            break;
                    }
                }
                catch { };
            }
        }

        private void NewBook()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.WriteLine("Type of Book");
            Console.WriteLine("1.) Novel");
            Console.WriteLine("2.) Magazine");
            Console.WriteLine("3.) Back");
            Console.Write("Select type => ");
            try
            {
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        FormNovel();
                        break;
                    case "2":
                        FormMagazine();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Please input valid number");
                        NewBook();
                        break;
                }

            }
            catch { }
        }

        private void FormNovel()
        {
            string code, title, author, publisher, publicationYear;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("-------------");
                Console.WriteLine("Add New Novel");
                Console.WriteLine("-------------");
                Console.Write("Input Code : ");
                code = Console.ReadLine();

                Console.Write("Input Title : ");
                title = Console.ReadLine();

                Console.Write("Input Author : ");
                author = Console.ReadLine();

                Console.Write("Input Publisher : ");
                publisher = Console.ReadLine();

                Console.Write("Input Publication Year : ");
                publicationYear = Console.ReadLine();

            } while (
                string.IsNullOrWhiteSpace(code) ||
                string.IsNullOrWhiteSpace(title) 
            );

            Novel novel = new Novel();
            novel.Title = title;
            novel.Code = code;
            novel.Author = author;
            novel.Publisher = publisher;
            novel.PublicationYear = publicationYear;

            inventoryService.AddBook(novel);
        }

        private void FormMagazine()
        {
            string code, title, author, publisher, publicationYear;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("------------");
                Console.WriteLine("Add Magazine");
                Console.WriteLine("------------");
                Console.Write("Input Code : ");
                code = Console.ReadLine();

                Console.Write("Input Title : ");
                title = Console.ReadLine();

                Console.Write("Input Publisher : ");
                publisher = Console.ReadLine();

                Console.Write("Input Publication Year : ");
                publicationYear = Console.ReadLine();

            } while (
                string.IsNullOrWhiteSpace(code) ||
                string.IsNullOrWhiteSpace(title)
            );

            Magazine magazine = new Magazine();
            magazine.Title = title;
            magazine.Code = code;
            magazine.Publisher = publisher;
            magazine.PublicationYear = publicationYear;

            inventoryService.AddBook(magazine);
        }

        private void ShowBook(List<Book> books)
        {
            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.WriteLine("Show All Book");
            Console.WriteLine("-------------");

            foreach (var book in books)
            {
                if (book is Novel novel)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Code                : {novel.Code}");
                    Console.WriteLine($"Title               : {novel.Title}");
                    Console.WriteLine($"Author              : {novel.Author}");
                    Console.WriteLine("Type                : Novel");
                    Console.WriteLine($"Publisher           : {novel.Publisher}");
                    Console.WriteLine($"Publication Year    : {novel.PublicationYear}");

                }

                if (book is Magazine magazine)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Code                : {magazine.Code}");
                    Console.WriteLine($"Title               : {magazine.Title}");
                    Console.WriteLine("Type                : Magazine");
                    Console.WriteLine($"Publisher           : {magazine.Publisher}");
                    Console.WriteLine($"Publication Year    : {magazine.PublicationYear}");
                }

            }

            Console.WriteLine("");
            Console.WriteLine("-------------");
        }

        private void FindBook()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.Write("Input title =>  ");
            string input = Console.ReadLine();

            Book find = inventoryService.SearchBook(input);


            Console.WriteLine("");
            Console.WriteLine("-------------");

            if (find != null)
            {
                if (find is Novel novel)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Code                : {novel.Code}");
                    Console.WriteLine($"Title               : {novel.Title}");
                    Console.WriteLine($"Author              : {novel.Author}");
                    Console.WriteLine("Type                : Novel");
                    Console.WriteLine($"Publisher           : {novel.Publisher}");
                    Console.WriteLine($"Publication Year    : {novel.PublicationYear}");

                }

                if (find is Magazine magazine)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Code                : {magazine.Code}");
                    Console.WriteLine($"Title               : {magazine.Title}");
                    Console.WriteLine("Type                : Magazine");
                    Console.WriteLine($"Publisher           : {magazine.Publisher}");
                    Console.WriteLine($"Publication Year    : {magazine.PublicationYear}");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Data not found");
            }

            Console.WriteLine("-------------");
        }
    }
}
