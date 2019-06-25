using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using MongoDB.Bson;

namespace BlazorBB.Shared
{
    public class ObjectIdConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var stringId = serializer.Deserialize<string>(reader);
            return ObjectId.Parse(stringId);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}
