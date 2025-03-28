using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod_DP.ContentValidtorExample.AppViewer
{
    public abstract class AppViewer
    {
        public abstract Interpreter CreateInterpreter();

        public string ViewContentOnScreen()
        {
            Interpreter interpreter = CreateInterpreter();
            if (interpreter.Validate())
            {
                interpreter.Parse();
                interpreter.Compile();
                return interpreter.GetContent();
            }
            return "Invalid content to show";
        }
    }
}
