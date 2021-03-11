
namespace Componentes {
    partial class f_checkedlistbox {
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_checar = new System.Windows.Forms.Button();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_add_novo = new System.Windows.Forms.Button();
            this.lbl_add_veiculo = new System.Windows.Forms.Label();
            this.tb_add_veiculo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "ônibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(12, 12);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(147, 184);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_checar
            // 
            this.btn_checar.Location = new System.Drawing.Point(170, 67);
            this.btn_checar.Name = "btn_checar";
            this.btn_checar.Size = new System.Drawing.Size(268, 24);
            this.btn_checar.TabIndex = 1;
            this.btn_checar.Text = "Check";
            this.btn_checar.UseVisualStyleBackColor = true;
            this.btn_checar.Click += new System.EventHandler(this.btn_checar_Click);
            // 
            // btn_limpa
            // 
            this.btn_limpa.Location = new System.Drawing.Point(170, 136);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(266, 27);
            this.btn_limpa.TabIndex = 2;
            this.btn_limpa.Text = "Limpar Lista";
            this.btn_limpa.UseVisualStyleBackColor = true;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpa_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(170, 169);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(266, 27);
            this.btn_resetar.TabIndex = 3;
            this.btn_resetar.Text = "Resetar Lista";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_add_novo
            // 
            this.btn_add_novo.Location = new System.Drawing.Point(168, 38);
            this.btn_add_novo.Name = "btn_add_novo";
            this.btn_add_novo.Size = new System.Drawing.Size(270, 23);
            this.btn_add_novo.TabIndex = 4;
            this.btn_add_novo.Text = "Adicionar Novo";
            this.btn_add_novo.UseVisualStyleBackColor = true;
            this.btn_add_novo.Click += new System.EventHandler(this.btn_add_novo_Click);
            // 
            // lbl_add_veiculo
            // 
            this.lbl_add_veiculo.AutoSize = true;
            this.lbl_add_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_veiculo.Location = new System.Drawing.Point(165, 12);
            this.lbl_add_veiculo.Name = "lbl_add_veiculo";
            this.lbl_add_veiculo.Size = new System.Drawing.Size(145, 17);
            this.lbl_add_veiculo.TabIndex = 5;
            this.lbl_add_veiculo.Text = "Adicionar Transporte:";
            // 
            // tb_add_veiculo
            // 
            this.tb_add_veiculo.Location = new System.Drawing.Point(314, 12);
            this.tb_add_veiculo.Name = "tb_add_veiculo";
            this.tb_add_veiculo.Size = new System.Drawing.Size(122, 20);
            this.tb_add_veiculo.TabIndex = 6;
            // 
            // f_checkedlistbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 217);
            this.Controls.Add(this.tb_add_veiculo);
            this.Controls.Add(this.lbl_add_veiculo);
            this.Controls.Add(this.btn_add_novo);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.btn_limpa);
            this.Controls.Add(this.btn_checar);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "f_checkedlistbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedlistBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_checar;
        private System.Windows.Forms.Button btn_limpa;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_add_novo;
        private System.Windows.Forms.Label lbl_add_veiculo;
        private System.Windows.Forms.TextBox tb_add_veiculo;
    }
}