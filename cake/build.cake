#addin "Cake.Incubator&version=5.0.1"

using System;
using System.Diagnostics;

var sourceDir = "../src/Ensure";
var testDir = "../tests";
var project = GetFiles(sourceDir + "/Ensure.csproj").FirstOrDefault();
var testProject = GetFiles(testDir + "/**/*.csproj").FirstOrDefault();

var target = Argument("target", "Default");
var publishDir = "../publishdir";
string version = "1.0.0";

Task("Default")
    .IsDependentOn("Test");

Task("Restore")
    .Does(() =>
    {
        DotNetCoreRestore(project.ToString());
    });

Task("Restore-Test")
    .Does(() =>
    {
        DotNetCoreRestore(testProject.ToString());
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

Task("Build-Test")
    .IsDependentOn("Restore-Test")
    .Does(() => {
        DotNetCoreBuildSettings settings = new DotNetCoreBuildSettings
        {
            NoRestore = true,
            Configuration = "Release"
        };
    
        DotNetCoreBuild(testProject.ToString(), settings);
    });

Task("Test")
    .IsDependentOn("Build")
    .IsDependentOn("Build-Test")
    .Does(() => {
        DotNetCoreTestSettings settings = new DotNetCoreTestSettings
        {
            Configuration = "Release",
            NoBuild = true
        };

        DotNetCoreTest(testProject.FullPath, settings);
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