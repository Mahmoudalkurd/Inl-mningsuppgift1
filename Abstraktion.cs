abstract public class Car
{
	abstract public void honk();
}

public class SUVCar : Car
{
    public override void honk()
    {
        Console.WriteLine("SUV honks");
    }
}

public class SedanCar : Car
{
    public override void honk()
    {
        Console.WriteLine("Sedan honks");
    }
}
