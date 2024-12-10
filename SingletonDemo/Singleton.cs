using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create multiple instance every time
//so make class as sealed and constructor as private (singleton pattern)

//without sealed also we can't inherited class bcoz thereis private constructor
//but we can inherited it in that class(nested class) so another instance is also created 
//so that why we are using sealed keyword

namespace SingletonDemo
{
    //Sealed restricts the inheritance
    public sealed class Singleton
    {
        private static int counter =0;
        private static readonly object obj = new object();
        private static Singleton instance=null;
       //private constructor ensure that object is not instantiated other than with in the class itself
        private Singleton() 
        {
            counter++;
            Console.WriteLine("Counter Value "+counter.ToString());
        }
        //public property is used to return only one instance of the class leveraging
        //on the private property
        public static Singleton GetInstance
        {
            //double check locking
            //to avoid parallel execution and creation of multiple instance
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
        //public method which can be invoked through the singleton instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
