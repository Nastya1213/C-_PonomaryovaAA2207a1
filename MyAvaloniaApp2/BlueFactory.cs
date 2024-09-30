using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Controls.Shapes;
using System.Collections.Generic;

namespace MyAvaloniaApp2
{
    public class BlueFactory : IShapeFactory
    {
        public Control CreateCircle()
        {
            return new Ellipse
            {
                Width = 50,
                Height = 50,
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 1
            };
        }

        public Control CreateSquare()
        {
            return new Rectangle
            {
                Width = 50,
                Height = 50,
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 1
            };
        }

        public Control CreateTriangle()
        {
            var polygon = new Polygon
            {
                Points = new List<Avalonia.Point> // Заменено на List<Avalonia.Point>
                {
                    new Avalonia.Point(25, 0),
                    new Avalonia.Point(50, 50),
                    new Avalonia.Point(0, 50)
                },
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 1
            };
            return polygon;
        }
    }
}
