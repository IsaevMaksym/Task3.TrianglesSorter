using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class TrianglesExeption : Exception
    {
        public TrianglesExeption()
        {
        }

        public TrianglesExeption(string message) : base(message)
        {
        }

        public TrianglesExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TrianglesExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
