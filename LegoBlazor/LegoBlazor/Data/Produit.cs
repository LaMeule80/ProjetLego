﻿using LegoBlazor.Tools;

namespace LegoBlazor.Data
{
    public class Produit : IBase
    {
        public Produit(
            int id,
            int numero,
            string nom,
            int nbrePieces,
            int etat)
        {
            Id = id;
            Numero = numero;
            Nom = nom;
            NombrePieces = nbrePieces;
            Etat = etat;
        }

        public int Id { get; set; }

        public int Numero { get; set; }

        public string Nom { get; set; }

        public int NombrePieces { get; set; }

        public string Image => $"images/{Numero}.jpg";

        public int Etat { get; set; }
    }
}
