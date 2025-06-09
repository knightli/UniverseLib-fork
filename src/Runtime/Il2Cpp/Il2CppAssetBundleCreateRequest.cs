using System;

namespace UniverseLib.Runtime.Il2Cpp
{
    public class Il2CppAssetBundleCreateRequest : UnityEngine.Object
    {
        public Il2CppAssetBundleCreateRequest(IntPtr ptr) : base(ptr) { }

        // isDone 属性
        public bool IsDone
        {
            get
            {
                var method = this.GetMethodInfo("get_isDone");
                return (bool)method.Invoke(this, null);
            }
        }

        // assetBundle 属性
        public AssetBundle AssetBundle
        {
            get
            {
                var method = this.GetMethodInfo("get_assetBundle");
                var result = method.Invoke(this, null);
                return result != null ? new AssetBundle(result.Pointer()) : null;
            }
        }
    }
}