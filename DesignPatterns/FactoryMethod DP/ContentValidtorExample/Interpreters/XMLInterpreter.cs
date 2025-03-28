using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod_DP.ContentValidtorExample.Interpreters
{
    public class XMLInterpreter : Interpreter
    {
        public XMLInterpreter(string content) : base(content) { }

        public override bool Validate()
        {
            return Regex.IsMatch(Content, @"<\?xml", RegexOptions.IgnoreCase);
        }

        public override void Parse()
        {
            // Parsing the xml content
        }

        public override void Compile()
        {
            // Compile the AST
        }
    }
}
