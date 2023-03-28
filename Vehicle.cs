class Vehicle  // base class (parent) 
{
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