using System.Collections.Generic;
using System.Threading.Tasks;
using JojoLabs.SlackNotifier.Models;

namespace JojoLabs.SlackNotifier.Core.Interfaces
{
    /// <summary>
    /// Slack client representation.
    /// </summary>
    public interface ISlackClient
    {
        /// <summary>
        /// Sends a Slack message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>The sent task.</returns>
        Task SlackAsync(SlackMessage message);
    }
}
