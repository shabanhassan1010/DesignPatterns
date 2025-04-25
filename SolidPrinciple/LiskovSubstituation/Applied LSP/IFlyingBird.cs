using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.LiskovSubstituation.Applied_LSP
{
    public interface IFlyingBird : IBird
    {
        void Fly();
    }
}
