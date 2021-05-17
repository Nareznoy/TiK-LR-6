using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TiK_LR__6
{
    public partial class Form1 : Form
    {
        List<long> inputMessages = new List<long>();
        List<long> CRCs = new List<long>();
        List<bool> isCorrect = new List<bool>();
        List<long> messagesForCheck = new List<long>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateCRC_button_Click(object sender, EventArgs e)
        {
            int fromBase = Convert.ToInt32(comboBox1.Text);

            string[] stringMessages = message16_textBox.Text.Split();
            foreach (string str in stringMessages)
            {
                inputMessages.Add(Convert.ToInt64(str, fromBase));
                message2_textBox.Text += Convert.ToString(inputMessages.Last(), toBase: 2) + " ";
                CRCs.Add(CRC.CalculateCRC(inputMessages.Last()));
                CalculatedCRC_textBox.Text += Convert.ToString(CRCs.Last(), toBase: 2) + " ";
                InputCRC_textBox.Text += Convert.ToString(CRCs.Last(), toBase: 2) + " ";
            }
        }

        private void CheckData_button_Click(object sender, EventArgs e)
        {
            int fromBase = Convert.ToInt32(comboBox2.Text);
            string[] stringMessages = messageForCheck_textBox.Text.Split();

            bool state = true;
            string error = "";


            for (int i = 0; i < stringMessages.Length; i++)
            {
                messagesForCheck.Add(Convert.ToInt64(stringMessages[i], fromBase));

                isCorrect.Add(CRC.CheckMessage(messagesForCheck.Last(), CRCs[i]));
                if (!isCorrect.Last())
                {
                    state = false;
                    error += i + 1 + " ";
                }
            }


            CheckResultLabel.Text = state ? "Данные приняты верно" : "Данные приняты с ошибкой в блоке: " + error;
        }
    }
}
