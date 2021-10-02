namespace TP2
{
    public class Vigenere
    {
        public static string run(string input, string key, bool cipher)
        {
            if (key.Length == 0)
                return "Key can't be empty";

            string output = "";
            int notALetter = 0;
            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter(input[i]))
                {
                    bool inputIsUpper = char.IsUpper(input[i]);
                    int shift = inputIsUpper ? 65 : 97; //décallage majuscule ou minuscule
                    int chKey = inputIsUpper
                        ? char.ToUpper(key[(i - notALetter) % key.Length])
                        : char.ToLower(key[(i - notALetter) % key.Length]); //caractère de la clé 
                    output += cipher ? encrypt(shift, chKey, input[i]) : decrypt(shift, chKey, input[i]);
                }
                else
                {
                    output += input[i];
                    notALetter++;
                }
            }

            return output;
        }

        private static char encrypt(int shift, int chKey, char input)
        {
            return (char) ((input - shift + chKey - shift) % 26 + shift);
        }

        private static char decrypt(int shift, int chKey, char input)
        {
            int a = input - shift - (chKey - shift);
            if (a < 0)
                a = 26 + a;
            return (char) (a % 26 + shift);
        }
    }
}