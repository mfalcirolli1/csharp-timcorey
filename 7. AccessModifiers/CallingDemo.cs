using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiers
{
    public class CallingDemo
    {
        public void CallPrivate()
        {
            AccessDemo demo = new AccessDemo();
            CallingDemo calling = new CallingDemo();

            demo.PrivateDemo();
            demo.InternalDemo();
            
        }
    }
}
