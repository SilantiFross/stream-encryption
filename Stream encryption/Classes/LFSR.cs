using System.Collections.Generic;

namespace Stream_encryption.Classes
{
    internal class Lfsr
    {
        private readonly List<byte> _linearShiftRegister = new List<byte>();

        public Lfsr(string initialStateLfsr, int sizeLfsr)
        {
            GetInitalStateInList(initialStateLfsr, sizeLfsr);
        }

        public List<byte> OperationWithRegister(int sizeOriginalText, int itemForXor, int sizeLinearShiftRegister)
        {
            var key = new List<byte>();
            int lastElementLfsr = _linearShiftRegister.Count;

            for (int positionInOriginalText = 0; positionInOriginalText <= sizeOriginalText; positionInOriginalText++)
            {
                key.Add(_linearShiftRegister[0]);

                var valueAfterXor = _linearShiftRegister[0] ^ _linearShiftRegister[sizeLinearShiftRegister - itemForXor];

                for (int elementLfsr = 0; elementLfsr <= lastElementLfsr - 2; elementLfsr++)
                {
                    _linearShiftRegister[elementLfsr] = _linearShiftRegister[elementLfsr + 1];
                }

                _linearShiftRegister[sizeLinearShiftRegister - 1] = (byte)valueAfterXor;
            }

            return key;
        }

        private void GetInitalStateInList(string initialStateLfsr, int sizeLfsr)
        {
            if (initialStateLfsr.Length == sizeLfsr)
            {
                for (int elementLfsr = 0; elementLfsr < sizeLfsr; elementLfsr++)
                    _linearShiftRegister.Add(initialStateLfsr[elementLfsr] == '1' ? (byte)1 : (byte)0);
            }
            else
                for (int elementLfsr = 0; elementLfsr < sizeLfsr; elementLfsr++)
                    _linearShiftRegister.Add(0);
        }

    }
}
