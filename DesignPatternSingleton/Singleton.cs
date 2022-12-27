using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSingleton
{
    public sealed class Singleton
    {

        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        public Singleton()
        {
            //counter+=1;
            //Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void Registered()
        {
            counter++;
            Console.WriteLine("Registered" + counter);
        }
        //public void PrintDetails(string message)
        //{
        //    Console.WriteLine(message);
        //}
        //private static Singleton _instance;
        //public Singleton()
        //{

        //}
        //public static Singleton GetInstance()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new Singleton();
        //    }
        //    return _instance;
        //}
    }
}
