using System;

namespace SingleResponsibilityPrinciple.src.Refactored;

public class BookPersistenceException : Exception
{
    public BookPersistenceException() { }

    public BookPersistenceException(string message) : base(message) { }

    public BookPersistenceException(string message, Exception innerException) : base(message, innerException) { }
}