using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiK_LR__6
{
    static class CRC
    {
        private static long _poly = 0x235;
        private static readonly int _polyLength = (int) Math.Log(_poly, 2) + 1;

        private static int _inputCodeLength;

        public static long CalculateCRC(long inputCode)
        {
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
            return inputCode;
        }

        public static bool CheckMessage(long message, long crc)
        {
            message <<= _polyLength - 1;
            long messagePlusCrcInt = message + crc;

            return CalculateCRC(messagePlusCrcInt) == 0;
        }


    }
}
