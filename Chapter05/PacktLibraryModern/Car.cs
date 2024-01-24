using Packt.Shared;

public class Car
{
    const int Wheels = 4;
    public bool IsEV { get; set; }
    public string? Make {  get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine($"{Make} {Model} is starting.");
    }
}
