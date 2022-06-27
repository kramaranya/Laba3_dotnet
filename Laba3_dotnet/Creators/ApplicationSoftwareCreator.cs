namespace Laba3_dotnet;

public class ApplicationSoftwareCreator : ProjectCreator
{
    public override Project CreateProject(string name)
    {
        return new ApplicationSoftwareProject(name);
    }
}