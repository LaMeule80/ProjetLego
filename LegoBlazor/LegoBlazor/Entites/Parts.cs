using System;
using LegoAPI.Json.Parts;

namespace LegoBlazor.Entites
{
    public class Parts
    {
        public Parts(PartsJson partsJson)
        {
            Id = partsJson.Id;
            Nom = partsJson.Part.Name;
            Quantite = partsJson.Quantity;
            PartUrl = partsJson.Part.PartUrl;
            PartImgUrl = partsJson.Part.PartImgUrl;
            Couleur = partsJson.Color.Name;
        }

        public long Id { get; set; }

        public string Nom { get; set; }

        public long Quantite { get; set; }

        public Uri PartUrl { get; set; }

        public Uri PartImgUrl { get; set; }

        public string Couleur { get; set; }
    }
}