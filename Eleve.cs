using System;

namespace EleveDll
{
    public class Eleve
    {
        private string nom;
        private float note_oral, note_ecrit;

        public string Nom { get => nom; set => nom = value; }
        public float Oral { get => note_oral; set => note_oral = value; }
        public float Ecrit { get => note_ecrit; set => note_ecrit = value; }

        public Eleve(string nom, float note_oral, float note_ecrit)
        {
            this.Nom = nom;
            this.Oral = note_oral;
            this.Ecrit = note_ecrit;
        }
        private float moyenne()
        {
            return  (2 * this.Ecrit + this.Oral) / 3;
        }
        public  string afficher()
        {
            return this.nom + moyenne() + "La meilleur moyenne est " + meilleur() + "de" + Nom + "."; ;
        }
       
        public override string ToString()
        {
            return nom + "." + Ecrit.ToString() + "." + Oral.ToString();
        }
        public static string meilleur()
        {
            if ()
            {

            }
        }

    }
}

