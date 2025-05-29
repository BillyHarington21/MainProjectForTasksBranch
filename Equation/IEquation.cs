using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    public interface IEquation
    {
        void Roots();
        string Name { get; }
        string Parameters { get; }
    }
}
