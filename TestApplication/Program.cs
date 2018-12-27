using System;
using System.Threading.Tasks;
using Squirrel;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/UmerovT/TestApplication"))
            {
                mgr.Result.UpdateApp().Wait();
                mgr.Dispose();
            }

            Console.WriteLine("Hello, Beautiful World!");
            Console.ReadLine();
        }

        
    }
}
