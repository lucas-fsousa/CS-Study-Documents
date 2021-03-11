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
    public partial class f_datetimer : Form {
        public f_datetimer() {
            InitializeComponent();
        }

        private void btn_obter_data_Click(object sender, EventArgs e) {

            tb_data_tudo.Clear(); // limpa o texto do text box

            tb_data_comp.Text = dtp_data.Text; // Pega as informações do data picker completas
            tb_dia.Text = dtp_data.Value.Day.ToString(); // Pega o dia do data picker em inteiro e converte para string
            tb_mes.Text = dtp_data.Value.Month.ToString(); // Pega o mes do data picker em inteiro e converte para string
            tb_ano.Text = dtp_data.Value.Year.ToString(); // Pega o ano do data picker em inteiro e converte para string
            tb_data_tudo.Text += dtp_data.Value.Day.ToString() + " / " + dtp_data.Value.Month.ToString() + " / " + dtp_data.Value.Year.ToString();
        }

        private void btn_setar_data_Click(object sender, EventArgs e) {
            int dia, mes, ano;
            dia = Int32.Parse(tb_dia.Text); // A Variavel dia do tipo inteiro vai ser convertida para string e recebera o valor do textbox dia
            mes = Int32.Parse(tb_mes.Text); // A Variavel mes do tipo inteiro vai ser convertida para string e recebera o valor do textbox mes
            ano = Int32.Parse(tb_ano.Text); // A Variavel ano do tipo inteiro vai ser convertida para string e recebera o valor do textbox ano

            DateTime dt = new DateTime(ano, mes, dia); // Criação de um objeto para trabalhar com o date time
            dtp_data.Value = dt; // atribui o valor do objeto " dt " do tipo datetime ao date time picker.
        }

        private void btn_hoje_Click(object sender, EventArgs e) {
            dtp_data.Value = DateTime.Today; // Obtém a data atual e repassa ao date time picker
        }

        private void tb_data_tudo_TextChanged(object sender, EventArgs e) {
            tb_dia.Focus(); // Direciona o foco do cursor para o local desejado
        }
    }
}
