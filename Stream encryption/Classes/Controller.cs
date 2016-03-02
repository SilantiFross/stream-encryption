using System;
using System.Collections.Generic;
using System.Linq;

namespace Stream_encryption.Classes
{
    internal class Controller
    {
        public static List<byte> OriginalTextInBits(string textBoxInput)
        {
            return textBoxInput.Select(t => (byte) t).ToList();
        }

        public static List<byte> OriginalTextInBytes(string textBoxInput)
        {
            List<byte> originalText = new List<byte>();
            string oneByte = null;

            for (int i = 0; i < textBoxInput.Length;)
            {
                for (int j = 0; j < 8; j++)
                    oneByte += textBoxInput[i++];

                int num = Convert.ToInt32(oneByte, 2);
                originalText.Add((byte)num);
                oneByte = null;
            }

            return originalText;
        }

        public static List<byte> ConvertBitsInBytes(List<byte> listWithBites)
        {
            List<byte> listWithBytes = new List<byte>();
            string oneByte = null;

            for (int i = 0; i < listWithBites.Count;)
            {
                for (int j = 0; j < 8; j++)
                    oneByte += listWithBites[i++];

                int num = Convert.ToInt32(oneByte, 2);
                listWithBytes.Add((byte)num);
                oneByte = null;
            }

            return listWithBytes;

        }

        public static List<byte> Encryption(List<byte> originalText, List<byte> key)
        {
            return originalText.Select((t, bit) => t ^ key[bit]).Select(encryptedBit => (byte) (encryptedBit)).ToList();
        }

        public static List<byte> SchemeGeffe(List<byte> keyOne, List<byte> keyTwo, List<byte> keyThree)
        {
            return keyOne.Select((t, x) => ((t & keyTwo[x]) | ((t ^ 0) & keyThree[x]))).Select(keyBit => (byte) keyBit).ToList();
        }

        public static List<byte> GetNumbersFromString(string textIntextBoxRc4Key)
        {
            List<byte> result = new List<byte>();

            foreach (string s in textIntextBoxRc4Key.Split(' '))
            {
                if ((int.Parse(s) >= 0) && (int.Parse(s) <= 255))
                    result.Add(byte.Parse(s));
                else
                    result.Add(255);
            }

            return result;
        }

        public static string ConclusionListToString(List<byte> key)
        {
            string generatedKey = null;

            foreach (var bite in key)
            {
                generatedKey += bite;
                generatedKey += ' ';
            }

            return generatedKey;
        }


    }
}
