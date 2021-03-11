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
    public partial class f_combobox : Form {
        public f_combobox() {
            InitializeComponent();
        }

        private void btn_mostrar_element_Click(object sender, EventArgs e) {
            MessageBox.Show(cmb_elementos.Text); // Apresenta uma popup de texto com as informações desejadas
        }

        private void btn_limpar_element_Click(object sender, EventArgs e) {
            cmb_elementos.Items.Clear(); // Limpa os elementos da lista do combobox
            tb_add_element.Clear(); // Limpa o texto da campo de texto
        }

        private void btn_reset_element_Click(object sender, EventArgs e) {
            cmb_elementos.Items.Clear();// Limpa os elementos da lista do combobox
            List<string> elemt = new List<string>(); // Criação de um elemento do tipo List
            elemt.Add("Carro"); // Adiciona um elemento no objeto do tipo list criado anteriormente
            elemt.Add("Navio"); // Adiciona um elemento no objeto do tipo list criado anteriormente
            elemt.Add("Trem"); // Adiciona um elemento no objeto do tipo list criado anteriormente
            elemt.Add("Avião"); // Adiciona um elemento no objeto do tipo list criado anteriormente
            elemt.Add("Ônibus"); // Adiciona um elemento no objeto do tipo list criado anteriormente
            cmb_elementos.Items.AddRange(elemt.ToArray()); // Adiciona todos os elementos contido no objeto criados anteriormente e acrescenta na lista do combobox
            tb_add_element.Focus(); // Direciona o foco do cursor pro local desejado
            tb_add_element.Clear(); // Limpa o texto da campo de texto
        }

        private void cmb_elementos_SelectedIndexChanged(object sender, EventArgs e) {
            tb_add_element.Text = cmb_elementos.Text; // Copia os dados do item selecionado no combobox e replica na caixa de texto de acrescent element
        }

        private void btn_adicionar_ele_Click(object sender, EventArgs e) {
            if(tb_add_element.Text == "") {
                MessageBox.Show("Preencha o campo ao Lado com um elemento!");
                tb_add_element.Focus(); // Direciona o foco do cursor para o local desejado
            }
            else {
                if (cmb_elementos.FindString(tb_add_element.Text) != -1) { // Verifica se o item existe na lista do combobox, se existir, não será adicionado
                    MessageBox.Show("O item já existe!");
                }
                else {
                    cmb_elementos.Items.Add(tb_add_element.Text); // Adiciona um novo item na lista do combobox
                }
            }
        }
    }
}
