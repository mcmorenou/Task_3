namespace Backend;

public class Square : GeometricFigure


{
    // Fields
    private double _a;

    // Constructors
    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    // Properties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // Public Methods
    public override double GetArea()
    {
        return Math.Pow(A, 2);
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    // Private Methods
    private double ValidateA(double a)
    {
        if (a <= 0)
            throw new ArgumentException("A must be greater than zero.", nameof(a));

        return a;
    }
}