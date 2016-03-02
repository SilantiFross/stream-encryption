using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stream_encryption.Classes;
using Stream_encryption.Properties;

namespace Stream_encryption
{
    public partial class MainForm : Form
    {
    
        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = Model.OpenFileBites();
        }

        private void radioButtonOne_CheckedChanged(object sender, EventArgs e)
        {
            labelLFSR1.Visible = true;
            textBoxLSFR1.Visible = true;
            labelLFSR1Length.Visible = true;
            labelLFSR2.Visible = false;
            textBoxLFSR2.Visible = false;
            labelLFSR2Length.Visible = false;
            labelLFSR3.Visible = false;
            textBoxLFSR3.Visible = false;
            labelLFSR3Length.Visible = false;
            labelRC4Key.Visible = false;
            textBoxRC4Key.Visible = false;
            labelRC4Length.Visible = false;
            buttonConvert.Enabled = true;
        }

        private void radioButtonScheme_CheckedChanged(object sender, EventArgs e)
        {
            labelLFSR1.Visible = true;
            textBoxLSFR1.Visible = true;
            labelLFSR1Length.Visible = true;
            labelLFSR2.Visible = true;
            textBoxLFSR2.Visible = true;
            labelLFSR2Length.Visible = true;
            labelLFSR3.Visible = true;
            textBoxLFSR3.Visible = true;
            labelLFSR3Length.Visible = true;
            labelRC4Key.Visible = false;
            textBoxRC4Key.Visible = false;
            labelRC4Length.Visible = false;
            buttonConvert.Enabled = true;
        }

        private void radioButtonRC4_CheckedChanged(object sender, EventArgs e)
        {
            labelRC4Key.Visible = true;
            textBoxRC4Key.Visible = true;
            labelRC4Length.Visible = true;
            labelLFSR1.Visible = false;
            textBoxLSFR1.Visible = false;
            labelLFSR1Length.Visible = false;
            labelLFSR2.Visible = false;
            textBoxLFSR2.Visible = false;
            labelLFSR2Length.Visible = false;
            labelLFSR3.Visible = false;
            textBoxLFSR3.Visible = false;
            labelLFSR3Length.Visible = false;
            buttonConvert.Enabled = true;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            List<byte> originalText;
            List<byte> key = new List<byte>();
            List<byte> cipherText = new List<byte>();
            List<byte> cipherTextInBytes;

            if (radioButtonOne.Checked)
            {
                const int sizeLinearShiftRegisterOne = 23;
                const int itemForXOROne = 5;

                originalText = Controller.OriginalTextInBits(textBoxInput.Text);

                LFSR lfsrOne = new LFSR(textBoxLSFR1.Text, sizeLinearShiftRegisterOne);
                key = lfsrOne.OperationWithRegister(originalText.Count, itemForXOROne, sizeLinearShiftRegisterOne);
                cipherText = Controller.Encryption(originalText, key);

                cipherTextInBytes = Controller.ConvertBitsInBytes(cipherText);

                Model.SaveFile(cipherTextInBytes);

            }
            else if (radioButtonScheme.Checked)
            { 
                const int sizeLinearShiftRegisterOne = 23;
                const int itemForXOROne = 5;
                const int sizeLinearShiftRegisterTwo = 31;
                const int itemForXORTwo = 3;
                const int sizeLinearShiftRegisterThree = 39;
                const int itemForXORThree = 4;

                originalText = Controller.OriginalTextInBits(textBoxInput.Text);

                LFSR lfsrOne = new LFSR(textBoxLSFR1.Text, sizeLinearShiftRegisterOne);
                LFSR lfsrTwo = new LFSR(textBoxLFSR2.Text, sizeLinearShiftRegisterTwo);
                LFSR lfsrThree = new LFSR(textBoxLFSR3.Text, sizeLinearShiftRegisterThree);

                var keyOne = lfsrOne.OperationWithRegister(originalText.Count, itemForXOROne, sizeLinearShiftRegisterOne);
                var keyTwo = lfsrTwo.OperationWithRegister(originalText.Count, itemForXORTwo, sizeLinearShiftRegisterTwo);
                var keyThree = lfsrThree.OperationWithRegister(originalText.Count, itemForXORThree, sizeLinearShiftRegisterThree);

                textBoxOutput.Text = Resources.KeyOne + Controller.ConclusionListToString(keyOne) + Environment.NewLine + Environment.NewLine;
                textBoxOutput.Text += Resources.KeyTwo + Controller.ConclusionListToString(keyTwo) + Environment.NewLine + Environment.NewLine;
                textBoxOutput.Text += Resources.ReyThree + Controller.ConclusionListToString(keyThree) + Environment.NewLine + Environment.NewLine;

                key = Controller.SchemeGeffe(keyOne, keyTwo, keyThree);
                cipherText = Controller.Encryption(originalText, key);

                cipherTextInBytes = Controller.ConvertBitsInBytes(cipherText);

                Model.SaveFile(cipherTextInBytes);

            }
            else if (radioButtonRC4.Checked)
            {
                RC4 rc4 = new RC4(Controller.GetNumbersFromString(textBoxRC4Key.Text));

                originalText = Controller.OriginalTextInBytes(textBoxInput.Text);

                key = rc4.GetSecretKey(originalText.Count);
                cipherText = Controller.Encryption(originalText, key);

                textBoxOutput.Text = Resources.OriginalText + Controller.ConclusionListToString(originalText) + Environment.NewLine;

                Model.SaveFile(cipherText);
            }

            textBoxOutput.Text += Resources.Key + Controller.ConclusionListToString(key) + Environment.NewLine;
            textBoxOutput.Text += Environment.NewLine + Environment.NewLine + Resources.CipherText + Controller.ConclusionListToString(cipherText);                   

        }

        /* The following three methods are used for the display length to the number entered in textBoxLFSR1/2/3 */
        private void textBoxLSFR1_KeyUp(object sender, KeyEventArgs e)
        {
            labelLFSR1Length.Text = Resources.Length + Model.KeyUp(textBoxLSFR1);
        }

        private void textBoxLFSR2_KeyUp(object sender, KeyEventArgs e)
        {
            labelLFSR2Length.Text = Resources.Length + Model.KeyUp(textBoxLFSR2);
        }

        private void textBoxLFSR3_KeyUp(object sender, KeyEventArgs e)
        {
            labelLFSR3Length.Text = Resources.Length + Model.KeyUp(textBoxLFSR3);
        }

        /* The following three methods are responsible for entering only numbers in the binary in textBoxLFSR1/2/3 */
        private void textBoxLSFR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Model.IsBinaryNumber(e.KeyChar);
        }

        private void textBoxLFSR2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Model.IsBinaryNumber(e.KeyChar);
        }

        private void textBoxLFSR3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Model.IsBinaryNumber(e.KeyChar);
        }

        /* This method are responsible for entering only decimal numbers in textBoxRC4Key */
        private void textBoxRC4Key_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Model.IsADecimalNumber(e.KeyChar);
        }
    }

}
