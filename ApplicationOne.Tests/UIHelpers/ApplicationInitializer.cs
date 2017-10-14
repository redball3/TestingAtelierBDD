using System.Diagnostics;
using System.IO;
using ApplicationOne.Tests.Properties;
using TestStack.White;

namespace ApplicationOne.Tests.UIHelpers
{
    internal static class ApplicationInitializer
    {
        private static Application _app;

        public static void InitializeApplication()
        {
            _app = Application.Launch(Path.GetFullPath(Settings.Default.ApplicationOneDirectory));
        }

        public static void TeardownApplication()
        {
            foreach (var process in Process.GetProcessesByName("ApplicationOne"))
            {
                process.Kill();
            }
        }

        public static Application GetApplication()
        {
            return _app;
        }
    }
}
