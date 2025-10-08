namespace SingleResponsibilityPrinciple.src.Refactored;

public class Page
{
    private int number;
    private string content;

    public Page(int number, string content)
    {
        this.number = number;
        this.content = content;
    }

    public int GetNumber()
    {
        return number;
    }

    public string GetContent()
    {
        return content;
    }
}