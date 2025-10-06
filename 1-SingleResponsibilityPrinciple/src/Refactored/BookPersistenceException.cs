using System;

namespace srp.refactored
{
    public class BookPersistenceException : Exception
    {
        public BookPersistenceException() { }

        public BookPersistenceException(string message) : base(message) { }

        public BookPersistenceException(string message, Exception innerException) : base(message, innerException) { }
    }
}