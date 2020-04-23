using System;
using System.Collections.Generic;
using System.Linq;

namespace LegoBlazor.Data
{
    public class Set
    {
        public Set(
            Guid key,
            SetJson set,
            IEnumerable<ThemeJson> themes)
        {
            Id = key;
            NumParts = set.NumParts;
            SetNum = set.SetNum;
            Year = set.Year;
            Name = set.Name;
            var theme = themes.First(x => x.Id == set.ThemeId);
            ThemeId = theme.Id;
            Theme = theme.Name;
            SetImgUrl = set.SetImgUrl;
            SetUrl = set.SetUrl;
        }

        public Guid Id { get; set; }

        public string SetNum { get; set; }

        public string Name { get; set; }

        public long Year { get; set; }

        public long ThemeId { get; set; }

        public long NumParts { get; set; }

        public Uri SetImgUrl { get; set; }

        public Uri SetUrl { get; set; }

        public DateTimeOffset? LastModifiedDt { get; set; }

        public string Theme { get; set; }

        public string Uri => $"produits/{Id}";
    }
}