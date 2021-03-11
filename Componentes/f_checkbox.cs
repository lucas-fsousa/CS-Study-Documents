using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes {
    public partial class f_checkbox : Form {
        List<CheckBox> transp = new List<CheckBox>(); // Cria uma lista do tipo Checkbox com nome de transp
        public f_checkbox() {
            InitializeComponent(); // inicializa os componentes do formulario
            transp.Add(cb_carro); // Adiciona o item do checkbox do carro na variavel transp com a função add
            transp.Add(cb_aviao); // Adiciona o item do checkbox do aviao na variavel transp com a função add
            transp.Add(cb_navio); // Adiciona o item do checkbox do navio na variavel transp com a função add
            transp.Add(cb_onibus); // Adiciona o item do checkbox do onibus na variavel transp com a função add
        }
            
        private void btn_selecionados_Click(object sender, EventArgs e) {
            string txt = ""; // inciializa uma string vazia
            int i = 0; // inicializa uma variavel do tipo inteiro com 0
            foreach(CheckBox t in transp) { // Percorre os itens da lista de checkbox na variavel transp
                if (t.Checked) { // Verifica se o item atual está marcado na caixa de seleção
                    txt += t.Text + ", "; // se a marcação for verdadeira, o texto da caixa de seleção será concatenado na variavel T do foreach
                    i++; // Incremento da vaiavel do tipo inteiro
                }
            }
            if(i <= 0) { // Verifica se a variavel do tipo inteiro é menor ou igual a zero para apresentar as mensagens de texto
                MessageBox.Show("0 itens selecionados!"); // Mensagem de texto
            }else {
                MessageBox.Show(txt); // Mensagem de texto informando os itens contidos na variavel TXT
            }
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e) {
            if (cb_patinete.Checked){
                MessageBox.Show("Patinete Marcada");
            }
        }

        private void btn_nova_caixa_Click(object sender, EventArgs e) {
            f_filho ffilho = new f_filho();
            ffilho.ShowDialog();
        }
    }
}
