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
        }

        private void CalculateCRC_button_Click(object sender, EventArgs e)
        {
            int fromBase = Convert.ToInt32(comboBox1.Text);

            long message = Convert.ToInt64(message16_textBox.Text, fromBase);
            message2_textBox.Text = Convert.ToString(message, toBase: 2);

            long crc = CRC.CalculateCRC(message);
            CalculatedCRC_textBox.Text = Convert.ToString(crc, toBase:2);
            InputCRC_textBox.Text = Convert.ToString(crc, toBase: 2);
        }

        private void CheckData_button_Click(object sender, EventArgs e)
        {
            int fromBase = Convert.ToInt32(comboBox2.Text);
            bool isCorrect = CRC.CheckMessage(Convert.ToInt64(messageForCheck_textBox.Text, fromBase), Convert.ToInt64(InputCRC_textBox.Text, fromBase: 2));

            CheckResultLabel.Text = isCorrect ? "Данные приняты верно" : "Данные приняты с ошибкой";
        }
    }
}
