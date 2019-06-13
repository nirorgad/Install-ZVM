using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Install_ZVM
{
    class SelintInstaller
    {


        public void RunInstall(string InstallFileName , string InstallFilePath )
        {
            try
            {
                Console.WriteLine("Starting to install application");
                Process process = new Process();
                process.StartInfo.FileName = InstallFileName;
                process.StartInfo.Arguments = string.Format(" /qb /i \"{0}\" ALLUSERS=1", InstallFilePath);
                process.Start();
                process.WaitForExit();
                Console.WriteLine("Application installed successfully!");
            }
            catch
            {
                Console.WriteLine("There was a problem installing the application!");
            }
        }
    }
}
