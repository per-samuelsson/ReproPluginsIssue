
using System;
using System.IO;
using System.Reflection;
using McMaster.NETCore.Plugins;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            var webAppPath = Path.GetFullPath(
                Path.Combine("..", "AspNetCoreWebApp", "bin", "Debug", "netcoreapp2.1", "AspNetCoreWebApp.dll"));
            
            if (!File.Exists(webAppPath))
            {
                Console.Error.WriteLine($"Unable to find web app to load: {webAppPath}");
                Environment.Exit(1);
            }

            var app = PluginLoader.CreateFromAssemblyFile(webAppPath).LoadDefaultAssembly();
            try
            {
                app.EntryPoint.Invoke(null, new object[] { new string[] { } });
            }
            catch (TargetInvocationException e)
            {
                Console.WriteLine(e.InnerException);
            }
        }
    }
}
