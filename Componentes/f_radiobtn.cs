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
    public partial class f_radiobtn : Form {
        public f_radiobtn() {
            InitializeComponent();
        }

        private void btn_carro_Click(object sender, EventArgs e) {
            // A caixa de texto "carro" recebe o conteudo do botão selecionado (checked) pelo usuario no grupo de radio botton para carros
            // --- tb_carro.Text = gpb_radio_carro.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            // Forma secundária de realizar a mesma atividade

            foreach(RadioButton rb in gpb_radio_carro.Controls) { // Cria um foreach do tipo radio boton e percorre os itens
                if (rb.Checked) { // Verifica o item checado
                    tb_carro.Text = rb.Text; // Adiciona o item checado a caixa de texto carro
                }
            }

        }

        private void btn_moto_Click(object sender, EventArgs e) {
            // A Caixa de texto "Carro receberá o conteudo do botão selecionado (checked) pelo usuario no grupo de radio botton para motos
            // --- tb_moto.Text = gpb_radio_motos.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            
            // Forma secundária de realizar a mesma atividade

            foreach(RadioButton rb in gpb_radio_motos.Controls) { // Cria um foreach do tipo radio boton e percorre os itens
                if (rb.Checked) { // verifica o item checado
                    tb_moto.Text = rb.Text; // Adiciona o item checado a caixa de texto moto
                }
            }
        
        }
    }
}
