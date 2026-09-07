namespace Backend;

public class Circle : GeometricFigure


{
    // Fields
    private double _r;

    // Constructors
    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    // Properties
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    // Public Methods
    public override double GetArea()
    {
        return Math.PI * Math.Pow(R, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    // Private Methods
    private double ValidateR(double r)
    {
        if (r <= 0)
            throw new ArgumentException("R must be greater than zero.", nameof(r));

        return r;
    }
}