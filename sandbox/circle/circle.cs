class Circle

{
    private double _radius;

    public Circle()
    {
        _radius = 1.0;
    }

    public Circle(double radius)
    {
        SetRadius(radius);
    }
    public Circle(int radius)
    {
        SetRadius(radius);
    }

    public double GetArea()
    {
        return 3.14159 * _radius * _radius;
    }

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            _radius = 1.0;
            Console.WriteLine("Invalid value, must be >= 0");
        }
        else
        {
            _radius = radius;
        }
    }
}