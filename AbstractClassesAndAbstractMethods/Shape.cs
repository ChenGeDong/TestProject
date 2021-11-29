using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesAndAbstractMethods
{
    public abstract class Shape
    {
        public abstract void Resize(int width, int height);
    }

    public class Ellipse:Shape
    {
        /// <summary>
        /// 从抽象基类中派生类型时，需要实现所有的抽象成员，否则编译错误
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public override void Resize(int width, int height)
        {
            
        }
    }


    sealed class FinalClass
    {
        //etc
    }
    class DervedClass : FinalClass //wrong. Cannot derive from sealed class
    {

    }


    class MyClass:MyBaseClass
    {
        public sealed override void FinalMethod()
        {
            base.FinalMethod();
        }
    }

    internal class MyBaseClass
    {
        public  virtual void FinalMethod()
        {

        }
    }

    class DerivedClass:MyClass
    {
        publice override void FinalMethod()
        {

        }
    }
}
