using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace StreamingAssetsDemo.Editor
{
    public static class BuildAssetBundle
    {
        [MenuItem("Build/AssetBundle")]
        public static void Run()
        {
            var outputPath = Path.Combine(Application.dataPath, "StreamingAssets", "AssetBundles");
            Debug.Log($"Build AssetBundle to {outputPath}");

            const BuildAssetBundleOptions options = BuildAssetBundleOptions.StrictMode;
            var manifest = BuildPipeline.BuildAssetBundles(outputPath, options, EditorUserBuildSettings.activeBuildTarget);
            if (manifest == null) throw new Exception("BuildAssetBundle Error");

            Debug.Log("Build AssetBundle Complete!");
        }
    }
}
