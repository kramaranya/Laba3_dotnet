﻿namespace Laba3_dotnet;

public class UtilitySoftwareProject : Project
{
    public UtilitySoftwareProject(string name) : base(name)
    {
    }

    public override void DoTasks()
    {
        if (Tasks != null)
        {
            foreach (var task in Tasks)
            {
                task.DoTask();
            }
        }
        else Console.WriteLine("There was no Task");
    }
}