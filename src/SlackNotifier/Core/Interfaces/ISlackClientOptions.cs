using System;

namespace JojoLabs.SlackNotifier.Core.Interfaces
{
    /// <summary>
    /// Slack options.
    /// </summary>
    public interface ISlackClientOptions
    {
        /// <summary>
        /// Gets the webhook url.
        /// </summary>
        /// <value>The webhook url.</value>
        Uri Webhook { get; }
    }
}
