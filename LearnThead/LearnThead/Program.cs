using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearnThead
{
    class Program
    {
        bool done=false;
        readonly object locker = new object();
        static ReaderWriterLockSlim _rw = new ReaderWriterLockSlim();
        static List<int> _items = new List<int>();
        static Random _rand = new Random();
        static void Main(string[] args)
        {
            //Thread1();
            //Thread2();
            //Join();
            new Thread(Read).Start();
            new Thread(Read).Start();
            new Thread(Read).Start();

            new Thread(Write).Start("A");
            new Thread(Write).Start("B");

        }

        private static void Write(object threadID)
        {
            while (true)
            {
                int newNumber = GetRandNum(100);
                _rw.EnterWriteLock();
                _items.Add(newNumber);
                _rw.ExitWriteLock();
                Console.WriteLine("Thread " + threadID + " added " + newNumber);
                Thread.Sleep(100);
            }
        }
        static int GetRandNum(int max) { lock (_rand) return _rand.Next(max); }
        private static void Read()
        {
            while (true)
            {
                _rw.EnterReadLock();
                foreach (int i in _items) Thread.Sleep(10);
                _rw.ExitReadLock();
            }
        }

        private static void Join()
        {
            Thread t = new Thread(Go);
            t.Name = "GoThread";
            t.Start();
            t.Join();
            Console.WriteLine("Thread t has ended!");
        }

        static void Go()
        {
            for (int i = 0; i < 1000; i++) Console.WriteLine(i);
        }

        //private static void Thread2()
        //{
        //    Program tt = new Program();   // Create a common instance
        //    new Thread(tt.Go).Start();
        //    tt.Go();
        //    //thread can 1-execute 2-be blocked  3-sleep(spinwait)
        //}

        //void Go()
        //{
        //    lock (locker)
        //    {
        //        if (!done)
        //        {   done = true;
        //            Console.WriteLine("Done");
        //        }
        //    }
        //}

        private static void Thread1()
        {
            Thread t = new Thread(
                            () =>
                            {
                                for (int i = 0; i < 1000; i++) Console.Write("y");
                            });          // Kick off a new thread
            t.Start();                               // running WriteY()

            // Simultaneously, do something on the main thread.
            for (int i = 0; i < 1000; i++) Console.Write("x");
            Console.ReadLine();
        }
    }
}
