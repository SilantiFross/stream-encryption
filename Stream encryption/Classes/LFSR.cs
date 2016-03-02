using System.Collections.Generic;

namespace Stream_encryption.Classes
{
    class LFSR
    {
        private readonly List<byte> linearShiftRegister = new List<byte>();

        public LFSR(string initialStateLFSR, int sizeLFSR)
        {
            GetInitalStateInList(initialStateLFSR, sizeLFSR);
        }

        public List<byte> OperationWithRegister(int sizeOriginalText, int itemForXOR, int sizeLinearShiftRegister)
        {
            List<byte> key = new List<byte>();
            int lastElementLFSR = linearShiftRegister.Count;

            for (int positionInOriginalText = 0; positionInOriginalText <= sizeOriginalText; positionInOriginalText++)
            {
                key.Add(linearShiftRegister[0]);

                var valueAfterXOR = linearShiftRegister[0] ^ linearShiftRegister[sizeLinearShiftRegister - itemForXOR];

                for (int elementLFSR = 0; elementLFSR <= lastElementLFSR - 2; elementLFSR++)
                {
                    linearShiftRegister[elementLFSR] = linearShiftRegister[elementLFSR + 1];
                }

                linearShiftRegister[sizeLinearShiftRegister - 1] = (byte)valueAfterXOR;
            }

            return key;
        }

        private void GetInitalStateInList(string initialStateLFSR, int sizeLFSR)
        {
            if (initialStateLFSR.Length == sizeLFSR)
            {
                for (int elementLFSR = 0; elementLFSR < sizeLFSR; elementLFSR++)
                    linearShiftRegister.Add(initialStateLFSR[elementLFSR] == '1' ? (byte)1 : (byte)0);
            }
            else
                for (int elementLFSR = 0; elementLFSR < sizeLFSR; elementLFSR++)
                    linearShiftRegister.Add(0);
        }

    }
}
