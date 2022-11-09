using System.Globalization;

namespace Calculadora02
{
    public partial class FrmCalculator : Form
    {
        decimal numberOne, numberTwo;
        string operation;


        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void bntSeven_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            txtResult.Text += ",";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            lblTextResult.Text = "Nossa Calculadora";
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "Less";
            lblTextResult.Text = txtResult.Text + " - ";

            txtResult.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "mult";
            lblTextResult.Text = txtResult.Text + " * ";

            txtResult.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "Div";
            lblTextResult.Text = txtResult.Text + " / ";

            txtResult.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberTwo = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
                lblTextResult.Text += numberTwo + "=";
                decimal result = 0;
                switch(operation)
                {
                    case "Sum":
                        result = numberOne + numberTwo;
                        break;
                    case "Sub":
                        result = numberOne - numberTwo;
                        break;
                    case "Mult":
                        result = numberOne * numberTwo;
                        break;
                    case "RestDivInt":
                        result = numberOne % numberTwo;
                        break;
                    case "Div":
                        if(numberTwo == 0)
                        {
                            txtResult.Text = "Não e possivel dividir por zero";
                            return;
                        }
                        result = numberOne / numberTwo;
                        break;
                }

                txtResult.Text = result.ToString();
                lblTextResult.Text += result.ToString();
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "RestDivInt";
            lblTextResult.Text = txtResult.Text + " % ";

            txtResult.Clear();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if(txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "Sum";
            lblTextResult.Text = txtResult.Text + " + ";

            txtResult.Clear();
        }
    }
}