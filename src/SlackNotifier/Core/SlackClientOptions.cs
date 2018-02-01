using JojoLabs.SlackNotifier.Core.Interfaces;
using System;

namespace JojoLabs.SlackNotifier.Core
{
    public class SlackClientOptions : ISlackClientOptions
    {
        public Uri SlackUri { get; private set; }

        public SlackClientOptions(Uri slackUri)
        {
            SlackUri = slackUri;
        }
    }
}