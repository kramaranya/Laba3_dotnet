namespace Laba3_dotnet;

public abstract class Project
{
    public string Name { get; set; }
    public List<Task>? Tasks;
    public abstract void DoTasks();

    protected Project(string name)
    {
        Name = name;
    }
    public string ShowProject()
    {
        return $"Project: {Name}";
    }
}