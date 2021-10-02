using System;
using System.Text;

namespace TP2
{
    public class Atbash
    {
        public static string Chiffrer(string text, string alphabet)
        {
            char[] charArray = alphabet.ToUpper().ToCharArray();
            Array.Reverse(charArray);
            string alphabetReverse = new string(charArray);

            StringBuilder result = new StringBuilder();
            int index;
            bool upper;
            foreach (var c in text)
            {
                upper = Char.IsUpper(c);
                if ((index = alphabet.IndexOf(upper ? c : Char.ToUpper(c))) < 0)
                    result.Append(c);
                else
                    result.Append(upper ? alphabetReverse[index] : Char.ToLower(alphabetReverse[index]));
            }

            return result.ToString();
        }

        public static string Dechiffrer(string text, string alphabet)
        {
            char[] charArray = alphabet.ToUpper().ToCharArray();
            Array.Reverse(charArray);
            string alphabetReverse = new string(charArray);

            StringBuilder result = new StringBuilder();
            int index;
            bool upper;
            foreach (var c in text)
            {
                upper = Char.IsUpper(c);
                if ((index = alphabetReverse.IndexOf(upper ? c : Char.ToUpper(c))) < 0)
                    result.Append(c);
                else
                    result.Append(upper ? alphabet[index] : Char.ToLower(alphabet[index]));
            }

            return result.ToString();
        }
    }
}