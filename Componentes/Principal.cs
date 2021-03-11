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
    public partial class f_main : Form {
        public int num; // declaração de variavel publica do tipo inteiro
        public f_main() {
            InitializeComponent();
            num = 0; // Atribui o valor zero a variavel num
        }

        private void btn_add_Click(object sender, EventArgs e) {
            if(tb_add_veic.Text != "") { // Verifica se o texto contido na variavel é diferente de vazio
                tb_rcb_veic.Text += tb_add_veic.Text + ", "; // Concatena strings após o operador "+"
                tb_add_veic.Clear(); // Limpa a caixa de texto.
                tb_add_veic.Focus(); // Direciona o foco do cursos para o local desejado.
            }
            else {
                MessageBox.Show("Informe um veiculo, por favor!");
                tb_add_veic.Focus(); // Direciona o foco do cursor para o local desejado.
                return;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e) {
            tb_add_veic.Clear(); // Limpa todo o conteudo do bloco de texto
            tb_rcb_veic.Clear(); // Limpa todo o conteudo do bloco de texto
            tb_add_veic.Focus(); // Direciona o foco do cursor para o local desejado
        }

        private void btn_mostar_Click(object sender, EventArgs e) {
            f_veiculos janela_veic = new f_veiculos(tb_rcb_veic.Text, this);
            // Ao utilizar o "this" no construtor, é repassado a própria classe como argumento de utilização tornando possivel que classes filho possam utilizar seus atributos
            
            janela_veic.ShowDialog(); // Chama a janela do novo formulário dando total focus a ela e evitando que o usuario consiga alternar entre janelas
            //janela_veic.Show(); // chama a janela do novo formulario, entretanto possibilita ao usuario que alterne entre as janelas.
        }

        
        private void tb_rcb_veic_TextChanged(object sender, EventArgs e) {
            tb_add_veic.Focus(); // Direciona o foco do cursor para o local desejado
        }

        private void tb_rcb_veic_MouseClick(object sender, MouseEventArgs e) {
            tb_add_veic.Focus(); // Direciona o foco do cursor para o local desejado
        }

        private void btn_val_num_Click(object sender, EventArgs e) {
            MessageBox.Show(num.ToString()); // Apresenta uma caixa de texto com mensagem personalizada
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e) {
            f_checkbox fcbox = new f_checkbox(); // instancia um objeto do tipo checkbox
            fcbox.ShowDialog(); // realizada o chamado de um formulario
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e) {
            f_checkedlistbox fckbox = new f_checkedlistbox(); // Instancia um objeto do tipo checkedlistbox
            fckbox.ShowDialog(); // realizado o chamado de um formulario
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e) {
            f_combobox fcb = new f_combobox();
            fcb.ShowDialog(); // realizado o chamado de um formulario
        }

        private void dateTimerPickToolStripMenuItem_Click(object sender, EventArgs e) {
            f_datetimer fdt = new f_datetimer();
            fdt.ShowDialog(); // realizado o chamado de um formulario
        }

        private void linkedLabelToolStripMenuItem_Click(object sender, EventArgs e) {
            f_linkedLabel flkl = new f_linkedLabel();
            flkl.ShowDialog(); // realizado o chamado de um formulario
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e) {
            f_listbox flb = new f_listbox();
            flb.ShowDialog(); // realizado o chamado de um formulario
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e) {
            f_listview flv = new f_listview();
            flv.ShowDialog(); // realizado o chamado de um formulario
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e) {
            f_maskedtextbox mask = new f_maskedtextbox();
            mask.ShowDialog(); // realizado o chamado de um formulario
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e) {
            f_monthCalendar fmc = new f_monthCalendar();
            fmc.ShowDialog(); // realizado o chamado de um formulario
        }

        private void MenuNofify_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if(e.ClickedItem.Name.ToString() == "tsm_fechar") { // A propriedade "e" do evento possui a informação do item clicado, a condição verifica se foi o "fechar"
                
                this.Close(); // Fecha o programa

            }else if (e.ClickedItem.Name.ToString() == "tsm_restaurar") { // A propriedade "e" do evento possui a informação do item clicado, a condição verifica se foi o "Restaurar"
                
                this.WindowState = FormWindowState.Normal; // Verifica o estado do windows com o FormWindowState e restaura a aplicação

            }
            else {
                MessageBox.Show("Testando componente");
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e) {
            f_numericUpDown fnumc = new f_numericUpDown();
            fnumc.ShowDialog(); // Chama o frame numericdown
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e) {
            f_pictureBox fpic = new f_pictureBox();
            fpic.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e) {
            f_progressbar fpgb = new f_progressbar();
            fpgb.ShowDialog();
        }

        private void botãoDeRadioToolStripMenuItem_Click(object sender, EventArgs e) {
            f_radiobtn rdb = new f_radiobtn();
            rdb.ShowDialog();
        }
    }
}
