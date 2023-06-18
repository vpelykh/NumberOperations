using System;
using System.Windows.Forms;

namespace NumberOperations.Forms
{
    public partial class FormAriphmeticOperations : Form
    {
        public FormAriphmeticOperations()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            calculate('+');
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            calculate('-');
        }

        private void calculate(char operation)
        {
            try
            {
                NumberInSystem firstNumber = new NumberInSystem(firstNum.Text, Convert.ToInt32(comboBoxFirstNum.SelectedItem));
                NumberInSystem secondNumber = new NumberInSystem(secondNum.Text, Convert.ToInt32(comboBoxSecondNum.SelectedItem));
                NumberInSystem result = null;

                switch (operation)
                {
                    case '+':
                        result = firstNumber + secondNumber;
                        break;
                    case '-':
                        result = firstNumber - secondNumber;
                        break;
                    case '*':
                        result = firstNumber * secondNumber;
                        break;
                    case '/':
                        result = firstNumber / secondNumber;
                        break;
                }

                labelResult.Text = "Результат \n в системі числення " + comboBoxFirstNum.SelectedItem.ToString();
                labelError.Text = "";
                resultNum.Text = result.getNum();
            }
            catch (ArgumentException exc)
            {
                labelError.Text = "Помилка: " + exc.Message;
                labelResult.Text = "";

            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            calculate('*');
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            calculate('/');
        }
    }
}