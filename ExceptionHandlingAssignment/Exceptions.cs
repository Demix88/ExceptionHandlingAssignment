using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    public class Exceptions
    {
        public class NegativeException : Exception
        {
            public NegativeException()
                : base() { }
            public NegativeException(string message)
                : base(message) { }
        }
        public class TooBigException : Exception
        {
            public TooBigException()
                : base() { }
            public TooBigException(string message)
                : base(message) { }
        }
            public class ZeroException : Exception
            {
                public ZeroException()
                    : base() { }
                public ZeroException(string message)
                    : base(message) { }
            }
        }
    }

