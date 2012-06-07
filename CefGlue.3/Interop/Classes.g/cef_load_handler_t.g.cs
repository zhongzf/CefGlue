//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_load_handler_t
    {
        internal cef_base_t _base;
        internal IntPtr _on_load_start;
        internal IntPtr _on_load_end;
        internal IntPtr _on_load_error;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int add_ref_delegate(cef_load_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_load_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_refct_delegate(cef_load_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_load_start_delegate(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_load_end_delegate(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, int httpStatusCode);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_load_error_delegate(cef_load_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, CefHandlerErrorCode errorCode, cef_string_t* errorText, cef_string_t* failedUrl);
        
        private static int _sizeof;
        
        static cef_load_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_load_handler_t));
        }
        
        internal static cef_load_handler_t* Alloc()
        {
            var ptr = (cef_load_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_load_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_load_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
