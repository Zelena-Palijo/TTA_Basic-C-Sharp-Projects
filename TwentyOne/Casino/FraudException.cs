using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException()
            : base() { } //inherit from base exception

        public FraudException(string message)
            : base(message) { }
        
    }
}
