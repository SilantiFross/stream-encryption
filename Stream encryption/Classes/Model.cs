using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Stream_encryption.Properties;

namespace Stream_encryption.Classes
{
    internal static class Model
    { 

        //This function returns a string consisting of the binary contents of the file.
        public static string OpenFileBites()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"D\";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK) return ("File not opened! Try again.");
            try
            {
                var bytesOriginalText = new List<byte>();
                var contentFile = new BinaryReader((File.Open(openFileDialog.FileName, FileMode.Open)));

                while (contentFile.BaseStream.Position <= contentFile.BaseStream.Length - 1)
                    bytesOriginalText.Add(contentFile.ReadByte());    

                StringBuilder byteInString = new StringBuilder();

                foreach (byte singleBit in bytesOriginalText)
                    byteInString.Append(Convert.ToString(singleBit, 2).PadLeft(8, '0'));

                return byteInString.ToString();
            }
            catch (Exception ex)
            {
                return ("Error. Could not read file from disk. Original error:" + ex.Message);
            }
        }

        public static void SaveFile(List<byte> cipherText)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = Resources.AllowedExtensions,
                InitialDirectory = @"D\"
            };

            if (saveFile.ShowDialog() != DialogResult.OK) return;
            BinaryWriter bw = new BinaryWriter(File.Create(saveFile.FileName));
            bw.Write(cipherText.ToArray());
            bw.Close();
        }

        public static int KeyUp(TextBox textBoxLfsr)
        {
            return textBoxLfsr.Text.Length;
        }

        public static bool IsBinaryNumber(char key)
        {
            return (key != '1') && (key != '0') && (key != 8);
        }

        public static bool IsADecimalNumber(char key)
        {
            return (!char.IsDigit(key)) && (key != ' ') && (key != 8);
        }
    }
}
