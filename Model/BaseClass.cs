using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    public class BaseClass
    {
        // virtual permite que em outra classe a gente sobrescreva este método
        public virtual void Method() 
        {
            Console.WriteLine("Method from base class");
        }
    }
}