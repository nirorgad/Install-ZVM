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
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.WorkingDirectory = @InstallFilePath;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "'Zerto Virtual Replication VMware Installer.exe' -s";
                    process.Start();
                    process.WaitForExit();
                    Console.WriteLine("Zerto ZVM Application installed successfully!");
                }
                catch
                {
                    Console.WriteLine("There was a problem installing the Zerto ZVMapplication!");
                }
            }else if(vmType.Contains("ZCA"))
                try
                {
                    Console.WriteLine("Starting to install Zerto ZCA application");
                    Process process = new Process();
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.WorkingDirectory = @InstallFilePath;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "'Zerto ZCA AWS Installer.exe' -s";
                    process.Start();
                    process.WaitForExit();
                    Console.WriteLine("Zerto ZCA Application installed successfully!");
                }
                catch
                {
                    Console.WriteLine("There was a problem installing the Zerto ZCA application!");
                }
        }
    }
}
