using JojoLabs.SlackNotifier.Core.Interfaces;
using System;

namespace JojoLabs.SlackNotifier.Core
{
    public class SlackClientOptions : ISlackClientOptions
    {
        public Uri Webhook { get; private set; }

        public SlackClientOptions(Uri webhook)
        {
            Webhook = webhook ?? throw new ArgumentNullException(nameof(webhook));
        }

        public SlackClientOptions(string slackUri)
        {
            Webhook = !string.IsNullOrEmpty(slackUri) ? new Uri(slackUri) : throw new ArgumentNullException(nameof(slackUri));
        }
    }
}