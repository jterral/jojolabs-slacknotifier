using JojoLabs.SlackNotifier.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JojoLabs.SlackNotifier.Core.Interfaces
{
    public interface ISlackClient
    {
        void Slack(string channel, SlackMessage message);
    }
}
