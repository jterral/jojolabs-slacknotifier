using System;

namespace JojoLabs.SlackNotifier.Exceptions
{
    /// <summary>
    /// Slack exception representation.
    /// </summary>
    /// <seealso cref="System.Exception"/>
    public class SlackException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public SlackException(string message)
            : base(message)
        {
        }
    }
}
