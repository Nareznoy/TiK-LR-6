using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiK_LR__6
{
    static class CRC
    {
        private static long _poly = 0b11001;
        private static readonly int _polyLength = (int) Math.Log(_poly, 2) + 1;

        private static int _inputCodeLength;

        public static long CalculateCRC(long inputCode, bool isCheck = false)
        {
            if(!isCheck)
                inputCode <<= _polyLength - 1;

            _inputCodeLength = (int)Math.Log(inputCode, 2) + 1;
            _poly <<= (_inputCodeLength - _polyLength);

            for (var i = 0; i < (_inputCodeLength - _polyLength); i++)
            {
                if ((inputCode & (1 << (_inputCodeLength - i - 1))) == (1 << (_inputCodeLength - i - 1)))
                {
                    inputCode ^= _poly;
                }
                _poly >>= 1;
            }
            if ((int)Math.Log(inputCode, 2) + 1 == (int)Math.Log(_poly, 2) + 1)
            {
                inputCode ^= _poly;
            }
            return inputCode;
        }

        private static long MSB(long inputCode)
        {
            int currentInputLength = (int)Math.Log(inputCode, 2) + 1;
            int currentPolyLength = (int)Math.Log(_poly, 2) + 1;
            for (var i = 0; i < (currentPolyLength - currentInputLength); i++)
            {
                if ((inputCode & (1 << (currentPolyLength - i - 1))) != (1 << (currentPolyLength - i - 1)))
                {
                    _poly >>= 1;
                }
            }
            return _poly;
        }

        public static bool CheckMessage(long message, long crc)
        {
            message <<= _polyLength - 1;
            long messagePlusCrcInt = message + crc;

            return CalculateCRC(messagePlusCrcInt, true) == 0;
        }


    }
}
