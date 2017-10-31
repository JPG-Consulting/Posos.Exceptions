using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posos.Exceptions
{
    /// <summary>
    /// The exception that is thrown when the value of a property is outside the allowable range of values as defined by the property.
    /// </summary>
    public class PropertyOutOfRangeException : PropertyException 
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the PropertyOutOfRangeException class.
        /// </summary>
        public PropertyOutOfRangeException() : base(Resources.Resources.ResourceManager.GetString("Prop_PropertyOutOfRange"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertyOutOfRangeException class with the name of the property that causes this exception.
        /// </summary>
        /// <param name="propertyName">The name of the parameter that caused the exception.</param>
        public PropertyOutOfRangeException(string propertyName) : base(Resources.Resources.ResourceManager.GetString("Prop_PropertyOutOfRange"), propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertyOutOfRangeException class with a specified error message and the exception that is the cause of this exception.
        /// </summary>
        /// <param name="propertyName">The name of the parameter that caused the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<b>Nothing</b> in Visual Basic) if no inner exception is specified.</param>
        public PropertyOutOfRangeException(string propertyName, Exception innerException) : base(Resources.Resources.ResourceManager.GetString("Prop_PropertyOutOfRange"), propertyName, innerException)
        {
        }

        /// <summary>
        /// Initializes an instance of the PropertyOutOfRangeException class with a specified error message and the name of the parameter that causes this exception.
        /// </summary>
        /// <param name="propertyName">The name of the parameter that caused the exception.</param>
        /// <param name="message">A message that describes the error.</param>
        public PropertyOutOfRangeException(string propertyName, string message) : base(message, propertyName)
        {
        }

        #endregion
    }
}
