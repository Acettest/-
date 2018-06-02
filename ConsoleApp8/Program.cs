using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            var b = new B();
            a.fun1(1);//1
            a.fun2(b);//2,5

            b.fun1(1);//2
            b.fun2(a);//1,6
        }

        public class A
        {
            public virtual void fun1(int i)
            {
                Console.WriteLine(i.ToString());
            }

            public void fun2(A a)
            {
                a.fun1(1);
                fun1(5);
            }
        }

        public class B : A
        {
            public override void fun1(int i)
            {
                base.fun1(i+1);
            }
        }


    }
}
