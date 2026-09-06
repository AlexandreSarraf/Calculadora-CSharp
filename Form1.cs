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
        private bool resultadoExibido = false;

        private void AdicionarNumero(string numero)
        {
            if (resultadoExibido)
            {
                expressao = "";
                txtVisor.Text = "0";
                resultadoExibido = false;
            }

            if (txtVisor.Text == "0" && expressao == "")
            {
                txtVisor.Text = numero;
                expressao = numero;
            }
            else
            {
                txtVisor.Text += numero;
                expressao += numero;
            }
        }

        private void AdicionarOperador(string operador)
        {
            if (expressao.Length == 0)
            {
                return;
            }

            char ultimo = expressao[expressao.Length - 1];

            if (ultimo == '+' ||
                ultimo == '-' ||
                ultimo == '*' ||
                ultimo == '/')
            {
                return;
            }

            if (ultimo == '(')
            {
                return;
            }

            expressao += operador;

            txtVisor.Text = expressao;

            resultadoExibido = false;
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

            if (!double.TryParse(
                 numero,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out double valor))
            {
                throw new Exception("Número inválido.");
            }

            return valor;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            expressao = "";
            resultadoExibido = false;
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
            if (resultadoExibido)
            {
                expressao = "";
                txtVisor.Text = "0";
                resultadoExibido = false;
            }

            if (expressao.Length == 0)
            {
                expressao += "(";
            }
            else
            {
                char ultimo = expressao[expressao.Length - 1];

                if (ultimo == '+' ||
                    ultimo == '-' ||
                    ultimo == '*' ||
                    ultimo == '/' ||
                    ultimo == '(')
                {
                    expressao += "(";
                }
            }

            txtVisor.Text = expressao;
        }

        private void btnFechaParenteses_Click(object sender, EventArgs e)
        {
            if (expressao.Length == 0)
            {
                return;
            }

            char ultimo = expressao[expressao.Length - 1];

            if (ultimo == '+' ||
                ultimo == '-' ||
                ultimo == '*' ||
                ultimo == '/' ||
                ultimo == '(')
            {
                return;
            }

            int abertos = 0;
            int fechados = 0;

            foreach (char caractere in expressao)
            {
                if (caractere == '(')
                {
                    abertos++;
                }
                else if (caractere == ')')
                {
                    fechados++;
                }
            }

            if (abertos > fechados)
            {
                expressao += ")";
                txtVisor.Text = expressao;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (expressao.Length > 0)
            {
                expressao = expressao.Substring(0, expressao.Length - 1);
            }

            resultadoExibido = false;

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
            AdicionarOperador("+");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            AdicionarOperador("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            AdicionarOperador("*");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            AdicionarOperador("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (expressao.Length == 0)
            {
                return;
            }

            char ultimo = expressao[expressao.Length - 1];

            if (ultimo == '+' ||
                ultimo == '-' ||
                ultimo == '*' ||
                ultimo == '/' ||
                ultimo == '(')
            {
                MessageBox.Show(
                    "A expressão está incompleta.",
                    "Calculadora",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                double resultado =
                    CalcularExpressao(expressao);

                expressao = resultado.ToString(
                    System.Globalization.CultureInfo.InvariantCulture
                );

                txtVisor.Text = expressao;

                resultadoExibido = true;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(
                    "Não é possível dividir por zero.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtVisor.Text = "0";
                expressao = "";
                resultadoExibido = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Expressão inválida.\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
