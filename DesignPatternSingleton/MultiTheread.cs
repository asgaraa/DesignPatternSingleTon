using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSingleton
{
    public sealed class MultiTheread
    {
        private static int counter = 0;
        private static volatile MultiTheread _instance = null;
        private static object _syncRoot = new Object();

      
        private MultiTheread() {
            counter += 1;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public static MultiTheread Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                            _instance = new MultiTheread();
                    }
                }
                return _instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
