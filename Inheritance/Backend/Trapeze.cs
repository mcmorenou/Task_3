namespace Backend;

public class Trapeze : Triangle


{
    // Fields
    private double _d;

    // Constructors
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b , c, h)
    {
        D = d;
    }

    // Properties
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }


    // Public Methods
    public override double GetArea()
    {
        return (B + D) * H/2;
    }

    public override double GetPerimeter()
    {
        return (A + B + C + D);
    }

    // Private Methods
    private double ValidateD(double d)
    {
        if (d <= 0)
            throw new ArgumentException("D must be greater than zero.", nameof(d));

        return d;
    }

}