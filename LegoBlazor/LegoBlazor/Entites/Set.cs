using System;
using System.Collections.Generic;
using System.Linq;
using Blazorise.DataGrid;
using LegoAPI;
using LegoAPI.Json;
using LegoBlazor.Entites;
using OutilsBlazor;

namespace LegoBlazor.Data
{
    public class Set : IEntity
    {
        public Set(SetJson set)
        {
            NumParts = set.NumParts;
            SetNum = set.SetNum;
            Year = set.Year;
            Name = set.Name;
            ThemeId = 1;
            Theme = "Technic";
            SetImgUrl = set.SetImgUrl;
            SetUrl = set.SetUrl;
        }

        public string SetNum { get; set; }

        public string Name { get; set; }

        public long Year { get; set; }

        public long ThemeId { get; set; }

        public long NumParts { get; set; }

        public Uri SetImgUrl { get; set; }

        public Uri SetUrl { get; set; }

        public DateTimeOffset? LastModifiedDt { get; set; }

        public string Theme { get; set; }

        public string Uri => $"produits/{SetNum}";

        public string Nom => Name;

        private List<Parts> _parts;

        public List<Parts> Parts
        {
            get
            {
                if (_parts == null)
                {
                    SetApi api = new SetApi();
                    _parts = api.LireParts(SetNum, NumParts).Select(x => new Parts(x)).ToList();
                }
                return _parts;
            }
        }

        public List<List<Parts>> PartsSplit => Parts.SplitList();

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}