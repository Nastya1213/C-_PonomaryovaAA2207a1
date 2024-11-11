using System;
using System.Collections.Generic;
namespace CompositePattern{
public class Section : IDocumentComponent
{
    private string _title;
    private List<IDocumentComponent> _components = new List<IDocumentComponent>();

    public Section(string title)
    {
        _title = title;
    }

    public void Add(IDocumentComponent component)
    {
        if (component is Paragraph || component is Section)
        {
            _components.Add(component);
        }
        else
        {
            throw new NotSupportedException("Можно добавлять только параграфы и разделы");
        }
    }


    public void Remove(IDocumentComponent component)
    {
        _components.Remove(component);
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " Section: " + _title);
        foreach (var component in _components)
        {
            component.Display(depth + 2); 
        }
    }
}
}