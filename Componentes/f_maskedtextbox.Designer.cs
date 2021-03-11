
namespace Componentes {
    partial class f_maskedtextbox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.msk_senha = new System.Windows.Forms.MaskedTextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.cb_somente_texto = new System.Windows.Forms.CheckBox();
            this.cb_mostra_senha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // msk_senha
            // 
            this.msk_senha.Location = new System.Drawing.Point(82, 35);
            this.msk_senha.Name = "msk_senha";
            this.msk_senha.PasswordChar = '*';
            this.msk_senha.Size = new System.Drawing.Size(122, 20);
            this.msk_senha.TabIndex = 0;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(11, 35);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(65, 17);
            this.lbl_senha.TabIndex = 1;
            this.lbl_senha.Text = "Senha...:";
            // 
            // msk_cep
            // 
            this.msk_cep.Location = new System.Drawing.Point(82, 61);
            this.msk_cep.Mask = "00000-000";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(122, 20);
            this.msk_cep.TabIndex = 2;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(12, 64);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(63, 17);
            this.lbl_cep.TabIndex = 3;
            this.lbl_cep.Text = "CEP......:";
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(82, 87);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(122, 20);
            this.msk_cpf.TabIndex = 4;
            this.msk_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPF......:";
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(348, 61);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(75, 23);
            this.btn_verificar.TabIndex = 6;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // cb_somente_texto
            // 
            this.cb_somente_texto.AutoSize = true;
            this.cb_somente_texto.Location = new System.Drawing.Point(222, 91);
            this.cb_somente_texto.Name = "cb_somente_texto";
            this.cb_somente_texto.Size = new System.Drawing.Size(98, 17);
            this.cb_somente_texto.TabIndex = 7;
            this.cb_somente_texto.Text = "Somente Texto";
            this.cb_somente_texto.UseVisualStyleBackColor = true;
            // 
            // cb_mostra_senha
            // 
            this.cb_mostra_senha.AutoSize = true;
            this.cb_mostra_senha.Location = new System.Drawing.Point(222, 37);
            this.cb_mostra_senha.Name = "cb_mostra_senha";
            this.cb_mostra_senha.Size = new System.Drawing.Size(95, 17);
            this.cb_mostra_senha.TabIndex = 8;
            this.cb_mostra_senha.Text = "Mostrar Senha";
            this.cb_mostra_senha.UseVisualStyleBackColor = true;
            this.cb_mostra_senha.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.cb_mostra_senha_ChangeUICues);
            // 
            // f_maskedtextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 173);
            this.Controls.Add(this.cb_mostra_senha);
            this.Controls.Add(this.cb_somente_texto);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.msk_senha);
            this.Name = "f_maskedtextbox";
            this.Text = "Masked Text Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_senha;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.CheckBox cb_somente_texto;
        private System.Windows.Forms.CheckBox cb_mostra_senha;
    }
}