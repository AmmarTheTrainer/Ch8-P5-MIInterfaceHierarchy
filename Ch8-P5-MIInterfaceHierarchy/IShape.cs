using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P5_MIInterfaceHierarchy
{
    // Multiple Interface Inheritance , Ok
    public interface IShape : IDrawable , IPrintable
    {
        int GetNumberOfSides();
    }
}
