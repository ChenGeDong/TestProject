using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace 另外一个委托的示例
{
    //定义委托
    delegate void StringProcessor(string input);


    class Person
    {
       

        string Name;

        public Person(string name)
        {
            this.Name = name;
        }
        //声明了一个兼容的实例方法
        public void say(string message)
        {
            WriteLine($"{Name} say: {message}");
        }
        public void sayAgain(string message)
        {
            for (int i = 0; i < 500; i++)
            {
                WriteLine($"{Name} say: {message}");
            }

            Thread.Sleep(6500);
        }
    }
    class Background
    {
        //声明兼容的静态方法
        public static void Note(string note)
        {
            WriteLine($"{note}");
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Person jon = new Person("jon");
            Person tom = new Person("tom");
            
            //声明委托实例
            StringProcessor jonsVoice, tomVoice, background;

            //实例化委托实例
            jonsVoice = new StringProcessor(jon.say);//实例方法
            tomVoice = new StringProcessor(tom.sayAgain);
            background = new StringProcessor(Background.Note);//静态方法

            jonsVoice("Hello ,son");
            tomVoice.Invoke("Hello, Daddy");
            background("An airplane flies past");

            ReadKey();


        }
    }
}
