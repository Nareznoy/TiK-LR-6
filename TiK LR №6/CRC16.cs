using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiK_LR__6
{
    class CRC16
    {
        const ushort poly = 0b111001;
        ushort[] table = new ushort[256];

        /// <summary>
        /// Вычислить контрольную сумму
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public ushort ComputeChecksum(byte[] bytes)
        {
            ushort crc = 0xFFFF;

            foreach (var it in bytes)
            {
                crc = (ushort)((crc << 8) ^ table[((crc >> 8) ^ (0xff & it))]);
            }

            return crc;
        }

        /// <summary>
        /// Вычисление байтов контрольной суммы
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public byte[] ComputeChecksumBytes(byte[] bytes)
        {
            ushort crc = ComputeChecksum(bytes);
            return BitConverter.GetBytes(crc);
        }

        /// <summary>
        /// CRC 16 CITT
        /// </summary>
        /// <param name="initialValue"></param>
        public CRC16()
        {
            ushort temp, a;
            for (int i = 0; i < table.Length; ++i)
            {
                temp = 0;
                a = (ushort)(i << 8);
                for (int j = 0; j < 8; ++j)
                {
                    if (((temp ^ a) & 0x8000) != 0)
                    {
                        temp = (ushort)((temp << 1) ^ poly);
                    }
                    else
                    {
                        temp <<= 1;
                    }
                    a <<= 1;
                }
                table[i] = temp;
            }
        }
    }
}
