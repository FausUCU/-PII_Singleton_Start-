using System;
using System.Collections.Generic;


namespace Library
{   
    public class Singleton<T>
    {
        private T class 
    {
            private Greeter()
        {
            // Intentionally left blank
        }

        private static Greeter instance;

        public static Greeter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Greeter();
                }

                return instance;
            }
        }
            
        
    }

    

    /*public class Greeter
    
        private Greeter()
        {
            // Intentionally left blank
        }

        private static Greeter instance;

        public static Greeter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Greeter();
                }

                return instance;
            }
        }*/

        public class Greeter:   Singleton
        {
            public void SayHiToTheWorld()
            {
            Console.WriteLine("Hello World!");
            }
        }
    
}
