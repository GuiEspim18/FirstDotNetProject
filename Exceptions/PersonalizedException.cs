using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HelloWorld.Exceptions
{
    // : é equivalente ao extends do java
    public class PersonalizedException : Exception
    {
        public PersonalizedException()
        {
        }

        public PersonalizedException(string? message) : base(message)
        {
        }

        public PersonalizedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PersonalizedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}