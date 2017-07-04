using System;
using System.Windows;

namespace WPFStudy
{
    public class HelloWPF
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Window win = new Window();
            win.Title = "WPF application";
            win.Content = "Hello WPF!";
            Application app = new MainApp();
            app.Run(win);
        }

        public class MainApp : Application
        {
            public MainApp() : base()
            {
                
            }

            protected override void OnActivated(EventArgs e)
            {
                Console.WriteLine("OnActivated");
                base.OnActivated(e);
            }

            protected override void OnExit(ExitEventArgs e)
            {
                Console.WriteLine("OnExit");
                base.OnExit(e);
            }

            protected override void OnDeactivated(EventArgs e)
            {
                Console.WriteLine("OnDeactivated");
                base.OnDeactivated(e);
            }

            protected override void OnStartup(StartupEventArgs e)
            {
                Console.WriteLine("OnStartup");
                base.OnStartup(e);
            }

            protected override void OnSessionEnding(SessionEndingCancelEventArgs e)
            {
                Console.WriteLine("OnSessionEnding");
                base.OnSessionEnding(e);
            }
        }
    }
}
