class Car : Vehicle  // derived class (child)
{
    public string ModelName { get; set; }

    public Car(string brand, string modelName)
        : base(brand)
    {
        this.ModelName = modelName;
    }

    public override void Honk()
    {
        Console.WriteLine("Buut, Buut!");
    }
}

