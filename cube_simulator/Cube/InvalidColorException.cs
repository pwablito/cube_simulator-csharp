﻿using System;
using System.Runtime.Serialization;

namespace cube_simulator
{
    [Serializable]
    internal class InvalidColorException : Exception
    {
        public InvalidColorException()
        {
        }

        public InvalidColorException(string message) : base(message)
        {
        }

        public InvalidColorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidColorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}