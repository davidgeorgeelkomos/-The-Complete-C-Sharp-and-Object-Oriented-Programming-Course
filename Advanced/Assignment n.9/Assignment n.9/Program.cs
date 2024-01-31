using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_n._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Exite = false;

            string Choose = " ";
            string plainText = " from string ";
            string cipherText = " from srting ";
            
            char[] cipher;

            
            while (!Exite)
            {
                


                userChoosies();
                
            }
            void StartLines()
            {
                Console.WriteLine("Welcome to Caeser Cipher App.\n\nChoose number to start..");
                Console.WriteLine("Enter 1 to Encrypt");
                Console.WriteLine("Enter 2 to Decrypt");
                Console.WriteLine("Enter 3 to Exite");
            }

            void userChoosies()
            {
                while (!Exite) 
                {
                    StartLines();
                    Choose = Console.ReadLine();

                    if (Choose == "1")
                    {
                        In1Choose();

                    }
                    else if (Choose == "2")
                    {
                        In2Choose();
                        
                    }
                    else if (Choose == "3")
                    {
                        Exite = true;

                    }
                    else
                    {
                        Console.WriteLine("Error in input, please put the right number");
                    }
                }
                
            }
            
            void In1Choose()
            {
                string choose1 = "";
                bool C1 = false;
                Console.Clear();
                Console.WriteLine("Type the word to encrypt ");
                plainText = Console.ReadLine();
                Console.WriteLine("Type number to Shift");
                string ShiftString = Console.ReadLine();
                bool shiftbool = int.TryParse(ShiftString, out int ShiftInt);
                if (shiftbool)
                {
                    cipher = CaesarCipher.Encrypt(plainText, ShiftInt);
                    foreach (var item in cipher)
                    {
                        Console.Write(item);
                    }
                }
                else
                {
                    Console.WriteLine("no");
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("1 Do you want to decrpt it?");
                Console.WriteLine("2 Do you want the mine menu");
                choose1 = Console.ReadLine();
                while (!C1)
                {
                    if (choose1 == "1")
                    {
                        Console.WriteLine("plainText: ");
                        foreach (var item in CaesarCipher.Dencrypt(plainText, 0))
                        {
                            Console.Write(item);
                        }
                        Console.WriteLine("\n\n");
                        C1= true;
                        
                    }
                    else if (choose1 == "2")
                    {
                        Console.Clear();
                        C1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Error in input, please put the right number");
                    }
                }
            }
        
            void In2Choose()
            {
                Console.WriteLine("Type the word you want to Decrypt");
                cipherText = Console.ReadLine();
                Console.WriteLine("Type number to Shift");
                string ShiftString = Console.ReadLine();
                bool shiftbool = int.TryParse(ShiftString, out int ShiftInt);
                if (shiftbool)
                {
                    Console.WriteLine("CipherText: ");
                    foreach (var item in CaesarCipher.Dencrypt(cipherText, ShiftInt))
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine("\n\n");
                }
                else
                {
                    Console.WriteLine("no");
                }

            }


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
                    else
                    {
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
                            letter = (char)(letter - 26);
                        }
                        if (letter < 'a')
                        {
                            letter = (char)(letter + 26);
                        }
                        plainArray[i] = letter;
                    }
                    else
                    {
                        plainArray[i] = letter;
                    }

                }

                return plainArray;
            }
        }
    }
}
