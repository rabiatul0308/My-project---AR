using System.IO;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.Rendering;

public class DirectBuild
{
	public static void BuildAPK()
	{
		string outputDir = "C:/HasilAPK";
		if (!Directory.Exists(outputDir)) Directory.CreateDirectory(outputDir);
		string savePath = outputDir + "/arsriwijaya.apk";

		PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.sriwijaya.arapp");
		PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android, ScriptingImplementation.IL2CPP);
		PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;
		PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel29;
		PlayerSettings.Android.targetSdkVersion = AndroidSdkVersions.AndroidApiLevelAuto;

		// Paksa OpenGLES3 agar Vuforia tidak terganggu peringatan Vulkan
		PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.Android, false);
		PlayerSettings.SetGraphicsAPIs(BuildTarget.Android, new[] { GraphicsDeviceType.OpenGLES3 });

		string[] scenes = new string[]
		{
			"Assets/Scenes/MainMenu.unity",
			"Assets/Scenes/About.unity",
			"Assets/Scenes/Languange.unity",
			"Assets/Scenes/Ringkasan.unity",
			"Assets/Scenes/Panduan.unity",
			"Assets/Scenes/Deskripsi.unity",
			"Assets/Scenes/Developer.unity",
			"Assets/Scenes/Play.unity"
		};

		Debug.Log("=== MEMULAI BUILD KE: " + savePath + " ===");
		BuildReport report = BuildPipeline.BuildPlayer(scenes, savePath, BuildTarget.Android, BuildOptions.None);

		if (report.summary.result == BuildResult.Succeeded)
			Debug.Log("=== BUILD BERHASIL! ===");
		else
		{
			Debug.LogError("=== BUILD GAGAL: " + report.summary.result + " | Error: " + report.summary.totalErrors + " ===");
			foreach (var step in report.steps)
				foreach (var msg in step.messages)
					if (msg.type == LogType.Error || msg.type == LogType.Exception)
						Debug.LogError("[" + step.name + "] " + msg.content);
		}
	}
}