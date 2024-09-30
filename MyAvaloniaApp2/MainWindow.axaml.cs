using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Controls.Shapes;

namespace MyAvaloniaApp2
{
    public partial class MainWindow : Window
    {
        private ShapeManager _shapeManager = new ShapeManager();
        private string _selectedShape = "Circle"; // Изначально выбран круг

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnFactoryChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FactorySelector.SelectedIndex == 0)
            {
                _shapeManager.SetFactory(new RedFactory());
            }
            else if (FactorySelector.SelectedIndex == 1)
            {
                _shapeManager.SetFactory(new BlueFactory());
            }

            DrawShapes();
        }

        private void OnShapeChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (ComboBoxItem)ShapeSelector.SelectedItem;
            _selectedShape = selectedItem.Content.ToString();
            DrawShapes();
        }

        private void DrawShapes()
        {
            ShapesCanvas.Children.Clear();

            var shape = _shapeManager.GetShape(_selectedShape);
            if (shape != null)
            {
                // Размер холста
                double canvasWidth = ShapesCanvas.Bounds.Width;
                double canvasHeight = ShapesCanvas.Bounds.Height;

                // Размер фигуры
                double shapeWidth = shape.Bounds.Width;
                double shapeHeight = shape.Bounds.Height;

                // Вычисляем центрирование
                Canvas.SetLeft(shape, (canvasWidth - shapeWidth) / 2);
                Canvas.SetTop(shape, (canvasHeight - shapeHeight) / 2);

                ShapesCanvas.Children.Add(shape);
            }
        }

    }

    public class ShapeManager
    {
        private IShapeFactory? _currentFactory;

        public void SetFactory(IShapeFactory factory)
        {
            _currentFactory = factory;
        }

        public Control? GetShape(string shapeType)
        {
            if (_currentFactory == null) return null;

            return shapeType switch
            {
                "Circle" => _currentFactory.CreateCircle(),
                "Square" => _currentFactory.CreateSquare(),
                "Triangle" => _currentFactory.CreateTriangle(),
                _ => null,
            };
        }
    }
}
