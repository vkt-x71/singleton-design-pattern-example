using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatternExample
{
    public class Validation
    {
        private static object _lockObj = new object();

        private static Validation _instance;
        public static Validation Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockObj)
                    {
                        if (_instance == null)
                            _instance = new Validation();
                    }

                }
                return _instance;
            }
        }
        private Validation() { }

        public string EmailRegex { get; set; }
        public bool IsMailValid(string mail)
        {// fake method
            if (mail.Contains("@")) return true;
            else return false;
        }
        public bool IsPhoneValid(string phone)
        {// fake method
            if (phone.Contains("0")) return true;
            else return false;
        }
    }
}
