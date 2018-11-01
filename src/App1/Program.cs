using System;
using Lib1;
using McMaster.NETCore.Plugins;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Lib1.Class1();
            new Lib2.Class1();

            PluginLoader.CreateFromAssemblyFile(typeof(Program).Assembly.Location);
        }
    }
}
