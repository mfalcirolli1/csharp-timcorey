using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class InheritDemo : AccessDemo
    {
        public void Teste()
        {
            InheritDemo demo = new InheritDemo();
            demo.ProtectedDemo();
        }
    }
}
