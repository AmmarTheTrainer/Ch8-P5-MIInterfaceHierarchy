using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P5_MIInterfaceHierarchy
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine(" Draw() , Drawing... ");
        }

        public int GetNumberOfSides() => 4; 

        public void Print()
        {
            Console.WriteLine(" Print() , Printing ... ");
        }
    }
}
