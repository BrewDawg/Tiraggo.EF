using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiraggo.DynamicQuery
{
    /// <summary>
    /// This is thrown whenever a concurrency (write collision) exception occurs.
    /// </summary>
    /// <remarks>
    /// This can occur in two situations. The first being when a call
    /// to delete, insert, or update on a row results in zero rows being
    /// changed. The second occurs when EntitySpaces recognizes that
    /// an overwrite was about to take place. EntitySpaces can detect
    /// overwrites using the SQL "timestamp" data type and in other
    /// databases systems as well.
    /// </remarks>
    [Serializable]
    public class tgConcurrencyException : tgException
    {
        public tgConcurrencyException(string message)
            : base(message)
        {

        }

        public tgConcurrencyException(string message, Exception innerException) :
            base(message, innerException)
        {

        }

    }
}
