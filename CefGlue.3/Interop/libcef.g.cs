//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using System.Diagnostics.CodeAnalysis;
    
    internal static unsafe partial class libcef
    {
        // CefExecuteProcess
        [DllImport(libcef.DllName, EntryPoint = "cef_execute_process", CallingConvention = libcef.CEF_CALL)]
        public static extern int execute_process(cef_main_args_t* args, cef_app_t* application);
        
        // CefInitialize
        [DllImport(libcef.DllName, EntryPoint = "cef_initialize", CallingConvention = libcef.CEF_CALL)]
        public static extern int initialize(cef_main_args_t* args, cef_settings_t* settings, cef_app_t* application);
        
        // CefShutdown
        [DllImport(libcef.DllName, EntryPoint = "cef_shutdown", CallingConvention = libcef.CEF_CALL)]
        public static extern void shutdown();
        
        // CefDoMessageLoopWork
        [DllImport(libcef.DllName, EntryPoint = "cef_do_message_loop_work", CallingConvention = libcef.CEF_CALL)]
        public static extern void do_message_loop_work();
        
        // CefRunMessageLoop
        [DllImport(libcef.DllName, EntryPoint = "cef_run_message_loop", CallingConvention = libcef.CEF_CALL)]
        public static extern void run_message_loop();
        
        // CefQuitMessageLoop
        [DllImport(libcef.DllName, EntryPoint = "cef_quit_message_loop", CallingConvention = libcef.CEF_CALL)]
        public static extern void quit_message_loop();
        
        // CefAddCrossOriginWhitelistEntry
        [DllImport(libcef.DllName, EntryPoint = "cef_add_cross_origin_whitelist_entry", CallingConvention = libcef.CEF_CALL)]
        public static extern int add_cross_origin_whitelist_entry(cef_string_t* source_origin, cef_string_t* target_protocol, cef_string_t* target_domain, int allow_target_subdomains);
        
        // CefRemoveCrossOriginWhitelistEntry
        [DllImport(libcef.DllName, EntryPoint = "cef_remove_cross_origin_whitelist_entry", CallingConvention = libcef.CEF_CALL)]
        public static extern int remove_cross_origin_whitelist_entry(cef_string_t* source_origin, cef_string_t* target_protocol, cef_string_t* target_domain, int allow_target_subdomains);
        
        // CefClearCrossOriginWhitelist
        [DllImport(libcef.DllName, EntryPoint = "cef_clear_cross_origin_whitelist", CallingConvention = libcef.CEF_CALL)]
        public static extern int clear_cross_origin_whitelist();
        
        // CefRegisterSchemeHandlerFactory
        [DllImport(libcef.DllName, EntryPoint = "cef_register_scheme_handler_factory", CallingConvention = libcef.CEF_CALL)]
        public static extern int register_scheme_handler_factory(cef_string_t* scheme_name, cef_string_t* domain_name, cef_scheme_handler_factory_t* factory);
        
        // CefClearSchemeHandlerFactories
        [DllImport(libcef.DllName, EntryPoint = "cef_clear_scheme_handler_factories", CallingConvention = libcef.CEF_CALL)]
        public static extern int clear_scheme_handler_factories();
        
        // CefCurrentlyOn
        [DllImport(libcef.DllName, EntryPoint = "cef_currently_on", CallingConvention = libcef.CEF_CALL)]
        public static extern int currently_on(CefThreadId threadId);
        
        // CefPostTask
        [DllImport(libcef.DllName, EntryPoint = "cef_post_task", CallingConvention = libcef.CEF_CALL)]
        public static extern int post_task(CefThreadId threadId, cef_task_t* task);
        
        // CefPostDelayedTask
        [DllImport(libcef.DllName, EntryPoint = "cef_post_delayed_task", CallingConvention = libcef.CEF_CALL)]
        public static extern int post_delayed_task(CefThreadId threadId, cef_task_t* task, long delay_ms);
        
        // CefParseURL
        [DllImport(libcef.DllName, EntryPoint = "cef_parse_url", CallingConvention = libcef.CEF_CALL)]
        public static extern int parse_url(cef_string_t* url, cef_urlparts_t* parts);
        
        // CefCreateURL
        [DllImport(libcef.DllName, EntryPoint = "cef_create_url", CallingConvention = libcef.CEF_CALL)]
        public static extern int create_url(cef_urlparts_t* parts, cef_string_t* url);
        
        // CefRegisterExtension
        [DllImport(libcef.DllName, EntryPoint = "cef_register_extension", CallingConvention = libcef.CEF_CALL)]
        public static extern int register_extension(cef_string_t* extension_name, cef_string_t* javascript_code, cef_v8handler_t* handler);
        
        // CefVisitWebPluginInfo
        [DllImport(libcef.DllName, EntryPoint = "cef_visit_web_plugin_info", CallingConvention = libcef.CEF_CALL)]
        public static extern void visit_web_plugin_info(cef_web_plugin_info_visitor_t* visitor);
        
    }
}
