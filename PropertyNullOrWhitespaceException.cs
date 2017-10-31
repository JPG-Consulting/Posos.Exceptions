using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posos.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a null reference or a whitespace string (<b>Nothing</b> in Visual Basic) is set on a property that does not accept it as a valid value.
    /// </summary>
    public class PropertyNullOrWhitespaceException : PropertyException 
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the PropertyNullOrWhitespaceException class.
        /// </summary>
        public PropertyNullOrWhitespaceException() : base(Resources.Resources.ResourceManager.GetString("Prop_PropertyNullOrWhitespace"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertyNullOrWhitespaceException class with the name of the property that causes this exception.
        /// </summary>
        /// <param name="propertyName">The name of the parameter that caused the exception.</param>
        public PropertyNullOrWhitespaceException(string propertyName) : base(Resources.Resources.ResourceManager.GetString("Prop_PropertyNullOrWhitespace"), propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertyNullOrWhitespaceException class with a specified error message and the exception that is the cause of this exception.
        /// </summary>
        /// <param name="propertyName">The name of the parameter that caused the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<b>Nothing</b> in Visual Basic) if no inner exception is specified.</param>
        public PropertyNullOrWhitespaceException(string propertyName, Exception innerException) : base(Resources.Resources.ResourceManager.GetString("Prop_PropertyNullOrWhitespace"), propertyName, innerException)
        {
        }

        /// <summary>
        /// Initializes an instance of the PropertyNullOrWhitespaceException class with a specified error message and the name of the parameter that causes this exception.
        /// </summary>
        /// <param name="propertyName">The name of the parameter that caused the exception.</param>
        /// <param name="message">A message that describes the error.</param>
        public PropertyNullOrWhitespaceException(string propertyName, string message) : base(message, propertyName)
        {
        }

        #endregion
    }
}
