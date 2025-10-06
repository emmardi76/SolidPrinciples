using System;
using System.Collections.Generic;
using System.IO;

namespace srp.badexample
{
    public class Book
    {
        public static readonly string BOOK_DIRECTORY_PATH = "/tmp";

        private string title;
        private string author;
        private List<Page> pages;
        private Page currentPage;

        public Book(string title, string author, List<Page> pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.currentPage = this.pages[0];
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public Page GetCurrentPage()
        {
            return currentPage;
        }

        public void TurnPage()
        {
            int nextPageIndex = currentPage.GetNumber();
            if (nextPageIndex < pages.Count)
            {
                currentPage = pages[nextPageIndex];
            }
        }

        public void TurnPageBack()
        {
            int previousPageIndex = currentPage.GetNumber() - 2;
            if (previousPageIndex >= 0)
            {
                currentPage = pages[previousPageIndex];
            }
        }

        public void Save()
        {
            string bookFilePath = Path.Combine(BOOK_DIRECTORY_PATH, $"{this.title}_{DateTimeOffset.Now.ToUnixTimeMilliseconds()}");
            using (StreamWriter writer = new StreamWriter(bookFilePath))
            {
                foreach (Page page in pages)
                {
                    writer.WriteLine($"---- Page {page.GetNumber()} ----");
                    writer.WriteLine(page.GetContent());
                }
            }
        }
    }
}