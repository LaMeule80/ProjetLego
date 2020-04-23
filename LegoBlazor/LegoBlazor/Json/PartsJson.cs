using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LegoBlazor.Data
{
    public class PartsJson
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("inv_part_id")]
        public long InvPartId { get; set; }

        /*[JsonProperty("part")]
        public Part Part { get; set; }

        [JsonProperty("color")]
        public Color Color { get; set; }

        [JsonProperty("set_num")]
        public SetNum SetNum { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("is_spare")]
        public bool IsSpare { get; set; }

        [JsonProperty("element_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ElementId { get; set; }

        [JsonProperty("num_sets")]
        public long NumSets { get; set; }
    }

    public class Color
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

    public class ColorExternalIds
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

    public class BrickLink
    {
        [JsonProperty("ext_ids")]
        public List<long> ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public List<List<string>> ExtDescrs { get; set; }
    }

    public class Peeron
    {
        [JsonProperty("ext_ids")]
        public List<object> ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public List<List<string>> ExtDescrs { get; set; }
    }

    public class Part
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

    public class PartExternalIds
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
        public List<long> Brickset { get; set; }*/
    }
}
