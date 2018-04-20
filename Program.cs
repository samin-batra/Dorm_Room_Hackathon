using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace GitCommit
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            //Process.Start("cmd", "");
            //Process prc = new Process();
            //prc.Start();
            //prc.StartInfo.FileName = "C://Program Files//Git//bin//git.exe";
            //prc.StartInfo.Arguments = "cd " + projectPath;
            //prc.Start();
            Process.Start("cmd", @"cd " + projectPath);
            Thread.Sleep(5000);
            //StreamReader stream =  Process.GetCurrentProcess().StandardOutput;
            //Console.WriteLine(stream.ToString());
            //Thread.Sleep(10000);

            string url = "https://github.com/samin-batra/Dorm_Room_Hackathon";
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            p.StartInfo = info;
            p.Start();
            
            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd " + projectPath);
                    Thread.Sleep(4000);
                    sw.WriteLine("git init");
                    Thread.Sleep(4000);
                    sw.WriteLine("git add .");
                    //Thread.Sleep(5000);
                    
                    sw.WriteLine("git commit -m 'first commit'");
                    Thread.Sleep(4000);
                    sw.WriteLine("git remote add origin https://github.com/samin-batra/Dorm_Room_Hackathon.git");
                    Thread.Sleep(4000);
                    //sw.WriteLine("git remote -v");
                    Thread.Sleep(4000);
                    sw.WriteLine("git push -u origin master");
                    Thread.Sleep(4000);
                }
            }

            //prc.StartInfo.FileName = "C:/Program Files/Git/bin/git.exe";

            //prc.StartInfo.Arguments = "git init";
            //prc.Start();
           // Process.Start("C://Program Files//Git//bin//Git.exe",@"init");
            //Thread.Sleep(10000);
            // prc.StartInfo.FileName = "C://Program Files//Git//bin//git.exe";
            //prc.StartInfo.Arguments = "git commit -m 'First Commit'";
            //prc.Start();
           //Process.Start("C://Program Files//Git//bin//Git.exe","commit -m 'First Commit'");
            //prc.StartInfo.FileName = "C://Program Files//Git//bin//git.exe";
           // prc.StartInfo.Arguments = "git remote add origin  'https://github.com/samin-batra/Dorm_Room_Hackathon.git'";
           // prc.Start();
            //Process.Start("C://Program Files//Git//bin//Git.exe","remote add origin 'https://github.com/samin-batra/Dorm_Room_Hackathon.git'");
            //prc.StartInfo.FileName = "C://Program Files//Git//bin//git.exe";
            //prc.StartInfo.Arguments = "git remote -v";
            //prc.Start();
            //Process.Start("C://Program Files//Git//bin//Git.exe","remote -v");
            //prc.StartInfo.FileName = "C://Program Files//Git//bin//git.exe";
            //prc.StartInfo.Arguments = "git push origin master";
            //prc.Start();
            //Process.Start("C://Program Files//Git//bin//Git.exe", "push origin master");
        }
    }
}
