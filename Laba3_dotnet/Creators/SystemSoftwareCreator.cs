namespace Laba3_dotnet;

public class SystemSoftwareCreator : ProjectCreator
{
    public override Project CreateProject(string name)
    {
        return new SystemSoftwareProject(name);
    }
}