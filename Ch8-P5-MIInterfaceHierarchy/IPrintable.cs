using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P5_MIInterfaceHierarchy
{
    public interface IPrintable
    {
        void Print();
        void Draw(); // <-- Note possible name clash here!
    }
}
