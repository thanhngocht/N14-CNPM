using THE_COOKY_APP.GUI.LOGIN;
using THE_COOKY_APP.GUI.CHEF;
using THE_COOKY_APP.GUI.CLASSROOM;
using THE_COOKY_APP.GUI.LOCATION;
using THE_COOKY_APP.GUI.TOPIC;
using THE_COOKY_APP.GUI.ACCOUNT;
using THE_COOKY_APP.GUI.HOME;
using THE_COOKY_APP.GUI.STUDENT;
using THE_COOKY_APP.GUI.PROFILE;

namespace THE_COOKY_APP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}