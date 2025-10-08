using System.Collections.Generic;

namespace SingleResponsibilityPrinciple.src.Refactored;

public class Book
{
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

    public List<Page> GetPages()
    {
        return pages;
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
}