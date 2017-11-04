using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The Posos.Exceptions class library is a library of classes to represent errors that occur during application execution. 
/// </summary>
namespace Posos.Exceptions
{
    /// <summary>
    /// Represents errors that occur during application execution.
    /// </summary>
    /// <seealso cref="System.Exception"/>
    public class Exception : System.Exception
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Exception class.
        /// </summary>
        /// <remarks>
        /// This constructor initializes the <see cref="System.Exception.Message">Message</see> property of the new instance to a system-supplied message that describes the error and takes into account the current system culture.
        /// 
        /// All the derived classes should provide this default constructor.
        /// </remarks>
        public Exception() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Exception class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo">SerializationInfo</see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext">StreamingContext</see> that contains contextual information about the source or destination.</param>
        /// <exception cref="System.ArgumentNullException">The <i>info</i> parameter is <b>null</b>.</exception>
        /// <exception cref="System.Runtime.Serialization.SerializationException">The class name is <b>null</b> or <see cref="System.Exception.HResult">HResult</see> is zero (0).</exception>
        /// <remarks>
        /// This constructor is called during deserialization to reconstitute the exception object transmitted over a stream. For more information, see <a href="https://msdn.microsoft.com/en-us/library/90c86ass(v=vs.110).aspx">XML and SOAP Serialization</a>.
        /// </remarks>
        /// <seealso cref="System.Runtime.Serialization.SerializationInfo"/>
        /// <seealso cref="System.Runtime.Serialization.StreamingContext "/>
        protected Exception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Exception class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <remarks>
        /// This constructor initializes the Message property of the new instance by using the message parameter. If the message parameter is null, this is the same as calling the Exception constructor.
        /// </remarks>
        public Exception(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Exception class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<b>Nothing</b> in Visual Basic) if no inner exception is specified.</param>
        /// <remarks>
        /// An exception that is thrown as a direct result of a previous exception should include a reference to the previous exception in the <see cref="System.Exception.InnerException">InnerException</see> property. The <see cref="System.Exception.InnerException">InnerException</see> property returns the same value that is passed into the constructor, or a null reference (<b>Nothing</b> in Visual Basic) if the <see cref="System.Exception.InnerException">InnerException</see> property does not supply the inner exception value to the constructor.
        /// </remarks>
        public Exception(string message, Exception innerException) : base(message, innerException)
        {
        }



        #endregion
    }
}
