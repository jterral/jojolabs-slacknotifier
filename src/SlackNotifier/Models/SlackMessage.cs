using System;
using JojoLabs.SlackNotifier.Models.interfaces;

namespace JojoLabs.SlackNotifier.Models
{
    /// <summary>
    /// Slack message representation.
    /// </summary>
    /// <seealso cref="ISlackMessage"/>
    public class SlackMessage : ISlackMessage
    {
        /// <summary>
        /// Gets or sets the channel.
        /// </summary>
        /// <value>The channel.</value>
        public string Channel { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackMessage"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <exception cref="ArgumentNullException">Message cannot be null or empty.</exception>
        public SlackMessage(string message)
        {
            Message = string.IsNullOrEmpty(message) ? throw new ArgumentNullException(nameof(message)) : message;
        }
    }
}
