using System.Windows.Forms;
using System.Threading;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;

namespace LAS_Sorteador
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centraliza o formulário
        }

        List<int> numerosSorteados = new List<int>();

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void drawButton_Click(object sender, EventArgs e)
        {
            if (initialNumberNumeric.Value < 0 || initialNumberNumeric.Value < 0)
            {
                MessageBox.Show("Insira um número válido para sorteio.");
                return;
            }

            int inicialNumber = Convert.ToInt32(initialNumberNumeric.Value);
            int finalNumber = Convert.ToInt32(finalNumberNumeric.Value);

            HashSet<int> sorteados = new HashSet<int>();
            Random random = new Random();

            if (numberOfDrawsNumeric.Value == 1)
            {
                if (repeatNumbersButton.Checked)
                {
                    if (numerosSorteados.Count > 0)
                    {
                        numerosSorteados.Clear();
                        numerosSorteadosArmazenadosTextBox.Text = "";
                        numerosSorteadosArmazenadosTextBox.Visible = false;
                    }

                    resetCounterButton.Enabled = false;
                    drawButton.Enabled = false;
                    numberOfDrawsNumeric.Enabled = false;
                    initialNumberNumeric.Enabled = false;
                    finalNumberNumeric.Enabled = false;
                    repeatNumbersButton.Enabled = false;

                    drawNumber.Focus();

                    for (int i = 0; i < 30; i++)
                    {
                        int numero = random.Next(inicialNumber, finalNumber + 1);
                        drawNumber.Text = numero.ToString();

                        if (i < 15)
                            await Task.Delay(20);
                        else if (i < 20)
                            await Task.Delay(50);
                        else if (i < 25)
                            await Task.Delay(100);
                        else
                            await Task.Delay(200);
                    }

                    resetCounterButton.Enabled = true;
                    drawButton.Enabled = true;
                    numberOfDrawsNumeric.Enabled = true;
                    initialNumberNumeric.Enabled = true;
                    finalNumberNumeric.Enabled = true;
                    repeatNumbersButton.Enabled = true;
                }
                else
                {
                    numerosSorteadosArmazenadosTextBox.Visible = true;

                    int numero = 0;

                    resetCounterButton.Enabled = false;
                    drawButton.Enabled = false;
                    numberOfDrawsNumeric.Enabled = false;
                    initialNumberNumeric.Enabled = false;
                    finalNumberNumeric.Enabled = false;
                    repeatNumbersButton.Enabled = false;

                    drawNumber.Focus();

                    if (numerosSorteados.Count == (finalNumberNumeric.Value - initialNumberNumeric.Value) + 1)
                    {
                        MessageBox.Show("O número máximo de sorteios para os números selecionados foi realizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        resetCounterButton.Enabled = true;
                        return;
                    }

                    for (int i = 0; i < 30; i++)
                    {
                        numero = random.Next(inicialNumber, finalNumber + 1);
                        drawNumber.Text = numero.ToString();

                        if (i < 15)
                            await Task.Delay(20);
                        else if (i < 20)
                            await Task.Delay(50);
                        else if (i < 25)
                            await Task.Delay(100);
                        else
                            await Task.Delay(200);
                    }

                    while (numerosSorteados.Contains(numero))
                    {
                        await Task.Delay(300);
                        numero = random.Next(inicialNumber, finalNumber + 1);
                        drawNumber.Text = numero.ToString();
                    }

                    numerosSorteados.Add(numero);

                    numerosSorteadosArmazenadosTextBox.Text += $"{numero} ";

                    resetCounterButton.Enabled = true;
                    drawButton.Enabled = true;
                }
            }
            else
            {
                if (repeatNumbersButton.Checked)
                {
                    resetCounterButton.Enabled = false;
                    drawButton.Enabled = false;
                    numberOfDrawsNumeric.Enabled = false;
                    initialNumberNumeric.Enabled = false;
                    finalNumberNumeric.Enabled = false;
                    repeatNumbersButton.Enabled = false;

                    drawNumber.Focus();

                    for (int i = 5; i > 0; i--)
                    {
                        drawNumber.Text = i.ToString();
                        await Task.Delay(1000);
                    }

                    string sorteio = "";

                    for (int i = 0; i < numberOfDrawsNumeric.Value; i++)
                    {
                        int numeroSorteado = random.Next(inicialNumber, finalNumber);
                        sorteio += numeroSorteado.ToString() + " ";
                    }

                    string modifiedString = sorteio.Remove(sorteio.Length - 1);

                    MeuMsgBox.Mostrar(modifiedString);

                    drawNumber.Text = "0";

                    resetCounterButton.Enabled = true;
                    drawButton.Enabled = true;
                    numberOfDrawsNumeric.Enabled = true;
                    initialNumberNumeric.Enabled = true;
                    finalNumberNumeric.Enabled = true;
                    repeatNumbersButton.Enabled = true;
                }
                else
                {
                    resetCounterButton.Enabled = false;
                    drawButton.Enabled = false;
                    numberOfDrawsNumeric.Enabled = false;
                    initialNumberNumeric.Enabled = false;
                    finalNumberNumeric.Enabled = false;
                    repeatNumbersButton.Enabled = false;

                    drawNumber.Focus();

                    for (int i = 5; i > 0; i--)
                    {
                        drawNumber.Text = i.ToString();
                        await Task.Delay(1000);
                    }

                    while (sorteados.Count < numberOfDrawsNumeric.Value)
                    {
                        int numeroSorteado = random.Next(inicialNumber, finalNumber + 1);

                        sorteados.Add(numeroSorteado);
                    }

                    string resultadoSorteio = "";

                    foreach (int i in sorteados)
                    {
                        resultadoSorteio += $"{i} ";
                    }

                    string modifiedString = resultadoSorteio.Remove(resultadoSorteio.Length - 1);

                    MeuMsgBox.Mostrar(modifiedString);

                    drawNumber.Text = "0";

                    resetCounterButton.Enabled = true;
                    drawButton.Enabled = true;
                    numberOfDrawsNumeric.Enabled = true;
                    initialNumberNumeric.Enabled = true;
                    finalNumberNumeric.Enabled = true;
                    repeatNumbersButton.Enabled = true;
                }
            }
        }

        private void initialNumberNumeric_Leave(object sender, EventArgs e)
        {
            if (initialNumberNumeric.Value >= finalNumberNumeric.Value)
            {
                initialNumberNumeric.Value = finalNumberNumeric.Value - 1;
            }

            initialNumberNumeric.Text = initialNumberNumeric.Value.ToString();

            if (numberOfDrawsNumeric.Value > (finalNumberNumeric.Value - initialNumberNumeric.Value))
            {
                numberOfDrawsNumeric.Value = finalNumberNumeric.Value - initialNumberNumeric.Value;
            }

            numberOfDrawsNumeric.Text = numberOfDrawsNumeric.Value.ToString();
        }

        private void finalNumberNumeric_Leave(object sender, EventArgs e)
        {
            if (finalNumberNumeric.Value <= initialNumberNumeric.Value)
            {
                finalNumberNumeric.Value = initialNumberNumeric.Value + 1;
            }

            finalNumberNumeric.Text = finalNumberNumeric.Value.ToString();

            if (numberOfDrawsNumeric.Value > (finalNumberNumeric.Value - initialNumberNumeric.Value))
            {
                numberOfDrawsNumeric.Value = finalNumberNumeric.Value - initialNumberNumeric.Value;
            }

            numberOfDrawsNumeric.Text = numberOfDrawsNumeric.Value.ToString();
        }

        private void numberOfDrawsNumeric_Leave(object sender, EventArgs e)
        {
            if (numberOfDrawsNumeric.Value > (finalNumberNumeric.Value - initialNumberNumeric.Value))
            {
                numberOfDrawsNumeric.Value = finalNumberNumeric.Value - initialNumberNumeric.Value;
            }

            if (numberOfDrawsNumeric.Value == 1)
            {
                labelNumeros.Text = "número";
            }
            else
            {
                labelNumeros.Text = "números";
            }

            numberOfDrawsNumeric.Text = numberOfDrawsNumeric.Value.ToString();
        }

        private void resetCounterButton_Click(object sender, EventArgs e)
        {
            var escolha = MessageBox.Show("Você tem certeza que quer reiniciar o sorteio?", "Reiniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (escolha == DialogResult.Yes)
            {
                drawNumber.Text = "0";
                numerosSorteados.Clear();
                numerosSorteadosArmazenadosTextBox.Visible = false;
                numerosSorteadosArmazenadosTextBox.Text = "";

                resetCounterButton.Enabled = true;
                drawButton.Enabled = true;
                numberOfDrawsNumeric.Enabled = true;
                initialNumberNumeric.Enabled = true;
                finalNumberNumeric.Enabled = true;
                repeatNumbersButton.Enabled = true;
            }
        }
    }
}
