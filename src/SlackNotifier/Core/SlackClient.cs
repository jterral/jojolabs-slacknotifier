using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using JojoLabs.SlackNotifier.Core.Interfaces;
using JojoLabs.SlackNotifier.Exceptions;
using JojoLabs.SlackNotifier.Models;
using Newtonsoft.Json;

namespace JojoLabs.SlackNotifier.Core
{
    /// <summary>
    /// Slack client implementation.
    /// </summary>
    /// <seealso cref="ISlackClient"/>
    public class SlackClient : ISlackClient
    {
        /// <summary>
        /// The HTTP client instance.
        /// </summary>
        private static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>The options.</value>
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
        /// <param name="webhook">The webhook url.</param>
        public SlackClient(Uri webhook)
            : this(new SlackClientOptions(webhook))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackClient"/> class.
        /// </summary>
        /// <param name="webhook">The webhook url.</param>
        public SlackClient(string webhook)
            : this(new SlackClientOptions(webhook))
        {
        }

        /// <summary>
        /// Sends a Slack message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="channel">The channel name where to send the message, or if not present the default channel.</param>
        /// <returns>The sent task.</returns>
        public async Task SlackAsync(SlackMessage message)
        {
            // Serialize Slack Message
            string json = JsonConvert.SerializeObject(message, Formatting.Indented);

            Debug.WriteLine(json);

            // Create request
            var request = new StringContent(json, Encoding.UTF8, "application/json");

            // Post request
            var response = await _httpClient.PostAsync(Options.Webhook, request);
            if (!response.IsSuccessStatusCode)
            {
                throw new SlackException(await response.Content.ReadAsStringAsync());
            }
        }
    }
}
