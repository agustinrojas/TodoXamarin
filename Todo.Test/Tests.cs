using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Todo.Test
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        static readonly Func<AppQuery, AppQuery> SaveButton = c => c.Button().Marked("ButtonSave");
        static readonly Func<AppQuery, AppQuery> NewElement = c => c.Text("Hoooooola");


        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
           // app.Repl();
            app.Tap("Add");
            app.Tap("NameText");
            app.EnterText("Hoooooola");
            app.Tap("NotesText");
            app.EnterText("Nooooootes");
            app.DismissKeyboard();
            app.Tap(SaveButton);

            app.Tap(NewElement);
            app.Tap("CheckDone");
            app.Tap("ButtonSave");
            app.Back();
        }
    }
}
