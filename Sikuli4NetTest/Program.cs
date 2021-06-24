using Sikuli4Net.sikuli_REST;
using Sikuli4Net.sikuli_UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sikuli4NetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            APILauncher launcher = new APILauncher();
            launcher.Start();

            Screen screen = new Screen();

            Pattern windows_search = new Pattern(@"D:\Code\Sikuli4NetTest\Sikuli4NetTest\bin\Debug\windows_search.PNG", 0.5);

            screen.Click(windows_search);
            screen.Type(windows_search, "q", KeyModifier.WIN);
            screen.Type(windows_search, "Calculator");
            Thread.Sleep(3000);
            screen.Type(windows_search, Key.UP);
            screen.Type(windows_search, Key.RIGHT);
            screen.Type(windows_search, Key.RIGHT);
            screen.Type(windows_search, Key.RIGHT);

            launcher.Stop();
        }
    }
}
