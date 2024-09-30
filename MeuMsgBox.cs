using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAS_Sorteador
{
    public partial class MeuMsgBox : Form
    {
        public MeuMsgBox(string mensagem)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centraliza o formulário
        }

        public DialogResult Resultado { get; private set; }

        public static DialogResult Mostrar(string mensagem)
        {
            var msgBox = new MeuMsgBox(mensagem);
            msgBox.resultTextBox.Text = mensagem;
            msgBox.ShowDialog();
            return msgBox.Resultado;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Copy();
            copyButton.Text = "Copiado";
        }
    }
}
