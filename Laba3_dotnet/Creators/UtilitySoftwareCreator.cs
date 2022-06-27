namespace Laba3_dotnet;

public class UtilitySoftwareCreator : ProjectCreator
{
    public override Project CreateProject(string name)
    {
        return new UtilitySoftwareProject(name);
    }
}