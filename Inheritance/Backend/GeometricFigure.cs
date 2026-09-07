namespace Backend;

public abstract class GeometricFigure
{

    //Constructor
    protected GeometricFigure(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name)); ;
    }

    //Propieties
    public string Name { get; private set; }


    //Public Methods
    

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString()
    {

        {
            return $"{Name,-13} => Area.....: {GetArea(),15:N5}   Perimeter: {GetPerimeter(),15:N5}";
        }
   
    }


}
            
    

