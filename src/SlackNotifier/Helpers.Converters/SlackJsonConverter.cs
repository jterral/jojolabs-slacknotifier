using JojoLabs.SlackNotifier.Models;
using Newtonsoft.Json;
using System;

namespace JojoLabs.SlackNotifier.Helpers.Converters
{
    public class SlackJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is SlackMessage)
            {
            }
        }
    }
}