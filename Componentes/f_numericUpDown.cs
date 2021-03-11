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
    public partial class f_numericUpDown : Form {
        public f_numericUpDown() {
            InitializeComponent();
        }

        private void btn_def_valor_Click(object sender, EventArgs e) {

            /*  CONVERTER STRING PARA INT
            int converter;
            converter = Int32.Parse(tb_valor.Text);
            nud_valor.Value = converter;
            */
            try{
                nud_valor.Value = Decimal.Parse(tb_valor.Text); // Converte uma string para inteiro e adiciona o valor no numeric up down
                tb_valor.Clear(); // Limpa a caixa de texto
                tb_valor.Focus(); // Direciona o cursor para a caixa de texto.
            }
            catch {
                MessageBox.Show("O valor inserido está fora dos limites impostos. Tente novamene!");
                tb_valor.Clear(); // Limpa a caixa de texto
                tb_valor.Focus(); // Direciona o cursor para a caixa de texto.
            }
           
        }
    }
}
