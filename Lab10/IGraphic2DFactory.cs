namespace Lab10;

public interface IGraphic2DFactory
{
    string Name{ get; }
    IGraphic2D Create();
}

public class RectangleFactory : IGraphic2DFactory
{
    public string Name => "Rectangle";

    public IGraphic2D Create()
    {
        Console.WriteLine("Enter the left bound of the rectangle");
        decimal Left = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the top bound of the rectangle");
        decimal Top = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle");
        decimal Width = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the rectangle");
        decimal Height = decimal.Parse(Console.ReadLine());

        return new Rectangle(Left, Top, Width, Height) {BackgroundColor = ConsoleColor.DarkYellow, DisplayChar = ' '};
    }
}
public class CircleFactory : IGraphic2DFactory
{
    public string Name => "Circle";

    public IGraphic2D Create()
    {
        Console.WriteLine("Enter the X-coordinate of the center:");
        decimal centerX = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Y-coordinate of the center:");
        decimal centerY = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the radius:");
        decimal radius = decimal.Parse(Console.ReadLine());

        return new Circle(centerX, centerY, radius) {BackgroundColor = ConsoleColor.DarkYellow, DisplayChar = ' '};
    }
}