using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApplication1;
using System.IO;
using System.Net;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.ObjectModel;


namespace GitCommit
{
    class Program
    {
        static void Main(string[] args)
        {
            //string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            //Console.WriteLine(projectPath);
            ////Process.Start("cmd", "");
            ////Process prc = new Process();
            ////prc.Start();
            ////prc.StartInfo.FileName = "C://Program Files//Git//bin//git.exe";
            ////prc.StartInfo.Arguments = "cd " + projectPath;
            ////prc.Start();
            //Process.Start("cmd", @"cd " + projectPath);
            //Thread.Sleep(5000);
            ////StreamReader stream =  Process.GetCurrentProcess().StandardOutput;
            ////Console.WriteLine(stream.ToString());
            ////Thread.Sleep(10000);

            //string url = "https://github.com/samin-batra/Dorm_Room_Hackathon";
            //Process p = new Process();
            //ProcessStartInfo info = new ProcessStartInfo();
            //info.FileName = "cmd.exe";
            //info.RedirectStandardInput = true;
            //info.UseShellExecute = false;

            //p.StartInfo = info;
            //p.Start();

            //using (StreamWriter sw = p.StandardInput)
            //{
            //    if (sw.BaseStream.CanWrite)
            //    {
            //        sw.WriteLine("cd " + projectPath);
            //        Thread.Sleep(4000);
            //        //sw.WriteLine("git init");
            //        Thread.Sleep(4000);
            //        sw.WriteLine("git add .");
            //        //Thread.Sleep(5000);
            //        //sw.WriteLine("git remote add origin https://github.com/samin-batra/Dorm_Room_Hackathon.git");
            //        Thread.Sleep(5000);
            //        //sw.WriteLine("git remote -v");
            //        //Thread.Sleep(4000);

            //        //string command = "git commit -m \"intial commit\"";
            //        sw.WriteLine("git commit -m \"first commit\"");
            //        // Thread.Sleep(4000);
            //        Thread.Sleep(4000);
            //        sw.WriteLine("git push -u origin master");
            //        Thread.Sleep(4000);

            //    }
            //}

            ////prc.StartInfo.FileName = "C:/Program Files/Git/bin/git.exe";

            ////prc.StartInfo.Arguments = "git init";
            ////prc.Start();
            //// Process.Start("C://Program Files//Git//bin//Git.exe",@"init");
            ////Thread.Sleep(10000);
            //// prc.StartInfo.FileName = "C://Program Files//Git//bin//git.exe";
            ////prc.StartInfo.Arguments = "git commit -m 'First Commit'";
            ////prc.Start();
            ////Process.Start("C://Program Files//Git//bin//Git.exe","commit -m 'First Commit'");
            ////prc.StartInfo.FileName = "C://Program Files//Git//bin//git.exe";
            //// prc.StartInfo.Arguments = "git remote add origin  'https://github.com/samin-batra/Dorm_Room_Hackathon.git'";
            //// prc.Start();
            ////Process.Start("C://Program Files//Git//bin//Git.exe","remote add origin 'https://github.com/samin-batra/Dorm_Room_Hackathon.git'");
            ////prc.StartInfo.FileName = "C://Program Files//Git//bin//git.exe";
            ////prc.StartInfo.Arguments = "git remote -v";
            ////prc.Start();
            ////Process.Start("C://Program Files//Git//bin//Git.exe","remote -v");
            ////prc.StartInfo.FileName = "C://Program Files//Git//bin//git.exe";
            ////prc.StartInfo.Arguments = "git push origin master";
            ////prc.Start();
            ////Process.Start("C://Program Files//Git//bin//Git.exe", "push origin master");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void TFSToGit(string TFSUrl, string GitUrl)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            Console.WriteLine(projectPath);
            //Code for getting data from TFS.
            //Uri tfsUri = 
            //  new Uri(TFSUrl) ;

            //TfsConfigurationServer configurationServer =
            //    TfsConfigurationServerFactory.GetConfigurationServer(tfsUri);

            //// Get the catalog of team project collections
            //ReadOnlyCollection<CatalogNode> collectionNodes = configurationServer.CatalogNode.QueryChildren(
            //    new[] { CatalogResourceTypes.ProjectCollection },
            //    false, CatalogQueryOptions.None);

            //// List the team project collections
            //foreach (CatalogNode collectionNode in collectionNodes)
            //{
            //    // Use the InstanceId property to get the team project collection
            //    Guid collectionId = new Guid(collectionNode.Resource.Properties["InstanceId"]);
            //    TfsTeamProjectCollection teamProjectCollection = configurationServer.GetTeamProjectCollection(collectionId);

            //    // Print the name of the team project collection
            //    Console.WriteLine("Collection: " + teamProjectCollection.Name);

            //    // Get a catalog of team projects for the collection
            //    ReadOnlyCollection<CatalogNode> projectNodes = collectionNode.QueryChildren(
            //        new[] { CatalogResourceTypes.TeamProject },
            //        false, CatalogQueryOptions.None);

            //    // List the team projects in the collection
            //    foreach (CatalogNode projectNode in projectNodes)
            //    {
            //        Console.WriteLine(" Team Project: " + projectNode.Resource.DisplayName);
            //    }

            //}



            Process.Start("cmd", @"cd " + projectPath);
            Thread.Sleep(5000);
            //StreamReader stream =  Process.GetCurrentProcess().StandardOutput;
            //Console.WriteLine(stream.ToString());
            //Thread.Sleep(10000);

            //string url = "https://github.com/samin-batra/Dorm_Room_Hackathon";
            string url = GitUrl;
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
                    //sw.WriteLine("git init");
                    Thread.Sleep(4000);
                    sw.WriteLine("git add .");
                    //Thread.Sleep(5000);
                    //sw.WriteLine("git remote add origin https://github.com/samin-batra/Dorm_Room_Hackathon.git");
                    Thread.Sleep(5000);
                    //sw.WriteLine("git remote -v");
                    //Thread.Sleep(4000);

                    //string command = "git commit -m \"intial commit\"";
                    sw.WriteLine("git commit -m \"first commit\"");
                    // Thread.Sleep(4000);
                    Thread.Sleep(4000);
                    sw.WriteLine("git push -u origin master");
                    Thread.Sleep(4000);


                }

            }
            p.Close();
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

        public static void GitToTFS(string GitUrl, string TFSUrl)
        {
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
                    //sw.WriteLine("cd " + projectPath);
                    //Thread.Sleep(4000);
                    //sw.WriteLine("git init");
                    //Thread.Sleep(4000);
                    sw.WriteLine("git clone " + GitUrl);
                    //Thread.Sleep(5000);
                    //sw.WriteLine("git remote add origin https://github.com/samin-batra/Dorm_Room_Hackathon.git");
                    Thread.Sleep(5000);
                    //sw.WriteLine("git remote -v");
                    //Thread.Sleep(4000);

                    //string command = "git commit -m \"intial commit\"";
                    //sw.WriteLine("git commit -m \"first commit\"");
                    // Thread.Sleep(4000);
                    //Thread.Sleep(4000);
                    //sw.WriteLine("git push -u origin master");
                    //Thread.Sleep(4000);
                }

            }

        }

    }
}
