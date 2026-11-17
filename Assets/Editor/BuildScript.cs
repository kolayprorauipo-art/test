using UnityEditor;
using System;

public class BuildScript
{
    public static void BuildIOS()
    {
        string[] scenes = new string[]
        {
            "Assets/Scenes/level0.unity",
            "Assets/Scenes/level1.unity",
            "Assets/Scenes/level2.unity",
            "Assets/Scenes/level3.unity"
        };
        
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.iOS, ScriptingImplementation.IL2CPP);
        PlayerSettings.iOS.targetDevice = iOSTargetDevice.iPhoneAndiPad;
        PlayerSettings.bundleVersion = "1.6.9";
        PlayerSettings.applicationIdentifier = "com.BorisLub.GrannyModPackbyLub";
        PlayerSettings.productName = "Granny Mod Pack";

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = "Builds/iOS",
            target = BuildTarget.iOS,
            options = BuildOptions.None
        };

        var report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        if (report.summary.result != UnityEditor.Build.Reporting.BuildResult.Succeeded)
        {
            throw new Exception("Build failed with result: " + report.summary.result);
        }
    }
}
