using System;
using System.Diagnostics;


namespace Install_ZVM
{
    class SelintInstaller
    {


        public void RunInstall(string vmType , string InstallFilePath )
        {

            if (vmType.Contains("ZVM"))
            {
                try
                {
                    Console.WriteLine("Starting to install Zerto ZVM application");
                    Process process = new Process();
                    process.StartInfo.FileName = "Zerto Virtual Replication VMware Installer.exe";
                    process.StartInfo.Arguments = string.Format(" /qb /i \"{0}\" ALLUSERS=1", InstallFilePath);
                    process.Start();
                    process.WaitForExit();
                    Console.WriteLine("Application installed successfully!");
                }
                catch
                {
                    Console.WriteLine("There was a problem installing the application!");
                }
            }else if(vmType.Contains("ZCA"))
                try
                {
                    Console.WriteLine("Starting to install Zerto ZCA application");
                    Process process = new Process();
                    process.StartInfo.FileName = "Zerto ZCA AWS Installer.exe";
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
