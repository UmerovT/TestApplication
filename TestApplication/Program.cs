using System;
using System.Threading.Tasks;
using Squirrel;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {

           Task.Run(async () => Update());

            Console.WriteLine("Hello, Beautiful World!");
            Console.ReadLine();
        }

        public static async void Update()
        {
            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/UmerovT/TestApplication"))
            {
                await mgr.Result.UpdateApp();                         
            }
        }
    }
}
