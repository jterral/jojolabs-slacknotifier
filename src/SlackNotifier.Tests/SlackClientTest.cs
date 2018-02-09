using JojoLabs.SlackNotifier.Core;
using JojoLabs.SlackNotifier.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace JojoLabs.SlackNotifier.Tests
{
    [TestClass]
    public class SlackClientTest
    {
        [TestMethod]
        public async Task Slack_SendMessage_MessageSent()
        {
            // Arrange
            SlackClient client = new SlackClient("");
            SlackMessage msg = "Sent from Unit Test.";
            msg.Channel = "#general";
            msg.Username = "jojobot";
            msg.Emoji = ":smile:";

            // Act
            await client.SlackAsync(msg);

            // Assert
        }
    }
}
