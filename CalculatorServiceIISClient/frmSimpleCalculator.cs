using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorService;

namespace CalculatorServiceIISClient
{
    public partial class frmSimpleCalculator : Form
    {
        private SimpleCalculatorClient simpleCalc;
        public frmSimpleCalculator()
        {
            InitializeComponent();
            this.Load += frmSimpleCalculator_Load;
            this.FormClosing += frmSimpleCalculator_FormClosing;
        }

        private void frmSimpleCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            simpleCalc.Close();
        }

        private void frmSimpleCalculator_Load(object sender, EventArgs e)
        {
            simpleCalc = new SimpleCalculatorClient("WASendpoint");
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result = simpleCalc.AddNumbers(num1, num2);
                lblResult.Text = result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result = simpleCalc.SubtractNumbers(num1, num2);
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result = simpleCalc.MultplyNumbers(num1, num2);
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result = simpleCalc.DivideNumbers(num1, num2);
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
