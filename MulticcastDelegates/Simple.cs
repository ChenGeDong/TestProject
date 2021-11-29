using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticcastDelegates
{
    public delegate string FirstDelegate(int x);
    public class Simple
    {
        public delegate void SocendDelegate(char a,char b);



        FirstDelegate d1 = new FirstDelegate(InstanceMethod);
        FirstDelegate d2 = new FirstDelegate(this.InstanceMethod);

        // Here we create a delegate instance referring to the same method
        // as the first two examples, but with a different target.
        FirstDelegate d3 = new FirstDelegate(anotherInstance.InstanceMethod);

        // This delegate instance uses an instance method in a different class,
        // specifying the target to call the method on
        FirstDelegate d4 = new FirstDelegate(instanceOfOtherClass.OtherInstanceMethod);

        // This delegate instance uses a static method in the class containing
        // the creation expression (or a base class).
        FirstDelegate d5 = new FirstDelegate(StaticMethod);

        // This delegate instance uses a static method in a different class
        FirstDelegate d6 = new FirstDelegate(OtherClass.OtherStaticMethod);
    }

}
