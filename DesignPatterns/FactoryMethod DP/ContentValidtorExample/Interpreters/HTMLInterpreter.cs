using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod_DP.ContentValidtorExample.Interpreters
{
    public class HTMLInterpreter : Interpreter
    {
        public HTMLInterpreter(string content) : base(content) { }

        public override bool Validate()
        {
            return Regex.IsMatch(Content, "<DOCTYPE html>", RegexOptions.IgnoreCase);
        }

        public override void Parse()
        {
            // Parsing the html string
        }

        public override void Compile()
        {
            // Compile the AST
        }
    }
}
