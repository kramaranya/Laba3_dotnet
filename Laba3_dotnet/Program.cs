namespace Laba3_dotnet;

class Program
{
    public static void Main()
    {
        ProjectCreator systemSoftwareProjectCreator = new SystemSoftwareCreator();
        Project systemSoftwareProject = systemSoftwareProjectCreator.CreateProject("System Software");

        List<Task> systemSoftwareTasks = new List<Task>
        {
            new Task("Planning"),
            new Task("Implementation"),
            new Task("Testing"),
            new Task("Deployment and Maintenance")
        };

        ProjectCreator utilitySoftwareProjectCreator = new UtilitySoftwareCreator();
        Project utilitySoftwareProject = utilitySoftwareProjectCreator.CreateProject("Utility Software");

        List<Task> utilitySoftwareTasks = new List<Task>
        {
            new Task("Assist the operating system to optimize"),
            new Task("Maintain"),
            new Task("Organize"),
            new Task("Manage")
        };

        ProjectCreator applicationSoftwareProjectCreator = new ApplicationSoftwareCreator();
        Project applicationSoftwareProject = applicationSoftwareProjectCreator.CreateProject("Application Software");

        List<Task> applicationSoftwareTasks = new List<Task>
        {
            new Task("Analysis"),
            new Task("Requirements"),
            new Task("Design and Prototyping"),
            new Task("Development"),
            new Task("Testing"),
            new Task("Deployment"),
            new Task("Maintenance"),
            new Task("Waterfall")
        };
        DoProjects doProjects = new DoProjects();

        Console.WriteLine(systemSoftwareProject.ShowProject());
        Console.WriteLine();
        systemSoftwareProject.Tasks = systemSoftwareTasks;
        doProjects.DoProject(systemSoftwareProject);
        Console.WriteLine();

        Console.WriteLine(utilitySoftwareProject.ShowProject());
        Console.WriteLine();
        utilitySoftwareProject.Tasks = utilitySoftwareTasks;
        doProjects.DoProject(utilitySoftwareProject);
        Console.WriteLine();

        Console.WriteLine(applicationSoftwareProject.ShowProject());
        Console.WriteLine();
        applicationSoftwareProject.Tasks = applicationSoftwareTasks;
        doProjects.DoProject(applicationSoftwareProject);
        Console.WriteLine();
    }
}