using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegoBlazor.Data
{
    public class Produit
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
