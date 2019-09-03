#addin "Cake.Incubator&version=5.0.1"

using System;
using System.Diagnostics;

var sourceDir = "../src/Ensure";
var project = GetFiles(sourceDir + "/Ensure.csproj").FirstOrDefault();

var target = Argument("target", "Default");
var publishDir = "../publishdir";
string version = "1.0.0";

Task("Default")
    .IsDependentOn("Build");

Task("Restore")
    .Does(() =>
    {
        DotNetCoreRestore(project.ToString());
    });

Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
{
    DotNetCoreBuildSettings settings = new DotNetCoreBuildSettings
    {
        NoRestore = true,
        Configuration = "Release"
    };
    
    DotNetCoreBuild(project.ToString(), settings);
});

Task("Nuget-Pack")
    .Description("Publish to nuget")
    .Does(() =>
    {
        var settings = new DotNetCorePackSettings
        {
            Configuration = "Release",
            WorkingDirectory = sourceDir,
            OutputDirectory = "../artifacts"
        };

        DotNetCorePack("Ensure.csproj", settings);
    });


RunTarget(target);