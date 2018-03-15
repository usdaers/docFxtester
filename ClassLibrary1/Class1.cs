using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// class definition: generating docFx documentation
    /// </summary>
    public class Class1
    {           
           
        public Class1()
        {

        }

        /// <summary>
        /// this is a great method
        /// </summary>
        /// <returns>meaningful message</returns>
        public string HelloWorld(string testMe)
        {
            var inMessage = testMe;
            return inMessage;
        }
    }
    /// <summary>
    /// test Program
    /// </summary>
    /// <returns>not a whole lot</returns>
    class Program
    {
        static void Main()
        {
            Class1 testClass = new Class1();
            string outTest = testClass.HelloWorld("YAY");
            Console.WriteLine(outTest);
            Console.WriteLine("this is the end of the world");
        }
    }

}
