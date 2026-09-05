namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtVisor = new TextBox();
            txtResultado = new TextBox();
            btn0 = new Button();
            btnPonto = new Button();
            btnIgual = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMultiplicacao = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDivisao = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnApagar = new Button();
            btnC = new Button();
            btnFechaParenteses = new Button();
            btnAbreParenteses = new Button();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.Font = new Font("Segoe UI", 15F);
            txtVisor.Location = new Point(12, 69);
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(298, 41);
            txtVisor.TabIndex = 0;
            txtVisor.Text = "0";
            txtVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 15F);
            txtResultado.Location = new Point(12, 22);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(298, 41);
            txtResultado.TabIndex = 1;
            // 
            // btn0
            // 
            btn0.AutoSize = true;
            btn0.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn0.Location = new Point(11, 420);
            btn0.Name = "btn0";
            btn0.Size = new Size(70, 64);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnPonto
            // 
            btnPonto.AutoSize = true;
            btnPonto.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnPonto.Location = new Point(87, 420);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(70, 64);
            btnPonto.TabIndex = 3;
            btnPonto.Text = ".";
            btnPonto.TextAlign = ContentAlignment.TopCenter;
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnIgual
            // 
            btnIgual.AutoSize = true;
            btnIgual.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnIgual.Location = new Point(163, 420);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(70, 64);
            btnIgual.TabIndex = 4;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnSoma
            // 
            btnSoma.AutoSize = true;
            btnSoma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnSoma.Location = new Point(239, 420);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(70, 64);
            btnSoma.TabIndex = 5;
            btnSoma.Tag = "+";
            btnSoma.Text = "+";
            btnSoma.TextAlign = ContentAlignment.TopCenter;
            btnSoma.UseVisualStyleBackColor = true;
            // 
            // btnSubtracao
            // 
            btnSubtracao.AutoSize = true;
            btnSubtracao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnSubtracao.Location = new Point(239, 350);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(70, 64);
            btnSubtracao.TabIndex = 9;
            btnSubtracao.Tag = "-";
            btnSubtracao.Text = "-";
            btnSubtracao.TextAlign = ContentAlignment.TopCenter;
            btnSubtracao.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.AutoSize = true;
            btn3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn3.Location = new Point(163, 350);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 64);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.AutoSize = true;
            btn2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn2.Location = new Point(87, 350);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 64);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.AutoSize = true;
            btn1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn1.Location = new Point(11, 350);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 64);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.AutoSize = true;
            btnMultiplicacao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnMultiplicacao.Location = new Point(239, 280);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(70, 64);
            btnMultiplicacao.TabIndex = 13;
            btnMultiplicacao.Tag = "*";
            btnMultiplicacao.Text = "*";
            btnMultiplicacao.TextAlign = ContentAlignment.BottomCenter;
            btnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.AutoSize = true;
            btn6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn6.Location = new Point(163, 280);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 64);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.AutoSize = true;
            btn5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn5.Location = new Point(87, 280);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 64);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.AutoSize = true;
            btn4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn4.Location = new Point(11, 280);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 64);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.AutoSize = true;
            btnDivisao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnDivisao.Location = new Point(239, 210);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(70, 64);
            btnDivisao.TabIndex = 17;
            btnDivisao.Tag = "/";
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.AutoSize = true;
            btn9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn9.Location = new Point(163, 210);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 64);
            btn9.TabIndex = 16;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.AutoSize = true;
            btn8.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn8.Location = new Point(87, 210);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 64);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.AutoSize = true;
            btn7.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn7.Location = new Point(11, 210);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 64);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnApagar
            // 
            btnApagar.AutoSize = true;
            btnApagar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnApagar.Location = new Point(239, 140);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(70, 64);
            btnApagar.TabIndex = 21;
            btnApagar.Text = "<";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnC
            // 
            btnC.AutoSize = true;
            btnC.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnC.Location = new Point(163, 140);
            btnC.Name = "btnC";
            btnC.Size = new Size(70, 64);
            btnC.TabIndex = 20;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnFechaParenteses
            // 
            btnFechaParenteses.AutoSize = true;
            btnFechaParenteses.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnFechaParenteses.Location = new Point(87, 140);
            btnFechaParenteses.Name = "btnFechaParenteses";
            btnFechaParenteses.Size = new Size(70, 64);
            btnFechaParenteses.TabIndex = 19;
            btnFechaParenteses.Text = ")";
            btnFechaParenteses.TextAlign = ContentAlignment.TopCenter;
            btnFechaParenteses.UseVisualStyleBackColor = true;
            btnFechaParenteses.Click += btnFechaParenteses_Click;
            // 
            // btnAbreParenteses
            // 
            btnAbreParenteses.AutoSize = true;
            btnAbreParenteses.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnAbreParenteses.Location = new Point(11, 140);
            btnAbreParenteses.Name = "btnAbreParenteses";
            btnAbreParenteses.Size = new Size(70, 64);
            btnAbreParenteses.TabIndex = 18;
            btnAbreParenteses.Text = "(";
            btnAbreParenteses.TextAlign = ContentAlignment.TopCenter;
            btnAbreParenteses.UseVisualStyleBackColor = true;
            btnAbreParenteses.Click += btnAbreParenteses_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(327, 492);
            Controls.Add(btnApagar);
            Controls.Add(btnC);
            Controls.Add(btnFechaParenteses);
            Controls.Add(btnAbreParenteses);
            Controls.Add(btnDivisao);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnSubtracao);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnSoma);
            Controls.Add(btnIgual);
            Controls.Add(btnPonto);
            Controls.Add(btn0);
            Controls.Add(txtResultado);
            Controls.Add(txtVisor);
            MaximizeBox = false;
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisor;
        private TextBox txtResultado;
        private Button btn0;
        private Button btnPonto;
        private Button btnIgual;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMultiplicacao;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnDivisao;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnApagar;
        private Button btnC;
        private Button btnFechaParenteses;
        private Button btnAbreParenteses;
    }
}
