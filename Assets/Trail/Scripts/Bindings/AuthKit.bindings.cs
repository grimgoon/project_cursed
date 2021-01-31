using System;
using System.Runtime.InteropServices;

namespace Trail
{
    public static partial class AuthKit
    {
        [DllImport(Common.DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern Result trail_sdk_get_game_user_id(
            IntPtr sdk,
            [Out, MarshalAs(UnmanagedType.LPStruct)] UUID id
        );

        [DllImport(Common.DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern Result trail_sdk_get_play_token(
            IntPtr sdk,
            out IntPtr play_token,
            out Int32 play_token_length
        );

        [DllImport(Common.DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern Result trail_sdk_get_username(
            IntPtr sdk,
            out IntPtr username,
            out Int32 username_length
        );
    }
}
