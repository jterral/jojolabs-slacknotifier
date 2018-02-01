using System;

namespace JojoLabs.SlackNotifier.Models
{
    /// <summary>
    /// Link representation.
    /// </summary>
    public class SlackHyperlink
    {
        /// <summary>
        /// Gets the link.
        /// </summary>
        /// <value>The link.</value>
        public Uri Link { get; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackHyperlink" /> class.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <exception cref="ArgumentNullException">Link is null.</exception>
        public SlackHyperlink(Uri link)
        {
            Link = link ?? throw new ArgumentNullException(nameof(link));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackHyperlink"/> class.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <exception cref="ArgumentNullException">Link is null or empty.</exception>
        public SlackHyperlink(string link)
        {
            Link = !string.IsNullOrEmpty(link) ? new Uri(link) : throw new ArgumentNullException(nameof(link));
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents this instance.</returns>
        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? $"<{Link.ToString()}>" : $"<{Link.ToString()}|{Name}>";
        }
    }
}