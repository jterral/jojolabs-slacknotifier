using JojoLabs.SlackNotifier.Core.Interfaces;
using JojoLabs.SlackNotifier.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace JojoLabs.SlackNotifier.Core
{
    /// <summary>
    /// Slack client implementation.
    /// </summary>
    /// <seealso cref="ISlackClient" />
    public class SlackClient : ISlackClient
    {
        /// <summary>
        /// The HTTP client instance.
        /// </summary>
        private static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackClient"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public SlackClient(SlackClientOptions options)
        {
            _httpClient.BaseAddress = options.SlackUri;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void Slack(string channel, SlackMessage message)
        {
            throw new NotImplementedException();
        }
    }
}