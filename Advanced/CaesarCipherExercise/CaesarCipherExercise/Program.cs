using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plainText = "z";
            string cipherText = " ";
            char[] cipher;
            Console.WriteLine("Plain Text: ");
            foreach (var item in plainText)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Cipher Text: ");
            cipher = CaesarCipher.Encrypt(plainText, 3);
            foreach (var item in cipher)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("plainText: ");
            foreach (var item in CaesarCipher.Dencrypt(plainText, 0))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

        }
        class CaesarCipher
        {
            public static char[] Encrypt(string plainText, int shift)
            {
                char[] plainArray = plainText.ToLower().ToCharArray();
                char[] cipherArray = new char[plainArray.Length];
                for (int i = 0; i < plainArray.Length; i++)
                {
                    char letter = plainArray[i];
                    if (letter != ' ')
                    {
                        letter = (char)(letter + shift);
                        if (letter > 'z')
                        {
                            letter = (char)(letter - 26);
                        }
                        if (letter < 'a')
                        {
                            letter = (char)(letter + 26);
                        }
                        cipherArray[i] = letter;
                    }
                }
                return cipherArray;
            }
            public static char[] Dencrypt(string cipherText, int shift)
            {
                char[] cipherArray = cipherText.ToLower().ToCharArray();
                char[] plainArray = new char[cipherArray.Length];
                for (int i = 0; i < cipherArray.Length; i++)
                {
                    char letter = cipherArray[i];
                    if (letter != ' ')
                    {
                        letter = (char)(letter - shift);
                        if (letter > 'z')
                        {
                            letter = (char)(letter - 26 );
                        }
                        if (letter< 'a')
                        {
                            letter = (char)(letter + 26);
                        }
                        plainArray[i] = letter;
                    }
                }
                return plainArray;
            }
        }
    }
}
