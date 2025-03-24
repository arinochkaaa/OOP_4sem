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

        private ActionType currentAction = ActionType.None; // Переменная для хранения выбранного действия

        public Form1()
        {
            InitializeComponent();
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация или логика при загрузке формы
        }

        // Обработчик для кнопки "Замена"
        private void button1_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.Replace;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Text = "Введите подстроку для замены и новую строку";
        }

        // Обработчик для кнопки "Удаление"
        private void button2_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.Delete;
            textBox2.Visible = true;
            textBox3.Visible = false; // Скрываем третий TextBox
            label1.Text = "Введите подстроку для удаления";
        }

        // Обработчик для кнопки "Получение символа"
        private void button3_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.GetChar;
            textBox2.Visible = true;
            textBox3.Visible = false; // Скрываем третий TextBox
            label1.Text = "Введите индекс символа";
        }

        // Обработчик для кнопки "Подтвердить" (Button 8)
        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                string value = textBox2.Text; // Подстрока, которую ищем для замены или удаления
                string replacement = textBox3.Text; // Новая подстрока для замены

                switch (currentAction)
                {
                    case ActionType.Replace:
                        if (!string.IsNullOrEmpty(replacement)) // Если строка для замены не пустая
                        {
                            input = input.Replace(value, replacement); // Заменяем подстроку
                            label1.Text = $"Результат замены: {input}";
                        }
                        else
                        {
                            label1.Text = "Введите строку для замены!";
                            return;
                        }
                        break;

                    case ActionType.Delete:
                        input = input.Replace(value, string.Empty); // Удаляем подстроку
                        label1.Text = $"Результат удаления: {input}";
                        break;

                    case ActionType.GetChar:
                        if (int.TryParse(value, out int index) && index >= 0 && index < input.Length)
                        {
                            label1.Text = $"Символ на индексе {index}: {input[index]}";
                        }
                        else
                        {
                            label1.Text = "Неверный индекс!";
                        }
                        break;

                    default:
                        label1.Text = "Не выбрано действие!";
                        return;
                }

                // Выводим изменённую строку в textBox1
                textBox1.Text = input;

                // Очистка текстовых полей
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox2.Visible = false; // Скрываем второй TextBox
                textBox3.Visible = false; // Скрываем третий TextBox

                // Сбросим текущее действие
                currentAction = ActionType.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подтверждении ввода: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик для кнопки "Длина"
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                label1.Text = $"Длина строки: {input.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении длины строки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик для кнопки "Количество гласных/согласных"
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text.ToLower();
                var vowels = "аеёиоуэюя";
                var consonants = "бвгдеёжзийклмнопрстфхцчшщ";

                int vowelCount = input.Count(c => vowels.Contains(c));
                int consonantCount = input.Count(c => consonants.Contains(c));

                label1.Text = $"Гласных: {vowelCount}, Согласных: {consonantCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подсчете гласных/согласных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик для кнопки "Количество предложений"
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                var sentences = Regex.Split(input, @"(?<=[.!?])\s+");
                label1.Text = $"Количество предложений: {sentences.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подсчете предложений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик для кнопки "Количество слов"
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                var words = input.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                label1.Text = $"Количество слов: {words.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подсчете слов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик для события изменения текста в textBox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = $"Количество символов: {textBox1.Text.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при изменении текста: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
