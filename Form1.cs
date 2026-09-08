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
            // ===============================
            // 1. VERIFICAR SE EXISTE UM SINAL
            // ===============================

            bool negativo = false;

            if (posicao < texto.Length &&
                texto[posicao] == '-')
            {
                negativo = true;
                posicao++;
            }
            else if (posicao < texto.Length &&
                     texto[posicao] == '+')
            {
                posicao++;
            }


            // ==============================
            // 2. VERIFICAR SE É UM PARÊNTESE
            // ==============================

            if (posicao < texto.Length &&
                texto[posicao] == '(')
            {
                posicao++;

                double resultado = LerExpressao(texto);

                if (posicao >= texto.Length ||
                    texto[posicao] != ')')
                {
                    throw new Exception(
                        "Parêntese não fechado."
                    );
                }

                posicao++;

                // Aplica o sinal ao resultado
                if (negativo)
                {
                    resultado = -resultado;
                }

                return resultado;
            }


            // ===============
            // 3. LER O NÚMERO
            // ===============

            int inicio = posicao;

            while (posicao < texto.Length &&
                   (char.IsDigit(texto[posicao]) ||
                    texto[posicao] == '.'))
            {
                posicao++;
            }


            // =====================================
            // 4. VERIFICAR SE ENCONTRAMOS UM NÚMERO
            // =====================================

            if (inicio == posicao)
            {
                throw new Exception(
                    "Número esperado."
                );
            }


            // ===================
            // 5. EXTRAIR O NÚMERO
            // ===================

            string numero = texto.Substring(
                inicio,
                posicao - inicio
            );


            // ===============================
            // 6. CONVERTER STRING PARA DOUBLE
            // ===============================

            if (!double.TryParse(
                numero,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out double valor))
            {
                throw new Exception(
                    "Número inválido."
                );
            }


            // ==================
            // 7. APLICAR O SINAL
            // ==================

            if (negativo)
            {
                valor = -valor;
            }

            return valor;
        }

        private bool NumeroAtualTemPonto()
        {
            int inicio = expressao.Length - 1;

            while (inicio >= 0)
            {
                char caractere = expressao[inicio];

                if (caractere == '+' ||
                    caractere == '*' ||
                    caractere == '/')
                {
                    break;
                }

                if (caractere == '-')
                {
                    if (inicio == 0 ||
                        expressao[inicio - 1] == '+' ||
                        expressao[inicio - 1] == '*' ||
                        expressao[inicio - 1] == '/' ||
                        expressao[inicio - 1] == '(')
                    {
                        break;
                    }
                }

                inicio--;
            }

            string numeroAtual =
                expressao.Substring(inicio + 1);

            return numeroAtual.Contains(".");
        }

        private int ContarParentesesAbertos(string texto)
        {
            int saldo = 0;

            foreach (char caractere in texto)
            {
                if (caractere == '(')
                {
                    saldo++;
                }
                else if (caractere == ')')
                {
                    saldo--;

                    if (saldo < 0)
                    {
                        throw new Exception(
                            "Existe um parêntese fechando sem abertura."
                        );
                    }
                }
            }

            return saldo;
        }

        private void CompletarParenteses()
        {
            int faltando = ContarParentesesAbertos(expressao);

            for (int i = 0; i < faltando; i++)
            {
                expressao += ")";
            }
        }

        private bool ExpressaoPodeSerCalculada()
        {
            if (string.IsNullOrEmpty(expressao))
            {
                return false;
            }

            char ultimo = expressao[expressao.Length - 1];

            // Não pode terminar com operador
            if (ultimo == '+' ||
                ultimo == '-' ||
                ultimo == '*' ||
                ultimo == '/')
            {
                return false;
            }

            // Não pode terminar abrindo parêntese
            if (ultimo == '(')
            {
                return false;
            }

            return true;
        }

        private string InserirMultiplicacoesImplicitas(string texto)
        {
            string resultado = "";

            for (int i = 0; i < texto.Length; i++)
            {
                char atual = texto[i];

                resultado += atual;

                if (i + 1 >= texto.Length)
                {
                    continue;
                }

                char proximo = texto[i + 1];

                // =====================================================
                // CASO 1
                // Número seguido de "("
                //
                // 2(3) → 2*(3)
                // 5(-2) → 5*(-2)
                // 10(4+2) → 10*(4+2)
                // =====================================================

                if (char.IsDigit(atual) && proximo == '(')
                {
                    resultado += "*";
                }

                // =====================================================
                // CASO 2
                // ")" seguido de "("
                //
                // (2)(3) → (2)*(3)
                // (-5)(8) → (-5)*(8)
                // (2+3)(4+5) → (2+3)*(4+5)
                // =====================================================

                else if (atual == ')' && proximo == '(')
                {
                    resultado += "*";
                }

                // =====================================================
                // CASO 3
                // ")" seguido de número
                //
                // (2)3 → (2)*3
                // (-5)8 → (-5)*8
                // =====================================================

                else if (atual == ')' && char.IsDigit(proximo))
                {
                    resultado += "*";
                }
            }

            return resultado;
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
            txtResultado.Text = "";
            txtVisor.Text = "0";
            expressao = "";
            resultadoExibido = false;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!NumeroAtualTemPonto())
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

            // =====================================================
            // 1. EXPRESSÃO VAZIA
            // =====================================================

            if (expressao.Length == 0)
            {
                expressao += "(";
                txtVisor.Text = expressao;
                return;
            }


            // =====================================================
            // 2. VERIFICAR O ÚLTIMO CARACTERE
            // =====================================================

            char ultimo = expressao[expressao.Length - 1];


            // =====================================================
            // 3. SE O ÚLTIMO CARACTERE FOR UM NÚMERO OU ")" INSERE "*" AUTOMATICAMENTE
            // =====================================================

            if (char.IsDigit(ultimo) ||
                ultimo == ')')
            {
                expressao += "*(";

                txtVisor.Text = expressao;

                return;
            }


            // =====================================================
            // 4. SE FOR OPERADOR OU "(" PODE ABRIR O PARÊNTESE NORMALMENTE
            // =====================================================

            if (ultimo == '+' ||
                ultimo == '-' ||
                ultimo == '*' ||
                ultimo == '/' ||
                ultimo == '(')
            {
                expressao += "(";

                txtVisor.Text = expressao;

                return;
            }
        }

        private void btnFechaParenteses_Click(object sender, EventArgs e)
        {
            if (expressao.Length == 0)
            {
                return;
            }

            char ultimo = expressao[expressao.Length - 1];

            // Não pode fechar depois de operador
            if (ultimo == '+' ||
                ultimo == '-' ||
                ultimo == '*' ||
                ultimo == '/' ||
                ultimo == '(')
            {
                return;
            }

            try
            {
                int abertos =
                    ContarParentesesAbertos(expressao);

                if (abertos > 0)
                {
                    expressao += ")";

                    txtVisor.Text = expressao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Calculadora",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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
                txtResultado.Text = "";
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
            if (resultadoExibido)
            {
                expressao = "";
                txtVisor.Text = "0";
                resultadoExibido = false;
            }

            // -----------------------------------------
            // Expressão vazia → número negativo
            // -----------------------------------------

            if (expressao.Length == 0)
            {
                expressao = "-";
                txtVisor.Text = expressao;

                return;
            }

            char ultimo =
                expressao[expressao.Length - 1];


            // -----------------------------------------
            // Depois de +, * ou /
            // -----------------------------------------

            if (ultimo == '+' ||
                ultimo == '*' ||
                ultimo == '/')
            {
                expressao += "-";

                txtVisor.Text = expressao;

                return;
            }


            // -------------
            // Depois de (
            // -------------

            if (ultimo == '(')
            {
                expressao += "-";

                txtVisor.Text = expressao;

                return;
            }


            // ----------------------
            // Caso normal: subtração
            // ----------------------

            if (ultimo != '-')
            {
                expressao += "-";

                txtVisor.Text = expressao;

                resultadoExibido = false;
            }
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

            if (!ExpressaoPodeSerCalculada())
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
                // Insere automaticamente os * necessários
                expressao = InserirMultiplicacoesImplicitas(expressao);

                // Completa parênteses abertos
                int parentesesFaltando =
                    ContarParentesesAbertos(expressao);

                if (parentesesFaltando > 0)
                {
                    CompletarParenteses();
                }

                txtVisor.Text = expressao;

                double resultado =
                    CalcularExpressao(expressao);

                txtResultado.Text =
                    resultado.ToString(
                        System.Globalization.CultureInfo.InvariantCulture
                    );

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
                txtResultado.Text = "";
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

                txtResultado.Text = "";
            }
        }
    }
}
