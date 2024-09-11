public class  Person 

{
    public string name;
    public int age;

    public void Work()
    {
        Console.WriteLine($"{name} is working");
    }
}

public class Manager: Person
{
    public string role;

    public override void Work()
    {
        Console.WriteLine($"{name} is working as a {role}");
    }
}
