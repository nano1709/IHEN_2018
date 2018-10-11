using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SDC.BLL
{


    public class Seguridad
    {

        public static string Llave = "jskruwiqhendmsud";



        public string Decriptar(string contra)
        {

            try
            {
                byte[] keyArray = Encoding.UTF8.GetBytes(Llave);
                byte[] encriptar = Convert.FromBase64String(contra);

                var tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultado = cTransform.TransformFinalBlock(encriptar, 0, encriptar.Length);
                return Encoding.UTF8.GetString(resultado);
            }
            catch (Exception)
            {

                return "";
            }

        }

        public string Encriptar(string contra)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(Llave);
            byte[] encriptar = Encoding.UTF8.GetBytes(contra);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultado = cTransform.TransformFinalBlock(encriptar, 0, encriptar.Length);
            return Convert.ToBase64String(resultado, 0, resultado.Length);
        }




    }
}
