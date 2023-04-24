using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ModuleStomping
{
    class ModuleStomping
    {
        static void Main(string[] args)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "notepad",
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            process.Start();
        }
    }
}
