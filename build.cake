#addin "wk.StartProcess"
#addin "wk.ProjectParser"

using PS = StartProcess.Processor;
using ProjectParser;

var name = "Circle";
var publishDir = ".publish/W";
var version = DateTime.Now.ToString("yy.MM.dd.HHmm");

Task("Publish").Does(() => {
    var settings = new DotNetCoreMSBuildSettings();
    settings.Properties["Version"] = new string[] { version };

    CleanDirectory(publishDir);
    DotNetCorePublish($"src/{name}", new DotNetCorePublishSettings {
        OutputDirectory = publishDir,
        MSBuildSettings = settings
    });
});

var target = Argument("target", "Pack");
RunTarget(target);
