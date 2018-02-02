using JojoLabs.SlackNotifier.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JojoLabs.SlackNotifier.Core.Interfaces
{
    public interface ISlackClient
    {
        Task SlackAsync(SlackMessage message, string channel = null);

        Task SlackAsync(SlackMessage message, IEnumerable<string> channels);
    }
}