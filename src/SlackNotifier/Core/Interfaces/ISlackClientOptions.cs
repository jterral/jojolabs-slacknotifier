using System;

namespace JojoLabs.SlackNotifier.Core.Interfaces
{
    public interface ISlackClientOptions
    {
        Uri Webhook { get; }
    }
}