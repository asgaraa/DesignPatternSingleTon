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
        private static MultiTheread instance = null;
        public static MultiTheread GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new MultiTheread();
                return instance;
            }
        }
        private MultiTheread()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
