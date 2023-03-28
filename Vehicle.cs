abstract class Vehicle  // base class (parent) 
{
    public abstract void move();
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        this.Brand = brand;
    }

    public virtual void Honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}