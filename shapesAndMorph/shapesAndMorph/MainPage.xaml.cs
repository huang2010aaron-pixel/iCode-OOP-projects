using Microsoft.Maui.Controls.Shapes;
using shapesAndMorph;
using System.Collections.ObjectModel;
namespace shapesAndMorph
{
    public partial class MainPage : ContentPage
    {
        public string selectedshape = "Circle";
        public string selectedcalculation = "Area";
        public class ShapeDisplay
        {
            public string Name { get; set; }
            public string ResultArea { get; set; }
            public string ResultPerimeter { get; set; }
        }
        public MainPage()
        {
            InitializeComponent();
            SizeChanged += Layout_SizeChanged;
        }

        private void Layout_SizeChanged(object? sender, EventArgs e)
        {
            if (Width < 400 || Height < 600)
            {
                Title.FontSize = 24;
                value1.FontSize = 12;
                value2.FontSize = 12;
                CircleButton.FontSize = 12;
                SquareButton.FontSize = 12;
                RectangleButton.FontSize = 12;
                TriangleButton.FontSize = 12;
                AreaButton.FontSize = 12;
                PerimeterButton.FontSize = 12;
                Result.FontSize = 24;

                value1.WidthRequest = 65;
                value2.WidthRequest = 65;
                CircleButton.WidthRequest = 55;
                SquareButton.WidthRequest = 70;
                RectangleButton.WidthRequest = 90;
                TriangleButton.WidthRequest = 80;
                AreaButton.WidthRequest = 55;
                PerimeterButton.WidthRequest = 90;
            }
            else
            {
                Title.FontSize = 24;
                value1.FontSize = 24;
                value2.FontSize = 24;
                CircleButton.FontSize = 24;
                SquareButton.FontSize = 24;
                RectangleButton.FontSize = 24;
                TriangleButton.FontSize = 24;
                AreaButton.FontSize = 24;
                PerimeterButton.FontSize = 24;
                Result.FontSize = 24;

                value1.WidthRequest = 100;
                value2.WidthRequest = 100;
                CircleButton.WidthRequest = 100;
                SquareButton.WidthRequest = 120;
                RectangleButton.WidthRequest = 150;
                TriangleButton.WidthRequest = 130;
                AreaButton.WidthRequest = 100;
                PerimeterButton.WidthRequest = 150;
            }
        }
        //private void OnCalculateClicked(object? sender, EventArgs e)
        //{
        //    List<Shape> shapes = new List<Shape>
        //        {
        //            new Circle(Convert.ToDouble(value1.Text)),
        //            new Square (Convert.ToDouble(value1.Text)),
        //            new Rectangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
        //            new Triangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
        //        };
        //    var displayList = new ObservableCollection<ShapeDisplay>();
        //    foreach (var shape in shapes)
        //    {
        //        displayList.Add(new ShapeDisplay
        //        {
        //            Name = shape.Name,
        //            ResultArea = shape.Area().ToString("F2"),
        //            ResultPerimeter = shape.Perimeter().ToString("F2")
        //        });
        //    }

        //    ShapesListView.ItemsSource = displayList;
        //}

        private void CircleButton_Clicked(object sender, EventArgs e)
        {
            selectedshape = "Circle";
            List<Shape> shapes = new List<Shape>
                {
                    new Circle(Convert.ToDouble(value1.Text)),
                    new Square (Convert.ToDouble(value1.Text)),
                    new Rectangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                    new Triangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                };
            var displayList = new ObservableCollection<ShapeDisplay>();
            if (selectedcalculation == "Area")
            {
                Result.Text = shapes[0].Area().ToString("F2") + " square units";
            }
            else
            {

                Result.Text = shapes[0].Perimeter().ToString("F2") + " units";
            }
        }

        private void SquareButton_Clicked(object sender, EventArgs e)
        {
            selectedshape = "Square";
            List<Shape> shapes = new List<Shape>
                {
                    new Circle(Convert.ToDouble(value1.Text)),
                    new Square (Convert.ToDouble(value1.Text)),
                    new Rectangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                    new Triangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                };
            var displayList = new ObservableCollection<ShapeDisplay>();
            if (selectedcalculation == "Area")
            {
                Result.Text = shapes[1].Area().ToString("F2") + " square units";
            }
            else
            {

                Result.Text = shapes[1].Perimeter().ToString("F2") + " units";
            }
        }

        private void RectangleButton_Clicked(object sender, EventArgs e)
        {
            selectedshape = "Rectangle";
            List<Shape> shapes = new List<Shape>
                {
                    new Circle(Convert.ToDouble(value1.Text)),
                    new Square (Convert.ToDouble(value1.Text)),
                    new Rectangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                    new Triangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                };
            var displayList = new ObservableCollection<ShapeDisplay>();
            if (selectedcalculation == "Area")
            {
                Result.Text = shapes[2].Area().ToString("F2") + " square units";
            }
            else
            {

                Result.Text = shapes[2].Perimeter().ToString("F2") + " units";
            }
        }

        private void TriangleButton_Clicked(object sender, EventArgs e)
        {
            selectedshape = "Triangle";
            List<Shape> shapes = new List<Shape>
                {
                    new Circle(Convert.ToDouble(value1.Text)),
                    new Square (Convert.ToDouble(value1.Text)),
                    new Rectangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                    new Triangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                };
            var displayList = new ObservableCollection<ShapeDisplay>();
            if (selectedcalculation == "Area")
            {
                Result.Text = shapes[3].Area().ToString("F2") + " square units";
            }
            else
            {

                Result.Text = shapes[3].Perimeter().ToString("F2") + " units";
            }
        }

        private void CalculateArea(object sender, EventArgs e)
        {
            selectedcalculation = "Area";
            List<Shape> shapes = new List<Shape>
                {
                    new Circle(Convert.ToDouble(value1.Text)),
                    new Square (Convert.ToDouble(value1.Text)),
                    new Rectangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                    new Triangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                };
            var displayList = new ObservableCollection<ShapeDisplay>();
            if (selectedshape == "Circle")
            {
                Result.Text = shapes[0].Area().ToString("F2") + " square units";
            }
            else if (selectedshape == "Square")
            {
                Result.Text = shapes[1].Area().ToString("F2") + " square units";
            }
            else if (selectedshape == "Rectangle")
            {
                Result.Text = shapes[2].Area().ToString("F2") + " square units";
            }
            else if (selectedshape == "Triangle")
            {
                Result.Text = shapes[3].Area().ToString("F2") + " square units";
            }
        }

        private void CalculatePerimeter(object sender, EventArgs e)
        {
            selectedcalculation = "Perimeter";
            List<Shape> shapes = new List<Shape>
                {
                    new Circle(Convert.ToDouble(value1.Text)),
                    new Square (Convert.ToDouble(value1.Text)),
                    new Rectangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                    new Triangle(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text)),
                };
            var displayList = new ObservableCollection<ShapeDisplay>();
            if (selectedshape == "Circle")
            {
                Result.Text = shapes[0].Perimeter().ToString("F2") + " units";
            }
            else if (selectedshape == "Square")
            {
                Result.Text = shapes[1].Perimeter().ToString("F2") + " units";
            }
            else if (selectedshape == "Rectangle")
            {
                Result.Text = shapes[2].Perimeter().ToString("F2") + " units";
            }
            else if (selectedshape == "Triangle")
            {
                Result.Text = shapes[3].Perimeter().ToString("F2") + " units";
            }
        }
    }
}
