using System;


class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle(20);

        double area = myCircle.GetArea();

        Console.WriteLine(area);

    }
}