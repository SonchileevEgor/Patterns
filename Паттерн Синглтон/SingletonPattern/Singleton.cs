using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singleton
    {
        private Singleton() {}
        private static Singleton _instance;
        private static readonly object _lock = new object();

        public string Value { get; set; }

        public static Singleton GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance = new Singleton();
                    _instance.Value = value;    
                }
            
            }

            return _instance;
        }
    }
}