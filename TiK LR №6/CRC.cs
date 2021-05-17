using System;

namespace TiK_LR__6
{
    static class CRC
    {
        private static long _poly = 0b10010010101; // Генераторный полином: x^10 + x^7 + x^4 + x^2 + 1
        private static readonly int _polyLength = (int) Math.Log(_poly, 2) + 1;

        private static int _inputCodeLength;

        public static long CalculateCRC(long inputCode, bool isCheck = false)
        {
            // Добавление в конце принятого сообщения нулей
            if(!isCheck)
                inputCode <<= _polyLength - 1;

            _inputCodeLength = (int)Math.Log(inputCode, 2) + 1;
            _poly <<= (_inputCodeLength - _polyLength); // Сдвиг полинома до старшего бита принятого сообщения

            for (var i = 0; i < (_inputCodeLength - _polyLength); i++)
            {
                // Когда полином сдвигается до текущего старшего бита, выполняется операция XOR
                if ((inputCode & (1 << (_inputCodeLength - i - 1))) == (1 << (_inputCodeLength - i - 1)))
                {
                    inputCode ^= _poly;
                }
                _poly >>= 1;
            }
            // Если размер текущего остатка равен размеру полинома, то выполнить XOR еще один раз
            if ((int)Math.Log(inputCode, 2) + 1 == (int)Math.Log(_poly, 2) + 1)
            {
                inputCode ^= _poly;
            }

            return inputCode;
        }

        public static bool CheckMessage(long message, long crc)
        {
            message <<= _polyLength - 1; // Добавление в конец сообщения нулей
            long messagePlusCrcInt = message + crc; // Прибавление к сообщению CRC кода

            return CalculateCRC(messagePlusCrcInt, true) == 0; // Равен ли CRC код нулю
        }
    }
}
