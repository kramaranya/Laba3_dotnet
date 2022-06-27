namespace Laba3_dotnet;

public class DoProjects
{
    public void DoProject(Project project)
    {
        Console.WriteLine("Starting...");
        Thread.Sleep(1500);
        project.DoTasks();
        Console.WriteLine("Complete!");
        Thread.Sleep(1500);
    }
}