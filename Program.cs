using System;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace PrincipeInversionDependance
{
    public class Program
    {
        public static void Main()
        {
            Interface1 terminal = new Terminal();
            while (!terminal.Exited)
            {
                Command command = terminal.PromptCommand();
                terminal.ExecuteCommand(command);
            }
        }
    }
}



