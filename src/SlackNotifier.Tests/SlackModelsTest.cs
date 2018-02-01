using JojoLabs.SlackNotifier.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JojoLabs.SlackNotifier.Tests
{
    [TestClass]
    public class SlackModelsTest
    {
        #region Slack Hyperlink

        [TestMethod]
        public void Hyperlink_UriWithoutName_ReturnsToString()
        {
            // Arrange
            string uri = "http://www.domain.com/";
            string expected = $"<{uri}>";

            // Act
            SlackHyperlink link = new SlackHyperlink(new Uri(uri));

            // Assert
            Assert.IsNotNull(link.ToString());
            Assert.AreNotEqual(string.Empty, link.ToString());
            Assert.AreEqual(expected, link.ToString());
        }

        [TestMethod]
        public void Hyperlink_UriWithName_ReturnsToString()
        {
            // Arrange
            string uri = "http://www.domain.com/";
            string name = Guid.NewGuid().ToString();
            string expected = $"<{uri}|{name}>";

            // Act
            SlackHyperlink link = new SlackHyperlink(new Uri(uri))
            {
                Name = name
            };

            // Assert
            Assert.IsNotNull(link.ToString());
            Assert.AreNotEqual(string.Empty, link.ToString());
            Assert.AreEqual(expected, link.ToString());
        }

        [TestMethod]
        public void Hyperlink_StringWithoutName_ReturnsToString()
        {
            // Arrange
            string uri = "http://www.domain.com/";
            string expected = $"<{uri}>";

            // Act
            SlackHyperlink link = new SlackHyperlink(uri);

            // Assert
            Assert.IsNotNull(link.ToString());
            Assert.AreNotEqual(string.Empty, link.ToString());
            Assert.AreEqual(expected, link.ToString());
        }

        [TestMethod]
        public void Hyperlink_StringWithName_ReturnsToString()
        {
            // Arrange
            string uri = "http://www.domain.com/";
            string name = Guid.NewGuid().ToString();
            string expected = $"<{uri}|{name}>";

            // Act
            SlackHyperlink link = new SlackHyperlink(uri)
            {
                Name = name
            };

            // Assert
            Assert.IsNotNull(link.ToString());
            Assert.AreNotEqual(string.Empty, link.ToString());
            Assert.AreEqual(expected, link.ToString());
        }

        #endregion
    }
}