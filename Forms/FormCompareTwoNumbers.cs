using System;
using System.Windows.Forms;

namespace NumberOperations.Forms
{
    public partial class FormCompareTwoNumbers : Form
    {
        public FormCompareTwoNumbers()
        {
            InitializeComponent();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            try
            {
                NumberInSystem firstNumber = new NumberInSystem(firstNum.Text, Convert.ToInt32(comboBoxFirstNum.SelectedItem));
                NumberInSystem secondNumber = new NumberInSystem(secondNum.Text, Convert.ToInt32(comboBoxSecondNum.SelectedItem));
                String result;

                if (firstNumber > secondNumber)
                {
                    result = "перше число більше, ніж друге";
                } else if (firstNumber < secondNumber)
                {
                    result = "перше число менше, ніж друге";
                } else
                {
                    result = "числа рівні";
                }

                labelResult.Text = "Результат: " + result;
                labelError.Text = "";
            }
            catch (ArgumentException exc)
            {
                labelError.Text = "Помилка: " + exc.Message;
                labelResult.Text = "";

            }
        }
    }
}
