using Web.BLL.Interfaces;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Web.BLL.Business
{
    public class SeguridadBusiness : ISeguridadBusiness
    {
        public string GetLocalIPAddress()
        {
            var ip = (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null
               && HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != "")
               ? HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"]
               : HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

            if (ip.Contains(","))
            {
                string[] addresses = ip.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return ip;
        }

        /* Nueva encriptación de contraseña */
        public string EncriptarPassword(string cadena)
        {
            return RijndaelSimple.Encriptar(cadena);
        }

        public string DesencriptarPassword(string cadena)
        {
            return RijndaelSimple.Desencriptar(cadena);
        }

        public static class RijndaelSimple
        {
            private const string passWordBase = "pass75dc@avz10";
            private const string saltValueBytes = "s@lAvz";
            private const string hashAlgorithm = "SHA1";
            private const string vectorInicial = "@1B2c3D4e5F6g7H8";
            private const int iteraciones = 10;
            private const int tamanodeLlave = 256;

            public static string Encriptar(string aEncriptar)
            {
                return Encriptar(aEncriptar, passWordBase, saltValueBytes, hashAlgorithm, iteraciones, vectorInicial, tamanodeLlave);
            }

            public static string Encriptar(string aEncriptar, string passBase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
            {

                byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(aEncriptar);

                PasswordDeriveBytes password = new PasswordDeriveBytes(passBase, saltValueBytes, hashAlgorithm, passwordIterations);

                byte[] keyBytes = password.GetBytes(keySize / 8);

                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;

                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);

                MemoryStream memoryStream = new MemoryStream();

                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                string cipherText = Convert.ToBase64String(cipherTextBytes);
                return cipherText;
            }

            public static string Desencriptar(string textoEncriptado)
            {
                return Desencriptar(textoEncriptado, passWordBase, saltValueBytes, hashAlgorithm, iteraciones, vectorInicial, tamanodeLlave);
            }

            public static string Desencriptar(string textoEncriptado, string passBase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
            {
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
                byte[] cipherTextBytes = Convert.FromBase64String(textoEncriptado);

                PasswordDeriveBytes password = new PasswordDeriveBytes(passBase, saltValueBytes, hashAlgorithm, passwordIterations);
                byte[] keyBytes = password.GetBytes(keySize / 8);

                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;


                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);

                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

                byte[] plainTextBytes = new byte[cipherTextBytes.Length];

                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

                memoryStream.Close();

                cryptoStream.Close();

                string plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);

                return plainText;
            }
        }

        public static string DesencriptarCSPassword(string cadena)
        {
            return RijndaelSimple.Desencriptar(cadena);
        }
    }
}
