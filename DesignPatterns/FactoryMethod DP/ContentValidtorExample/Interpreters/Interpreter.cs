using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod_DP.ContentValidtorExample
{
    public abstract class Interpreter
    {
        protected string Content;

        protected Interpreter(string content)
        {
            Content = content;
        }

        public string GetContent()
        {
            return Content;
        }

        public abstract bool Validate();
        public abstract void Parse();
        public abstract void Compile();
    }

}
