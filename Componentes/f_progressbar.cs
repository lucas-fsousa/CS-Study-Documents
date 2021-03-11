using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // Trabalha com o Sleep

namespace Componentes {
    public partial class f_progressbar : Form {
        public f_progressbar() {
            InitializeComponent();
        }

        private void btn_definit_Click(object sender, EventArgs e) {
            int converte = Int32.Parse(textBox1.Text); // Convete o conteudo do text box para Inteiro.
            if(converte < pgbar_01.Minimum || converte > pgbar_01.Maximum) {
                MessageBox.Show("Valor excedente ou inferior ao padrão. Tente novamente.");
            }
            else {
                pgbar_01.Value = converte;
            }
        }

        private void btn_start_Click(object sender, EventArgs e) {
            pgbar_01.Maximum = int.Parse(textBox1.Text);
            if (textBox1.Text != "") {
                if(Int32.Parse(textBox1.Text) < pgbar_01.Minimum || Int32.Parse(textBox1.Text) > pgbar_01.Maximum) {
                    MessageBox.Show("Valor inválido.");
                    return;
                }
                else {
                    for (int i = 0; i <= pgbar_01.Maximum; i++) {
                        pgbar_01.Value += 1;
                        Thread.Sleep(200); // Pausa o programa durante 200 milesegundos (sleep);
                        tb_contar.Text = i.ToString();
                    }
                }
            }
            else {
                MessageBox.Show("Defina o valor! de progressão da barra!");
                textBox1.Focus(); // Define o focus ao text box
            }
        }
    }
}
