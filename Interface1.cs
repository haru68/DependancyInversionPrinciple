using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace PrincipeInversionDependance
{
    public interface Interface1
    {
        public bool Exited { get; set; }

        public abstract string Prompt();
        public abstract Command PromptCommand();
        public abstract void ExecuteCommand(Command command);




    }
}
