

public class GymClass
{
	private string name;
	private int duration;

	public GymClass(string name, int duration)
	{
		Name = name;
		Duration = duration;
	}

	public string Name {  
		get { return name; } 
		set { name = value; } 
	}

	public int Duration
	{
		get { return duration; }
		set { duration = value; }
	}
}
