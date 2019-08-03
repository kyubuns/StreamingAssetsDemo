using System.IO;
using UnityEngine;

namespace StreamingAssetsDemo
{
    public class PlaceAssetBundle : MonoBehaviour
    {
        [SerializeField] private string assetBundleName = default;
        [SerializeField] private string assetName = default;

        public void Start()
        {
            var path = Path.Combine(Application.streamingAssetsPath, "AssetBundles", assetBundleName);
            var bytes = File.ReadAllBytes(path);
            var assetBundle = AssetBundle.LoadFromMemory(bytes);
            var prefab = assetBundle.LoadAsset(assetName);
            Instantiate(prefab, transform);
        }
    }
}
