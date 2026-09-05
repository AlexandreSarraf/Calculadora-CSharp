namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private string expressao = "";

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "0";
                expressao += "0";
            }
            else
            {
                txtVisor.Text += "0";
                expressao += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "1";
                expressao += "1";
            }
            else
            {
                txtVisor.Text += "1";
                expressao += "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "2";
                expressao += "2";
            }
            else
            {
                txtVisor.Text += "2";
                expressao += "2";
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "3";
                expressao += "3";
            }
            else
            {
                txtVisor.Text += "3";
                expressao += "3";
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "4";
                expressao += "4";
            }
            else
            {
                txtVisor.Text += "4";
                expressao += "4";
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "5";
                expressao += "5";
            }
            else
            {
                txtVisor.Text += "5";
                expressao += "5";
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "6";
                expressao += "6";
            }
            else
            {
                txtVisor.Text += "6";
                expressao += "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "7";
                expressao += "7";
            }
            else
            {
                txtVisor.Text += "7";
                expressao += "7";
            }
        }
        
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "9";
                expressao += "9";
            }
            else
            {
                txtVisor.Text += "9";
                expressao += "9";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "8";
                expressao += "8";
            }
            else
            {
                txtVisor.Text += "8";
                expressao += "8";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            expressao = "";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtVisor.Text.Contains("."))
            {
                txtVisor.Text += ".";
                expressao += ".";
            }
        }

        private void btnAbreParenteses_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text += "(";
                expressao += "(";
            }
            else
            {
                txtVisor.Text += "(";
                expressao += "(";
            }
        }

        private void btnFechaParenteses_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text += ")";
                expressao += ")";
            }
            else
            {
                txtVisor.Text += ")";
                expressao += ")";
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length > 0) 
            { 
                txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1); 
            }
        }
    }
}
