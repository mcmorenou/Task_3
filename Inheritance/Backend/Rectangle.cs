namespace Backend;

public class Rectangle : Square


{
    // Fields
    private double _b;

    // Constructors
    public Rectangle(string name, double a, double b) : base(name,a)
    {
        B = b;
    }

    // Properties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    // Public Methods
    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 *( A + B);
    }

    // Private Methods
    private double ValidateB(double b)
    {
        if (b <= 0)
            throw new ArgumentException("B must be greater than zero.", nameof(b));

        return b;
    }
}