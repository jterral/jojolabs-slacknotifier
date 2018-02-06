using System;
using JojoLabs.SlackNotifier.Core.Interfaces;

namespace JojoLabs.SlackNotifier.Core
{
    /// <summary>
    /// Slack client options.
    /// </summary>
    /// <seealso cref="JojoLabs.SlackNotifier.Core.Interfaces.ISlackClientOptions"/>
    public class SlackClientOptions : ISlackClientOptions
    {
        /// <summary>
        /// Gets the webhook url.
        /// </summary>
        /// <value>The webhook url.</value>
        public Uri Webhook { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackClientOptions"/> class.
        /// </summary>
        /// <param name="webhook">The webhook url.</param>
        /// <exception cref="ArgumentNullException">Webhook url cannot be null.</exception>
        public SlackClientOptions(Uri webhook)
        {
            Webhook = webhook ?? throw new ArgumentNullException(nameof(webhook));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackClientOptions"/> class.
        /// </summary>
        /// <param name="webhook">The webhook url.</param>
        /// <exception cref="ArgumentNullException">Webhook url cannot be null.</exception>
        public SlackClientOptions(string webhook)
        {
            Webhook = !string.IsNullOrEmpty(webhook) ? new Uri(webhook) : throw new ArgumentNullException(nameof(webhook));
        }
    }
}
