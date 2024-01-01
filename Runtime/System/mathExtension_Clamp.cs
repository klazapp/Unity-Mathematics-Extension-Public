using System;
using System.Runtime.CompilerServices;

namespace com.Klazapp.Utility
{
    public static partial class mathExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int clampToAboveValue(int val, int clampVal)
        {
            val = val < clampVal ? clampVal : val;
            return val;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int clampToBelowValue(int val, int clampVal)
        {
            val = val > clampVal ? clampVal : val;
            return val;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float clampToBelowValue(float val, float clampVal)
        {
            val = val > clampVal ? clampVal : val;
            return val;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float clampToAboveValue(float val, float clampVal)
        {
            val = val < clampVal ? clampVal : val;
            return val;
        }
    }
}