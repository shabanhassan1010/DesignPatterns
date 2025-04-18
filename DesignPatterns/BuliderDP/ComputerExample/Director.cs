using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample
{
    public class Director
    {
        private Builder _builder;

        public Director(Builder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(Builder builder)
        {
            _builder = builder;
        }

        public Computer MakeComputer()
        {
            return _builder.GetComputer();
        }
    }
}
