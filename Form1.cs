using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rbBul.Checked = true;
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Моля, въведете текст за анализ!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isBg = rbBul.Checked;
            StringBuilder res = new StringBuilder();
            res.Append($"[{DateTime.Now:HH:mm:ss}] Анализ: ");

            bool selected = false;

            if (checkSymbols.Checked)
            {
                int count = GetCharCount(text);
                res.Append($"Символи: {count} ; ");
                selected = true;
            }
            if (checkWords.Checked)
            {
                int count = GetWordCount(text);
                res.Append($"Думи: {count} ; ");
                selected = true;
            }
            if (checkVowels.Checked)
            {
                int count = GetVowelCount(text, isBg);
                string lang = isBg ? "български" : "английски";
                res.Append($"Гласни ({lang}): {count} ; ");
                selected = true;
            }
            if (checkDigits.Checked)
            {
                int count = GetDigitCount(text);
                res.Append($"Цифри: {count} ; ");
                selected = true;
            }
            if (checkLongest.Checked)
            {
                string longest = GetLongest(text);
                res.Append($"Най-дълга дума: {longest} ; ");
                selected = true;
            }

            if (!selected)
            {
                MessageBox.Show("Моля, изберете поне една настройка за анализ!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listOutput.Items.Add(res.ToString());

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Моля, въведете текст!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char[] chars = text.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];

                if (char.IsUpper(c)) chars[i] = char.ToLower(c);
                else if (char.IsLower(c)) chars[i] = char.ToUpper(c);
            }

            txtInput.Text = new string(chars);
        }

        //helpers
        private int GetCharCount(string text)
        {
            int count = 0;
            foreach (char c in text) if (!char.IsWhiteSpace(c)) count++;

            return count;
        }

        private int GetWordCount(string text)
        {
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        private int GetVowelCount(string text, bool isBg)
        {
            string vowels = isBg ? "аиуеоъАИУЕОЪ" : "aiueoAIUEO";
            int count = 0;

            foreach (char c in text) if (vowels.Contains(c)) count++;

            return count;
        }

        private int GetDigitCount(string text)
        {
            int count = 0;
            foreach (char c in text) if (char.IsDigit(c)) count++;

            return count;
        }

        private string GetLongest(string text)
        {
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '?', '!', '(', ')', '-', ';', ':', '\"' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0) return "";

            string longest = words[0];

            foreach (string w in words) if (w.Length > longest.Length) longest = w;

            return longest;
        }

        
    }
}
