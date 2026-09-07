namespace Backend;

public class Triangle: Rectangle


{
    // Fields
    private double _h;
    private double _c;

    // Constructors
    public Triangle(string name, double a, double b, double h, double c) : base(name, a, b)
    {
        H = h;
        C = c;
    }

    // Properties
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    // Public Methods
    public override double GetArea()
    {
        return (H * B)/2 ;
    }

    public override double GetPerimeter()
    {
        return  (A + B + C);
    }

    // Private Methods
    private double ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException("H must be greater than zero.", nameof(h));

        return h;
    }

    private double ValidateC(double c)
    {
        if (c <= 0)
            throw new ArgumentException("C must be greater than zero.", nameof(c));

        return c;
    }

}