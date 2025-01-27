using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class Encrypt
{
    // Encrypt and decrypt the savegame to prevent modification from "hackers"
    // Changing keys below will reset the game on exit. Pick something and stick with it ;)

    private const string key1 = "MoneyMakerGame20"; // Must be 16 chars, 
    private const string key2 = "TycoonGamerPro24"; // Must be 16 chars

    // This constant is used to determine the keysize of the encryption algorithm
    private const int keysize = 256;

    //Encrypt
    public static string EncryptString(string plainText)
    {
        var initVectorBytes = Encoding.UTF8.GetBytes(key1);
        var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        var password = new PasswordDeriveBytes(key2, null);
        var keyBytes = password.GetBytes(keysize / 8);
        var symmetricKey = new RijndaelManaged();
        symmetricKey.Mode = CipherMode.CBC;
        var encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
        var memoryStream = new MemoryStream();
        var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
        cryptoStream.FlushFinalBlock();
        var cipherTextBytes = memoryStream.ToArray();
        memoryStream.Close();
        cryptoStream.Close();
        return Convert.ToBase64String(cipherTextBytes);
    }

    //Decrypt
    public static string DecryptString(string cipherText)
    {
        var initVectorBytes = Encoding.UTF8.GetBytes(key1);
        var cipherTextBytes = Convert.FromBase64String(cipherText);
        var password = new PasswordDeriveBytes(key2, null);
        var keyBytes = password.GetBytes(keysize / 8);
        var symmetricKey = new RijndaelManaged();
        symmetricKey.Mode = CipherMode.CBC;
        var decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
        var memoryStream = new MemoryStream(cipherTextBytes);
        var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
        var plainTextBytes = new byte[cipherTextBytes.Length];
        var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
        memoryStream.Close();
        cryptoStream.Close();
        return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
    }
}