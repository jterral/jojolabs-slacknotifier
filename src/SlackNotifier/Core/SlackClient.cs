using JojoLabs.SlackNotifier.Core.Interfaces;
using JojoLabs.SlackNotifier.Exceptions;
using JojoLabs.SlackNotifier.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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

        public SlackClientOptions Options { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackClient"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public SlackClient(SlackClientOptions options)
        {
            // Initialize data
            Options = options;

            // Initialize HttpClient
            _httpClient.BaseAddress = options.Webhook;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackClient"/> class.
        /// </summary>
        /// <param name="webhook">The webhook.</param>
        public SlackClient(Uri webhook)
            : this(new SlackClientOptions(webhook))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackClient"/> class.
        /// </summary>
        /// <param name="webhook">The webhook.</param>
        public SlackClient(string webhook)
            : this(new SlackClientOptions(webhook))
        {
        }

        public async Task SlackAsync(SlackMessage message, string channel = null)
        {
            var model = new { channel = "#general", text = message.Message };
            // var model = new { text = message.Message };
            var request = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            //var request = new StringContent("{\"text\": \"BLABLA\"}", Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(Options.Webhook, request);
            if (!response.IsSuccessStatusCode)
            {
                throw new SlackException(await response.Content.ReadAsStringAsync());
            }
        }

        public Task SlackAsync(SlackMessage message, IEnumerable<string> channels)
        {
            throw new NotImplementedException();
        }
    }
}