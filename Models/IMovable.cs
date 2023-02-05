namespace VpuDotNet2.Models;

public interface IMovable
{
    public double Speed { get; set; }

    public void Move();
}

public class Human : IMovable
{
    public double Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Human moves with speed: " + this.Speed);
    }
}

public class Car : IMovable
{
    public double Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Car moves with speed: " + this.Speed);
    }
}