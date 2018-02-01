using JojoLabs.SlackNotifier.Core.Interfaces;
using JojoLabs.SlackNotifier.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JojoLabs.SlackNotifier.Core
{
    public class SlackClient : ISlackClient
    {
        public SlackClient(SlackClientOptions options)
        {

        }

        public void Slack(string channel, SlackMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
