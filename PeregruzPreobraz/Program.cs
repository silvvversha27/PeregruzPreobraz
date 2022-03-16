using PeregruzPreobraz;

Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };
Square square = new Square {Length=7};

rectangle.Draw();
square.Draw();

Rectangle rectSquare = square;
rectangle.Draw();

Square squareRect = (Square)rectangle;
squareRect.Draw();
int number=int.Parse(Console.ReadLine());
Square squareInt = number;
squareInt.Draw();
number = (int)square;
Console.WriteLine(number);
