using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Foobar f = AnyMethodIDontKnow;
            //f(19);

            //f += SomeOtherMethod;
            //f(20);

            //Bar b1 = MyIntMethodOne;
            //Bar b2 = MyIntMethodTwo;

            //int b2Result = b2(10);

            //int b1ResultWithB2Result = b1(b2Result);

            //Console.WriteLine(b1ResultWithB2Result);

            //Console.WriteLine(b1(b2(10)));

            Console.ReadKey(true);
        }

        public static void AnyMethodIDontKnow(int x)
        {
            Console.WriteLine("Inside our called method: {0}", x);
        }

        public static void SomeOtherMethod(int anyInt)
        {
            Console.WriteLine("Some other method: {0}", anyInt);
        }

        private static int MyIntMethodOne(int x)
        {
            return x * x;
        }

        private static int MyIntMethodTwo(int x)
        {
            return x + x;
        }

    }


    public delegate void Foobar(int x);

    public delegate int Bar(int x);

    public class MyEventArgs
    {
        public static MyEventArgs Empty = new MyEventArgs();
    }

    public delegate void MyEventHandler(object sender, MyEventArgs e);

    public class Car
    {
        
    }

    public class SomeEventRaisingClass
    {
        public SomeEventRaisingClass()
        {
            MethodHasBeenCalled += DummyMethod;
        }

        private void DummyMethod(object sender, MyEventArgs e)
        {
            
        }

        public void Method()
        {
            MethodHasBeenCalled(this, MyEventArgs.Empty);
        }

        public event MyEventHandler MethodHasBeenCalled;

        public Car C { get; set; }
    }

}
