using System;
using Il2CppInterop.Runtime.InteropTypes;

namespace UniverseLib.Runtime.Il2Cpp
{
    public static class Il2CppObjectBaseToPtr
    {
        public static IntPtr Pointer(this object obj)
        {
            return (IntPtr)typeof(Il2CppObjectBase)
                .GetProperty("Pointer", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.GetValue(obj, null);
        }
    }
}