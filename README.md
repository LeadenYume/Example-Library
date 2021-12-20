# Description

Пример библиотеки
Решение содержит три проекта

* `Library` - библиотека
* `LibraryTest` - тесты
* `LibraryTest` - использование

## Usage



```c#
var figures = new List<Figure>();

figures.Add(new Circle(2));
figures.Add(new Circle(2));
figures.Add(new Triangle(1, 1, 1));
figures.Add(new Circle(2));
figures.Add(new Triangle(2, 4, 5));
figures.Add(new Rectangle(2, 4));

foreach (var figure in figures)
{
    Console.WriteLine($"Figure type is {figure.Type}. Is triangle? {Triangle.IsTriangle(figure)}. Area: {figure.CalculateArea()}.");
}

var triangle = new Triangle(3, 4, 5);
Console.WriteLine(triangle.IsRight());
triangle = new Triangle(3, 4, 6);
Console.WriteLine(triangle.IsRight());
```
