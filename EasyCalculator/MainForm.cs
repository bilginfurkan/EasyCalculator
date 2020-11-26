using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCalculator
{
    public partial class MainForm : Form
    {
        public (string expresion, double value) latestCalculationValue;

        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = this.calculationInput;
        }

        private void calculationInput_TextChanged(object sender, EventArgs e)
        {
            var expression = calculationInput.Text.Replace("  ", " "); // Remove multiple spaces
            (bool isSuccessful, double result) = Calculator.Calculate(expression);
            if (isSuccessful)
            {
                SetUITexts(expression, result);
            }

            SetIncorrectExpressionText(isSuccessful);
            UpdateLatestCalculation();
        }

        public void UpdateLatestCalculation()
        {
            latestCalculation.Text = $"{latestCalculationValue.expresion} = {latestCalculationValue.value}";
        }

        public void SetIncorrectExpressionText(bool isSuccessful)
        {
            expressionIncorrect.Visible = !isSuccessful;
        }

        public void SetUITexts(string expression, double result)
        {
            latestCalculationValue.expresion = expression;
            latestCalculationValue.value = result;

            calculationResult.Text = result.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(latestCalculationValue.value.ToString());
            latestCalculation.Text = "Copied!";
        }
    }
}
