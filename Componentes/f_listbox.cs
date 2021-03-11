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
    public partial class f_listbox : Form {
        List<string> car = new List<string>(); // Cria um objeto do tipo lista "car"
        public f_listbox() {
            InitializeComponent();

            car.Add("Corvete"); // Adiciona um novo item na lista Car
            car.Add("Chevette"); // Adiciona um novo item na lista Car
            car.Add("Dodge Charger"); // Adiciona um novo item na lista Car

            ltb_carros.DataSource = car; // Adiciona os itens da lista no listbox
        }
        private void att_list(ListBox lb, List<string>lis) { // Reseta a lista para o padrão e atualiza com novos dados
            lb.DataSource = null; // Reseta o list Box
            lb.DataSource = lis; // Atualiza o list Box
        }

        private void btn_add_carro_Click(object sender, EventArgs e) {
            
            if(tb_carro.Text == "") {
                MessageBox.Show("Informe o Carro a ser incluido na lista"); // Apresenta PopUp com mensagem personalizada
                tb_carro.Focus(); // Direciona o foco do cursor para o local desejado
            }
            else {
                car.Add(tb_carro.Text); // Adiciona o item do text box no list box
                tb_carro.Clear(); // Limpa o text box
                tb_carro.Focus(); // Direciona o foco do cursor para o text box
                //ltb_carros.DataSource = null; // Reseta a lista para mostar os itens existentes
                //ltb_carros.DataSource = car; // Atualiza a lista para mostrar os itens existentes
                att_list(ltb_carros, car); // Reseta a lista para o padrão e atualiza com novos dados
            }
        }

        private void btn_remover_carro_Click(object sender, EventArgs e) {
            //Bloco para tratamento de erro Try-Catch
            try {
                car.RemoveAt(ltb_carros.SelectedIndex); // Remove da lista o item selecionado.
                                                        //ltb_carros.DataSource = null; // Reseta a lista para mostar os itens existentes
                                                        //ltb_carros.DataSource = car; // Atualiza a lista para mostrar os itens existentes
                att_list(ltb_carros, car); // Reseta a lista para o padrão e atualiza com novos dados
            }
            catch {
                MessageBox.Show("Selecione o item a ser removido!");
            }
        }

        private void btn_obter_Click(object sender, EventArgs e) {

            tb_carro.Text = car[ltb_carros.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            car.Clear();
            att_list(ltb_carros, car); // Reseta a lista para o padrão e atualiza com novos dados

        }
    }
}
