using Lab10;

Console.WriteLine("This is a program to draw and allow you to either draw or modify an existing drawing. (In Yellow!)");

List<IGraphic2DFactory> availableShapeTypes = new List<IGraphic2DFactory>{new RectangleFactory(), new CircleFactory()};
List<IGraphic2D> builtShapes = new List<IGraphic2D>();

while (true)
{
    Console.WriteLine("Select choice by pressing that number.\n1: Display drawing\n2: Add graphic\n3: Remove graphic\n4: Exit");
    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.D1:
            Console.Clear();
            AbstractGraphic2D.Display(builtShapes);
            Console.ReadLine();
            break;

        case ConsoleKey.D2:
            int i = 1;
            Console.WriteLine("Available shape types: ");
            foreach (var item in availableShapeTypes)
            {
                Console.WriteLine(i + ": " + item.Name);
                i++;
            }

            Console.WriteLine("Enter the number of the shape type you're creating.");
            if (int.TryParse(Console.ReadLine(), out int shapeNum) && shapeNum > 0 && shapeNum <= availableShapeTypes.Count)
            {
                var selectedFactory = availableShapeTypes[shapeNum - 1];
                var Shape = selectedFactory.Create();
                builtShapes.Add(Shape);
                Console.WriteLine(selectedFactory.Name + " added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Try again. Press enter to return.");
            }
            break;

        case ConsoleKey.D3:
            Console.WriteLine("\nEnter the number of the graphic you're removing.");
            for (i = 0; i < builtShapes.Count; i++)
            {
                Console.Write($"{i+1}: {builtShapes[i]}");
            }
            Console.WriteLine();
            if (int.TryParse(Console.ReadLine(), out int graphicNum) && graphicNum > 0 && graphicNum <= builtShapes.Count())
            {
                builtShapes.RemoveAt(graphicNum - 1);
                Console.WriteLine("Removed selected graphic.");
            }
            else
                Console.WriteLine("Invalid input. Try again. Press enter to return.");
            Console.ReadLine();
            break;

        case ConsoleKey.D4:
            Console.Clear();
            return;

        default:
            Console.WriteLine("Invalid input. Try again. Press enter to return.");
            Console.ReadLine();
            break;
    }
}