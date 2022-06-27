namespace Laba3_dotnet;

public class Task
{
    public Task(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public void DoTask()
    {
        Console.WriteLine($"Doing task '{Name}'");
        Thread.Sleep(1500);
    }
}