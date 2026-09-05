namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private string expressao = "";
        private int posicao;

        private bool UltimoCaractereEhOperador()
        {
            if (expressao.Length == 0)
            {
                return false;
            }

            char ultimo = expressao[expressao.Length - 1];

            return ultimo == '+' ||
                   ultimo == '-' ||
                   ultimo == '*' ||
                   ultimo == '/';
        }

        private double CalcularExpressao(string texto)
        {
            posicao = 0;

            double resultado = LerExpressao(texto);

            if (posicao < texto.Length)
            {
                throw new Exception("Expressão inválida.");
            }

            return resultado;
        }

        private double LerExpressao(string texto)
        {
            double resultado = LerTermo(texto);

            while (posicao < texto.Length)
            {
                char operador = texto[posicao];

                if (operador == '+')
                {
                    posicao++;
                    resultado += LerTermo(texto);
                }
                else if (operador == '-')
                {
                    posicao++;
                    resultado -= LerTermo(texto);
                }
                else
                {
                    break;
                }
            }

            return resultado;
        }

        private double LerTermo(string texto)
        {
            double resultado = LerFator(texto);

            while (posicao < texto.Length)
            {
                char operador = texto[posicao];

                if (operador == '*')
                {
                    posicao++;
                    resultado *= LerFator(texto);
                }
                else if (operador == '/')
                {
                    posicao++;

                    double divisor = LerFator(texto);

                    if (divisor == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    resultado /= divisor;
                }
                else
                {
                    break;
                }
            }

            return resultado;
        }

        private double LerFator(string texto)
        {
            if (posicao < texto.Length &&
                texto[posicao] == '(')
            {
                posicao++;

                double resultado = LerExpressao(texto);

                if (posicao >= texto.Length ||
                    texto[posicao] != ')')
                {
                    throw new Exception("Parêntese não fechado.");
                }

                posicao++;

                return resultado;
            }

            int inicio = posicao;

            while (posicao < texto.Length &&
                   (char.IsDigit(texto[posicao]) ||
                    texto[posicao] == '.'))
            {
                posicao++;
            }

            if (inicio == posicao)
            {
                throw new Exception("Número esperado.");
            }

            string numero = texto.Substring(
                inicio,
                posicao - inicio);

            return double.Parse(
                numero,
                System.Globalization.CultureInfo.InvariantCulture);
        }

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
            string[] partes = expressao.Split('+', '-', '*', '/');

            string ultimoNumero = partes[partes.Length - 1];

            if (!ultimoNumero.Contains("."))
            {
                expressao += ".";
                txtVisor.Text = expressao;
            }
        }

        private void btnAbreParenteses_Click(object sender, EventArgs e)
        {
            expressao += "(";
            txtVisor.Text = expressao;
        }

        private void btnFechaParenteses_Click(object sender, EventArgs e)
        {
            expressao += ")";
            txtVisor.Text = expressao;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (expressao.Length > 0)
            {
                expressao = expressao.Substring(0, expressao.Length - 1);
            }

            if (expressao.Length == 0)
            {
                txtVisor.Text = "0";
            }

            else
            {
                txtVisor.Text = expressao;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (expressao.Length > 0 && !UltimoCaractereEhOperador())
            {
                expressao += "+";
                txtVisor.Text = expressao;
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (expressao.Length > 0 && !UltimoCaractereEhOperador())
            {
                expressao += "-";
                txtVisor.Text = expressao;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (expressao.Length > 0 && !UltimoCaractereEhOperador())
            {
                expressao += "*";
                txtVisor.Text = expressao;
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (expressao.Length > 0 && !UltimoCaractereEhOperador())
            {
                expressao += "/";
                txtVisor.Text = expressao;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = CalcularExpressao(expressao);

                expressao = resultado.ToString();

                txtVisor.Text = expressao;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero.");

                txtVisor.Text = "0";
                expressao = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Expressão inválida: " + ex.Message);

                txtVisor.Text = "0";
                expressao = "";
            }
        }
    }
}
