using System;
using System.Collections.Generic;
using System.Text;

namespace JojoLabs.SlackNotifier.Models.interfaces
{
    public interface ISlackMessage
    {
        string Message { get; set; }

        string Username { get; set; }
    }
}
