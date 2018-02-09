using System;
using JojoLabs.SlackNotifier.Models.interfaces;
using Newtonsoft.Json;

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
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        [JsonProperty("text")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the username who sent the message.
        /// </summary>
        /// <value>The username who sent the message.</value>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the emoji.
        /// </summary>
        /// <value>The emoji.</value>
        [JsonProperty("icon_emoji")]
        public string Emoji { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this message is markdown, default is <c>true</c>.
        /// </summary>
        /// <value><c>true</c> if this message is markdown; otherwise, <c>false</c>.</value>
        [JsonProperty("mrkdwn")]
        public bool IsMarkdown { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackMessage"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <exception cref="ArgumentNullException">Message cannot be null or empty.</exception>
        public SlackMessage(string message)
        {
            Message = string.IsNullOrEmpty(message) ? throw new ArgumentNullException(nameof(message)) : message;
            IsMarkdown = true;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="SlackMessage"/>.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator SlackMessage(string message)
        {
            return new SlackMessage(message);
        }
    }
}
