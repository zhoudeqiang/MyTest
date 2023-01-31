using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsle
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 静态方法调用
            //Thread thread = new Thread(new ThreadStart(WriteString));
            //thread.Start();
            //Console.ReadKey();
            #endregion

            #region 实例方法调用
            //TestWrite test = new TestWrite();
            //Thread thread = new Thread(new ThreadStart(test.WriteStringOne));
            //thread.Start();
            #endregion

            #region Lamda方式
            //Thread thread = new Thread(new ThreadStart(() =>
            //{
            //    if (true)
            //    {
            //        Console.WriteLine("你好我是Lamda方式");
            //    }
            //}
            //));

            #endregion
            #region 带参数线程方法
            TestWrite test = new TestWrite();
            Thread thread = new Thread(new ParameterizedThreadStart(test.WriteStringOne));
            thread.Start("这是带参数的");
            #endregion
            thread.Start();

            var threadBody = Thread.CurrentContext;

            var threadBody1 = Thread.CurrentThread;
            var alive = threadBody1.IsAlive;
            Console.WriteLine("");
            Console.ReadKey();
        }


        static void WriteString(string parma)
        {
            Console.WriteLine(parma);
        }
        class TestWrite
        {
            public void WriteStringOne()
            {
                Console.WriteLine("你好1");
            }

            public void WriteStringOne(object param)
            {
                Console.WriteLine(param);
            }
        }

    }
}
