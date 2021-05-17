using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TiK_LR__6
{
    public partial class Form1 : Form
    {
        readonly List<long> _inputMessages = new List<long>(); // Входные блоки данных
        readonly List<long> _CRCs = new List<long>(); // CRC коды входных блоков данных
        readonly List<bool> _isCorrect = new List<bool>(); // Содержит информацию о проверенных блоках данных
        readonly List<long> _messagesForCheck = new List<long>(); // Принятые сообщения для проверки

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
                // Конвертация входного блока данных
                _inputMessages.Add(Convert.ToInt64(str, fromBase));
                message2_textBox.Text += Convert.ToString(_inputMessages.Last(), toBase: 2) + " ";

                // Получение CRC кода входного блока данных
                _CRCs.Add(CRC.CalculateCRC(_inputMessages.Last())); 
                CalculatedCRC_textBox.Text += Convert.ToString(_CRCs.Last(), toBase: 2) + " ";
                InputCRC_textBox.Text += Convert.ToString(_CRCs.Last(), toBase: 2) + " ";
            }
        }

        private void CheckData_button_Click(object sender, EventArgs e)
        {
            bool state = true; // Есть ли ошибка в принятом коде
            string errorBlockNumber = ""; // Номер блока с ошибкой

            int fromBase = Convert.ToInt32(comboBox2.Text);
            string[] stringMessages = messageForCheck_textBox.Text.Split();
            for (int i = 0; i < stringMessages.Length; i++)
            {
                _messagesForCheck.Add(Convert.ToInt64(stringMessages[i], fromBase));

                _isCorrect.Add(CRC.CheckMessage(_messagesForCheck.Last(), _CRCs[i])); // Проверка принятого сообщения

                if (_isCorrect.Last()) continue; // Если сообщение без ошибок, то проверить следующее
                state = false; 
                errorBlockNumber += i + 1 + " "; 
            }

            CheckResultLabel.Text = state ? "Данные приняты верно" : "Данные приняты с ошибкой в блоке: " + errorBlockNumber;
        }
    }
}
