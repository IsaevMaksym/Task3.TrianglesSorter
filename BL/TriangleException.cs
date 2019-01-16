using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLogic
{
    public class TriangleException : Exception
    {
        public TriangleException()
        {
        }

        public TriangleException(string message) : base(message)
        {
        }

        public TriangleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TriangleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
