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
    public partial class f_veiculos : Form {
        f_main fp;
        public f_veiculos(string v, f_main f) { // Cria uma string no construtor para argumentos de entrada
            // Ao criar uma váriavel do tipo "f_main" que é o nome do formulario principal, é possivel utilizar dos artributos da classe em questão 
            InitializeComponent();
            tb_listar_veiculos.Text = v; // Atribui o valor de entrada do construtor a caixa de texto

            fp = f;
            f.num = 10;
        }

        private void f_veiculos_FormClosed(object sender, FormClosedEventArgs e) {
            fp.tb_rcb_veic.Text = tb_listar_veiculos.Text;
        }
    }
}
