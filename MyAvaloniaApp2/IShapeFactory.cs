using Avalonia.Controls;

namespace MyAvaloniaApp2
{
    public interface IShapeFactory
    {
        Control CreateCircle();  
        Control CreateSquare();  
        Control CreateTriangle();  
    }
}