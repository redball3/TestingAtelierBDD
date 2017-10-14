using System.Diagnostics;
using System.IO;
using ApplicationTwo.Tests.Properties;
using TestStack.White;

namespace ApplicationTwo.Tests.UIHelpers
{
    internal static class ApplicationInitializer
    {
        private static Application _app;

        public static void InitializeApplication()
        {
            _app = Application.Launch(Path.GetFullPath(Settings.Default.ApplicationTwoLocation));
        }

        public static void TeardownApplication()
        {
            foreach (var process in Process.GetProcessesByName("ApplicationTwo"))
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
