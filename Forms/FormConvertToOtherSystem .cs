using System;
using System.Windows.Forms;

namespace NumberOperations.Forms
{
    public partial class FormConvertToOtherSystem : Form
    {
        public FormConvertToOtherSystem()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                NumberInSystem currentNum = new NumberInSystem(num.Text, Convert.ToInt32(comboBoxFromSystem.SelectedItem));
                string result = NumberInSystem.toBase(currentNum.getNum(), currentNum.getNumberBase(), Convert.ToInt32(comboBoxToSystem.SelectedItem));

                labelResult.Text = "Результат \n в системі числення " + comboBoxToSystem.SelectedItem.ToString();
                labelError.Text = "";
                resultNum.Text = result;
            }
            catch (ArgumentException exc)
            {
                labelError.Text = "Помилка: " + exc.Message;
                labelResult.Text = "";
            }
        }
    }
}
