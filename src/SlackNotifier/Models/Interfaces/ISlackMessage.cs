namespace JojoLabs.SlackNotifier.Models.interfaces
{
    /// <summary>
    /// Slack message representation.
    /// </summary>
    public interface ISlackMessage
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        string Message { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        string Username { get; set; }
    }
}
