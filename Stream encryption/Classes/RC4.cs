using System.Collections.Generic;

namespace Stream_encryption.Classes
{
    class Rc4
    {

        private readonly List<byte> _state = new List<byte>();

        public Rc4(List<byte> primaryKey)
        {
            for (int elementInState = 0; elementInState < 256; elementInState++)
                _state.Add((byte)elementInState);
            Permutations(primaryKey);
        }

        private void Permutations(List<byte> primaryKey)
        {
            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (byte)((j + _state[i] + primaryKey[i % primaryKey.Count]) % 256);
                byte temp = _state[i];
                _state[i] = _state[j];
                _state[j] = temp;
            }
        }

        public List<byte> GetSecretKey(int sizeOriginalText)
        {
            List<byte> key = new List<byte>();
            byte j = 0;
            byte i = 0;

            for (int a = 0; a < sizeOriginalText; a++)
            {
                i = (byte)((i + 1) % 256);
                j = (byte)((j + _state[i]) % 256);

                byte buf = _state[i];
                _state[i] = _state[j];
                _state[j] = buf;

                key.Add(_state[(_state[i] + _state[j]) % 256]);
            }

            return key;
        }

    }
}
