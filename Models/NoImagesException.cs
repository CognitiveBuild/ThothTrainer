﻿using System;
using System.Runtime.Serialization;

namespace ThothTrainer.Models
{
    [Serializable]
    internal class NoImagesException : Exception
    {
        public NoImagesException()
        {
        }

        public NoImagesException(string message) : base(message)
        {
        }

        public NoImagesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoImagesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}