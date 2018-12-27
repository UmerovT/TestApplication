using System;
using System.Threading.Tasks;
using Squirrel;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(
            async () =>
            {
                using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/UmerovT/TestApplication"))
                {
                    await mgr.UpdateApp();
                }
            });
            
            Console.WriteLine("Hello, Beautiful World!");
            Console.ReadLine();
        }
    }
}
