using System.Text;

namespace CaesarCipherApp
{
    class CaesarCipher
    {
        public static string Encrypt(string text, int shift)
        {
            var encryptedText = string.Empty;
            var asciiBytes = Encoding.ASCII.GetBytes(text);

            foreach(var asciiCode in asciiBytes)
            {
                encryptedText += (char)(asciiCode + shift);
            }

            return encryptedText;
        }
    }
}
