using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LegoBlazor.API.Json
{
    public class PartsJson
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public object Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }

    public class Result
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("inv_part_id")]
        public long InvPartId { get; set; }

        //[JsonProperty("part")]
        //public Part Part { get; set; }

        //[JsonProperty("color")]
        //public Color Color { get; set; }

        //[JsonProperty("set_num")]
        //public SetNum SetNum { get; set; }

        //[JsonProperty("quantity")]
        //public long Quantity { get; set; }

        //[JsonProperty("is_spare")]
        //public bool IsSpare { get; set; }

        //[JsonProperty("element_id")]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public long? ElementId { get; set; }

        //[JsonProperty("num_sets")]
        //public long NumSets { get; set; }
    }

    /*public partial class Color
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public bool IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public ColorExternalIds ExternalIds { get; set; }
    }

    public partial class ColorExternalIds
    {
        [JsonProperty("BrickLink")]
        public BrickLink BrickLink { get; set; }

        [JsonProperty("BrickOwl", NullValueHandling = NullValueHandling.Ignore)]
        public BrickLink BrickOwl { get; set; }

        [JsonProperty("LEGO", NullValueHandling = NullValueHandling.Ignore)]
        public BrickLink Lego { get; set; }

        [JsonProperty("Peeron", NullValueHandling = NullValueHandling.Ignore)]
        public Peeron Peeron { get; set; }

        [JsonProperty("LDraw", NullValueHandling = NullValueHandling.Ignore)]
        public BrickLink LDraw { get; set; }
    }

    public partial class BrickLink
    {
        [JsonProperty("ext_ids")]
        public List<long> ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public List<List<string>> ExtDescrs { get; set; }
    }

    public partial class Peeron
    {
        [JsonProperty("ext_ids")]
        public List<object> ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public List<List<string>> ExtDescrs { get; set; }
    }

    public partial class Part
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public long PartCatId { get; set; }

        [JsonProperty("part_url")]
        public Uri PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public Uri PartImgUrl { get; set; }

        [JsonProperty("external_ids")]
        public PartExternalIds ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public object PrintOf { get; set; }
    }

    public partial class PartExternalIds
    {
        [JsonProperty("BrickOwl", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> BrickOwl { get; set; }

        [JsonProperty("LEGO", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Lego { get; set; }

        [JsonProperty("LDraw", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> LDraw { get; set; }

        [JsonProperty("Peeron", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Peeron { get; set; }

        [JsonProperty("BrickLink", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BrickLink { get; set; }

        [JsonProperty("Brickset", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Brickset { get; set; }
    }

    public enum SetNum { The421011 };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                SetNumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class DecodeArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(List<long>);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (List<long>)untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
    }

    internal class SetNumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SetNum) || t == typeof(SetNum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "42101-1")
            {
                return SetNum.The421011;
            }
            throw new Exception("Cannot unmarshal type SetNum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SetNum)untypedValue;
            if (value == SetNum.The421011)
            {
                serializer.Serialize(writer, "42101-1");
                return;
            }
            throw new Exception("Cannot marshal type SetNum");
        }

        public static readonly SetNumConverter Singleton = new SetNumConverter();
    }*/
}
