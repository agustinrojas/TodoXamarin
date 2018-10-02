using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Todo.Test
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("Todo.Android")
                    .PreferIdeSettings()
                    .EnableLocalScreenshots()
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}