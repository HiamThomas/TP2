using System;
using System.Text;

namespace TP2
{
    public class Cesar
    {
        public static string Chiffrer(string text, string alphabet, string decalageText)
        {
            if (alphabet.Length == 0)
                return "Alphabet can't be empty";

            int decalage;
            try
            {
                decalage = Int32.Parse(decalageText);
            }
            catch (FormatException)
            {
                return $"Unable to parse '{decalageText}'";
            }

            StringBuilder alphabetEncodedBuilder = new StringBuilder(alphabet.ToUpper());
            alphabetEncodedBuilder.Remove(0, decalage);
            alphabetEncodedBuilder.Append(alphabet, 0, decalage);
            string alphabetEncoded = alphabetEncodedBuilder.ToString();

            StringBuilder result = new StringBuilder();
            int index;
            bool upper;
            foreach (var c in text)
            {
                upper = Char.IsUpper(c);
                if ((index = alphabet.IndexOf(upper ? c : Char.ToUpper(c))) < 0)
                    result.Append(c);
                else
                    result.Append(upper ? alphabetEncoded[index] : Char.ToLower(alphabetEncoded[index]));
            }

            return result.ToString();
        }

        public static string Dechiffrer(string text, string alphabet, string decalageText)
        {
            if (alphabet.Length == 0)
                return "Alphabet can't be empty";

            int decalage;
            try
            {
                decalage = Int32.Parse(decalageText);
            }
            catch (FormatException)
            {
                return $"Unable to parse '{decalageText}'";
            }

            StringBuilder alphabetEncodedBuilder = new StringBuilder(alphabet.ToUpper());
            alphabetEncodedBuilder.Remove(0, decalage);
            alphabetEncodedBuilder.Append(alphabet, 0, decalage);
            string alphabetEncoded = alphabetEncodedBuilder.ToString();

            StringBuilder result = new StringBuilder();
            int index;
            bool upper;
            foreach (var c in text)
            {
                upper = Char.IsUpper(c);
                if ((index = alphabetEncoded.IndexOf(upper ? c : Char.ToUpper(c))) < 0)
                    result.Append(c);
                else
                    result.Append(upper ? alphabet[index] : Char.ToLower(alphabet[index]));
            }

            return result.ToString();
        }
    }
}