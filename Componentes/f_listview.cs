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
    public partial class f_listview : Form {
        public f_listview() {
            InitializeComponent();
        }

        private void limpar() { // Função para limpar os campos de textBox
            tb_id.Clear(); // Limpa o text Box do ID do produto
            tb_preco.Clear(); // Limpa o text Box do preço do produto
            tb_produto.Clear(); // Limpa o text Box do nome do produto
            tb_qtd.Clear(); // Limpa o text Box da quantidade do produto
            tb_id.Focus(); // Direciona o cursor do mouse para o local desejado
        }
        
        private void btn_add_prod_Click(object sender, EventArgs e) {
            string[] produtos = new string[4]; // Define um array de string com 4 posições
            int ver_id = 0;
            int ver_preco = 0;
            int ver_qtd = 0;
            try {
                ver_id = Int32.Parse(tb_id.Text);
                ver_qtd = Int32.Parse(tb_qtd.Text);
            }
            catch {
                MessageBox.Show("Existem campos preenchidos incorretamente");
                return;
            }
            if (ver_id < 0) {
                tb_id.Focus(); // Direciona o foco do cursor para o textbox ID
            }
            else if(tb_preco.Text == "") {
                MessageBox.Show("O campo PREÇO não pode estar vazio.");
                tb_preco.Focus();// Direciona o foco do cursor para o textbox preço
            }
            else if(tb_produto.Text == "") {
                MessageBox.Show("O campo NOME DO PRODUTO não pode estar vazio");
                tb_produto.Focus();// Direciona o foco do cursor para o textbox nome do produo
            }
            else if (ver_qtd < 0) {
                tb_qtd.Focus();// Direciona o foco do cursor para o textbox de quantidade
            }
            else {
                foreach(string t in produtos) {
                    if(t == tb_id.Text) {
                        MessageBox.Show("O item já existe!");
                        return;
                    }
                    else {
                        produtos[0] = tb_id.Text; // Adiciona na posição 0 o ID do produto
                        produtos[1] = tb_produto.Text; // Adiciona na posição 1 o nome do produto
                        produtos[2] = tb_qtd.Text; // adiciona na posição 2 a quantidade do produto
                        produtos[3] = tb_preco.Text; // adiciona na posição 3 o preço do produto

                        ListViewItem l = new ListViewItem(produtos); // Cria um objeto do tipo listviewitem e adiciona os membros do Array Produtos
                        lv_produtos.Items.Add(l); // Adiciona os itens do objeto do tipo listviewitem dentro do list view "l" declarado acima
                        limpar(); // Limpa os campos de textbox
                    }
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e) {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]); // remove o item selecionado do listview
        }

        private void btn_obter_Click(object sender, EventArgs e) {
            lv_produtos.SelectedItems[0].SubItems[0].Text = tb_id.Text; // obtem o item da posição 0 selecionada e o subitem na posição 0
            lv_produtos.SelectedItems[0].SubItems[1].Text = tb_produto.Text; // obtem o item da posição 0 selecionada e o subitem na posição 1
            lv_produtos.SelectedItems[0].SubItems[2].Text = tb_qtd.Text; // obtem o item da posição 0 selecionada e o subitem na posição 2
            lv_produtos.SelectedItems[0].SubItems[3].Text = tb_preco.Text; // obtem o item da posição 0 selecionada e o subitem na posição 3
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e) {
            if(lv_produtos.SelectedItems.Count > 0) { // Verifica se a contagem dos itens selecionados é maior que 0
                tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text; // obtem o item da posição 0 selecionada e o subitem na posição 0
                tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text; // obtem o item da posição 0 selecionada e o subitem na posição 1
                tb_qtd.Text = lv_produtos.SelectedItems[0].SubItems[2].Text; // obtem o item da posição 0 selecionada e o subitem na posição 2
                tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text; // obtem o item da posição 0 selecionada e o subitem na posição 3
            } 
        }
    }
}
