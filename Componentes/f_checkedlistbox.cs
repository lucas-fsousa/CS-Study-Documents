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
    public partial class f_checkedlistbox : Form {
        public f_checkedlistbox() {
            InitializeComponent();
        }

        private void btn_checar_Click(object sender, EventArgs e) {
            string txt = ""; // Cria uma string com nome txt
            foreach(string t in clb_transportes.CheckedItems) { // Percaorre toda a lista de itens
                txt += t + ", "; // Concatena a string do foreach com uma virgula seguida de um espaço
            }
            if(txt == "") {
                MessageBox.Show("Sem seleção");
            }
            else {
                MessageBox.Show(txt); // Chama uma caixa de mensagem com as informações da variavel txt
            }
        }

        private void btn_limpa_Click(object sender, EventArgs e) {
            clb_transportes.Items.Clear(); // Limpa os itens selecionados no checkedlist box
        }

        private void btn_resetar_Click(object sender, EventArgs e) {

            List<string> tps = new List<string>();
            
            clb_transportes.Items.Clear(); // Limpa os itens selecionados no checkedlist box
            tps.Add("Carro");
            tps.Add("Avião");
            tps.Add("Navio");
            tps.Add("Ônibus");
            tps.Add("Trem");

            clb_transportes.Items.AddRange(tps.ToArray());

        }

        private void btn_add_novo_Click(object sender, EventArgs e) {
            if(tb_add_veiculo.Text == "") {
                MessageBox.Show("Favor Adicionar um veiculo válido!");
            }
            else {
                clb_transportes.Items.Add(tb_add_veiculo.Text, false);
                tb_add_veiculo.Clear();
                tb_add_veiculo.Focus();
            }
        }
    }
}
