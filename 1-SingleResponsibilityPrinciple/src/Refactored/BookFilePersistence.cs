using System;
using System.Collections.Generic;
using System.IO;

namespace SingleResponsibilityPrinciple.src.Refactored
{
    public class BookFilePersistence : BookPersistence
    {
        public static readonly string BOOK_DIRECTORY_PATH = "/tmp";

        public void Save(Book book)
        {
            string bookFilePath = Path.Combine(
                BOOK_DIRECTORY_PATH,
                $"{book.GetTitle()}_{DateTimeOffset.Now.ToUnixTimeMilliseconds()}"
            );
            List<Page> bookPages = book.GetPages();

            try
            {
                using (StreamWriter writer = new StreamWriter(bookFilePath))
                {
                    foreach (Page page in bookPages)
                    {
                        writer.WriteLine($"---- Page {page.GetNumber()} ----");
                        writer.WriteLine(page.GetContent());
                    }
                }
            }
            catch (IOException)
            {
                throw new BookPersistenceException();
            }
        }
    }
}