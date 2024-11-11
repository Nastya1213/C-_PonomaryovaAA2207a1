using System;
using System.Collections.Generic;
namespace CompositePattern{
public class Document
{
    private List<IDocumentComponent> _sections = new List<IDocumentComponent>();

    public void AddSection(IDocumentComponent section)
    {
        _sections.Add(section);
    }

    public void RemoveSection(IDocumentComponent section)
    {
        _sections.Remove(section);
    }

    public void Display()
    {
        Console.WriteLine("Document:");
        foreach (var section in _sections)
        {
            section.Display(2); // Начальная глубина отступов
        }
    }
}
}