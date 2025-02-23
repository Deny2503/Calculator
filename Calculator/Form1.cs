namespace Calculator
{
    public partial class Form1 : Form
    {
        private string operation = ""; // Операция (+, -, *, /)
        private double firstNumber = 0; // Первое число
        private bool isNewEntry = true; // Флаг для очистки при новом вводе
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != null)
            {
                if (isNewEntry || string.IsNullOrWhiteSpace(textBoxDisplay.Text) || textBoxDisplay.Text == "0")
                {
                    textBoxDisplay.Text = btn.Text; 
                    isNewEntry = false;
                }
                else
                {
                    textBoxDisplay.Text += btn.Text;
                }
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != null)
            {
                if (firstNumber == 0)
                {
                    if (double.TryParse(textBoxDisplay.Text, out firstNumber))
                    {
                        operation = btn.Text;
                        isNewEntry = true;
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (double.TryParse(textBoxDisplay.Text, out double secondNumber))
                    {
                        double result = 0;
                        switch (operation)
                        {
                            case "+": result = firstNumber + secondNumber; break;
                            case "-": result = firstNumber - secondNumber; break;
                            case "*": result = firstNumber * secondNumber; break;
                            case "/":
                                if (secondNumber != 0)
                                    result = firstNumber / secondNumber;
                                else
                                {
                                    MessageBox.Show("Деление на ноль запрещено!");
                                    return;
                                }
                                break;
                        }
                        textBoxDisplay.Text = result.ToString();
                        listBoxHistory.Items.Add($"{firstNumber} {operation} {secondNumber} = {result}");
                        firstNumber = result;
                        operation = btn.Text;
                        isNewEntry = true;
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxDisplay.Text, out double secondNumber))
            {
                double result = 0;

                switch (operation)
                {
                    case "+": result = firstNumber + secondNumber; break;
                    case "-": result = firstNumber - secondNumber; break;
                    case "*": result = firstNumber * secondNumber; break;
                    case "/":
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                        {
                            MessageBox.Show("Ошибка: деление на ноль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }

                textBoxDisplay.Text = result.ToString();
                listBoxHistory.Items.Add($"{firstNumber} {operation} {secondNumber} = {result}");
                isNewEntry = true;
            }
            else
            {
                MessageBox.Show("Введите корректное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";  
            firstNumber = 0;
            operation = "";
            isNewEntry = true;
        }

        private void btnSaveHistory_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text File|*.txt";
                saveFileDialog.Title = "Сохранить историю";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog.FileName, listBoxHistory.Items.Cast<string>());
                    MessageBox.Show("История сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
