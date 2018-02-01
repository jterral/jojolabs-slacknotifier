using JojoLabs.SlackNotifier.Models.interfaces;
using System;

namespace JojoLabs.SlackNotifier.Models
{
    /// <summary>
    /// Slack message representation.
    /// </summary>
    /// <seealso cref="ISlackMessage"/>
    public class SlackMessage : ISlackMessage
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}