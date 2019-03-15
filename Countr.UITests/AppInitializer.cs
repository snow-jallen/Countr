using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Countr.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android            
                    .EnableLocalScreenshots()
                    .ApkFile("../../../Countr.Droid/bin/Release/com.snow_jallen.Countr-Signed.apk")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}