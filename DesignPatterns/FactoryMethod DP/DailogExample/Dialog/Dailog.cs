using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethod_DP.Buttons;

namespace DesignPatterns.FactoryMethod_DP.Dialog
{
    public abstract class Dialog
    {
        public abstract Button CreatedButton();
        public string RenderDialog()
        {
            Button button = CreatedButton();
            return $@"
            {button.Show()}
            ";
        }
    }
}
