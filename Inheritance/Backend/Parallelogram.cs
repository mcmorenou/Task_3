namespace Backend;

public class Parallelogram : Rectangle


{
    // Fields
    private double _h;

    // Constructors
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    // Properties
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    // Public Methods
    public override double GetArea()
    {
        return H * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    // Private Methods
    private double ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException("H must be greater than zero.", nameof(h));

        return h;
    }
}