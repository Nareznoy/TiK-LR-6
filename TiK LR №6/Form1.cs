using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiK_LR__6
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            CRC16 crc16 = new CRC16();

            byte[] crcBytes = crc16.ComputeChecksumBytes(new byte[] { 1, 0, 0, 1, 1, 1, 0, 1 });
            ushort crc = crc16.ComputeChecksum(new byte[] {1, 0, 0, 1, 1, 1, 0, 1});

        }
    }
}
