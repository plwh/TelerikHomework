/* Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string 
with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first. */

using System;
using System.Text;

class Encode_Decode
{
    static string MyXOR(string data,string key)
    {
        string retValue = "";
        int i = 0;
        int x = 0;
        int[] cipher = new int[data.Length];
        x = 0;
        for (i = 0; i < data.Length; i++)
        {
            //Console.Write((char)((data[i] ^ key[x])));
            retValue = retValue + (char)((data[i] ^ key[x]));
            cipher[i] = (data[i] ^ key[x]);
            x++;
            if (x >= key.Length)
                x = 0;
        }
        return retValue;
    }
    static void Main()
    {                                                                                                                                                                                                                                       
        string example = "We are living in an yellow submarine.";
        Console.WriteLine("We are given string\n{0}",example);
        Console.Write("Enter encryption key:");
        string encryptionKey = Console.ReadLine();
        Console.WriteLine("Encrypted text:");
        Console.WriteLine((MyXOR(example,encryptionKey)));
        Console.WriteLine("Decrypted text:");
        Console.WriteLine(MyXOR(MyXOR(example, encryptionKey),encryptionKey));
    }
}
