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
            Application app = new Application();
            app.Run(win);
        }
    }
}
