using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WixSharp;

namespace WixDir
{
    class Program
    {
        static void Main(string[] args)
        {
            var project = new ManagedProject()
            {
                Dirs = new[]
                {
                    new Dir(@"%ProgramFiles%\WixDirSample", new Files(@"install_files\*.*"))
                }
            };

            project.BuildMsiCmd();
        }
    }
}
