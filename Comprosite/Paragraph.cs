using System;
namespace CompositePattern{
public class Paragraph : IDocumentComponent
{
    private string _text;

    public Paragraph(string text)
    {
        _text = text;
    }

    public void Add(IDocumentComponent component)
    {
        throw new NotSupportedException("Нельзя добавить в параграф");
    }

    public void Remove(IDocumentComponent component)
    {
        throw new NotSupportedException("Нельзя удалить из параграфа");
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " Paragraph: " + _text);
    }
}
}