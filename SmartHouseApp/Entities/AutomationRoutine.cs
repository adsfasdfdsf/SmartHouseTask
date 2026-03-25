namespace SmartHomeMVP;

public class AutomationRoutine
{
    public string Description { get; private set; }
	
    public AutomationRoutine(string description)
    {
        Description = description;
    }
	
    public void Execute()
    {
        Console.WriteLine("Executing Automation Routine:");
        Console.WriteLine(Description);
    }

    public AutomationRoutine Clone()
    {
        return new AutomationRoutine(Description);
    }
}