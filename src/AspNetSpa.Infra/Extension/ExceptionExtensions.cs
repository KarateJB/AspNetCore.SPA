using System;
using System.Collections.Generic;

namespace AspNetSpa.Infra.Extension
{
    /// <summary>
    /// System.Exception Extensions
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Flat all the inner exceptions
        /// </summary>
        /// <param name="ex">Self</param>
        /// <returns>List of Exceptions</returns>
        public static IEnumerable<Exception> FlattenHierarchy(this Exception ex)
        {
            if (ex == null)
            {
                throw new ArgumentNullException("ex");
            }

            var innerException = ex;
            do
            {
                yield return innerException;
                innerException = innerException.InnerException;
            }
            while (innerException != null);
        }
    }
}