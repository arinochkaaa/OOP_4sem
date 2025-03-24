using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private enum ActionType
        {
            None,
            Replace,
            Delete,
            GetChar
        }

        private ActionType currentAction = ActionType.None; // ���������� ��� �������� ���������� ��������

        public Form1()
        {
            InitializeComponent();
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ������������� ��� ������ ��� �������� �����
        }

        // ���������� ��� ������ "������"
        private void button1_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.Replace;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Text = "������� ��������� ��� ������ � ����� ������";
        }

        // ���������� ��� ������ "��������"
        private void button2_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.Delete;
            textBox2.Visible = true;
            textBox3.Visible = false; // �������� ������ TextBox
            label1.Text = "������� ��������� ��� ��������";
        }

        // ���������� ��� ������ "��������� �������"
        private void button3_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.GetChar;
            textBox2.Visible = true;
            textBox3.Visible = false; // �������� ������ TextBox
            label1.Text = "������� ������ �������";
        }

        // ���������� ��� ������ "�����������" (Button 8)
        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                string value = textBox2.Text; // ���������, ������� ���� ��� ������ ��� ��������
                string replacement = textBox3.Text; // ����� ��������� ��� ������

                switch (currentAction)
                {
                    case ActionType.Replace:
                        if (!string.IsNullOrEmpty(replacement)) // ���� ������ ��� ������ �� ������
                        {
                            input = input.Replace(value, replacement); // �������� ���������
                            label1.Text = $"��������� ������: {input}";
                        }
                        else
                        {
                            label1.Text = "������� ������ ��� ������!";
                            return;
                        }
                        break;

                    case ActionType.Delete:
                        input = input.Replace(value, string.Empty); // ������� ���������
                        label1.Text = $"��������� ��������: {input}";
                        break;

                    case ActionType.GetChar:
                        if (int.TryParse(value, out int index) && index >= 0 && index < input.Length)
                        {
                            label1.Text = $"������ �� ������� {index}: {input[index]}";
                        }
                        else
                        {
                            label1.Text = "�������� ������!";
                        }
                        break;

                    default:
                        label1.Text = "�� ������� ��������!";
                        return;
                }

                // ������� ��������� ������ � textBox1
                textBox1.Text = input;

                // ������� ��������� �����
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox2.Visible = false; // �������� ������ TextBox
                textBox3.Visible = false; // �������� ������ TextBox

                // ������� ������� ��������
                currentAction = ActionType.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ������������� �����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ���������� ��� ������ "�����"
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                label1.Text = $"����� ������: {input.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ���������� ����� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ���������� ��� ������ "���������� �������/���������"
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text.ToLower();
                var vowels = "��������";
                var consonants = "������������������������";

                int vowelCount = input.Count(c => vowels.Contains(c));
                int consonantCount = input.Count(c => consonants.Contains(c));

                label1.Text = $"�������: {vowelCount}, ���������: {consonantCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� �������/���������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ���������� ��� ������ "���������� �����������"
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                var sentences = Regex.Split(input, @"(?<=[.!?])\s+");
                label1.Text = $"���������� �����������: {sentences.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� �����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ���������� ��� ������ "���������� ����"
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                var words = input.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                label1.Text = $"���������� ����: {words.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� ����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ���������� ��� ������� ��������� ������ � textBox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = $"���������� ��������: {textBox1.Text.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
