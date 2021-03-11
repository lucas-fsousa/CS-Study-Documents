using System;
using System.Windows.Forms;

namespace Componentes {
    public partial class f_maskedtextbox : Form {
        public f_maskedtextbox() {
            InitializeComponent();
        }

        private void btn_verificar_Click(object sender, EventArgs e) {
            string msg = msk_cpf.Text;
            if (!cb_somente_texto.Checked) {
                msk_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // Configura o método de captura do MaskFormat para receber somente a informação principal da mascara
            }
            else {
                msk_cpf.TextMaskFormat = MaskFormat.IncludeLiterals; // Configura o método de captura do mask format para receber a informação completa da mascara
            }
            MessageBox.Show(msg);
        }

        private void cb_mostra_senha_ChangeUICues(object sender, UICuesEventArgs e) {
            if (cb_mostra_senha.Checked) {
                //msk_senha.TextMaskFormat = MaskFormat.IncludeLiterals;
                //msk_senha.TextMaskFormat = MaskFormat.IncludePrompt;
                //msk_senha.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //msk_senha.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
        }
    }
}
