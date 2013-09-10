using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiraggo.DynamicQuery
{
    /// <summary>
    /// Acts as a base class for EntitySpaces exceptions. EntitySpaces itself throws very few exceptions however.
    /// See <see cref="tgConcurrencyException"/>
    /// </summary>
    public class tgException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">The text of the exception.</param>
        public tgException(string message) :
            base(message)
        {

        }

        /// <summary>
        /// Alternate Connstructor
        /// </summary>
        /// <param name="message">The text of the exception.</param>
        /// <param name="innerException">The exception we are wrapping</param>
        public tgException(string message, Exception innerException) :
            base(message, innerException)
        {

        }
    }
}
