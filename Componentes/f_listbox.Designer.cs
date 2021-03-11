
namespace Componentes {
    partial class f_listbox {
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
            this.ltb_carros = new System.Windows.Forms.ListBox();
            this.lbl_carro = new System.Windows.Forms.Label();
            this.tb_carro = new System.Windows.Forms.TextBox();
            this.btn_add_carro = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.btn_remover_carro = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltb_carros
            // 
            this.ltb_carros.FormattingEnabled = true;
            this.ltb_carros.Location = new System.Drawing.Point(12, 12);
            this.ltb_carros.Name = "ltb_carros";
            this.ltb_carros.Size = new System.Drawing.Size(120, 225);
            this.ltb_carros.TabIndex = 0;
            // 
            // lbl_carro
            // 
            this.lbl_carro.AutoSize = true;
            this.lbl_carro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carro.Location = new System.Drawing.Point(138, 12);
            this.lbl_carro.Name = "lbl_carro";
            this.lbl_carro.Size = new System.Drawing.Size(46, 18);
            this.lbl_carro.TabIndex = 1;
            this.lbl_carro.Text = "Carro";
            // 
            // tb_carro
            // 
            this.tb_carro.Location = new System.Drawing.Point(138, 33);
            this.tb_carro.Name = "tb_carro";
            this.tb_carro.Size = new System.Drawing.Size(100, 20);
            this.tb_carro.TabIndex = 2;
            // 
            // btn_add_carro
            // 
            this.btn_add_carro.Location = new System.Drawing.Point(138, 59);
            this.btn_add_carro.Name = "btn_add_carro";
            this.btn_add_carro.Size = new System.Drawing.Size(100, 20);
            this.btn_add_carro.TabIndex = 3;
            this.btn_add_carro.Text = "Adicionar";
            this.btn_add_carro.UseVisualStyleBackColor = true;
            this.btn_add_carro.Click += new System.EventHandler(this.btn_add_carro_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(138, 111);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(100, 20);
            this.btn_obter.TabIndex = 4;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // btn_remover_carro
            // 
            this.btn_remover_carro.Location = new System.Drawing.Point(138, 85);
            this.btn_remover_carro.Name = "btn_remover_carro";
            this.btn_remover_carro.Size = new System.Drawing.Size(100, 20);
            this.btn_remover_carro.TabIndex = 5;
            this.btn_remover_carro.Text = "Remover";
            this.btn_remover_carro.UseVisualStyleBackColor = true;
            this.btn_remover_carro.Click += new System.EventHandler(this.btn_remover_carro_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(138, 137);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 23);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // f_listbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 264);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_remover_carro);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_add_carro);
            this.Controls.Add(this.tb_carro);
            this.Controls.Add(this.lbl_carro);
            this.Controls.Add(this.ltb_carros);
            this.Name = "f_listbox";
            this.Text = "List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_carros;
        private System.Windows.Forms.Label lbl_carro;
        private System.Windows.Forms.TextBox tb_carro;
        private System.Windows.Forms.Button btn_add_carro;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.Button btn_remover_carro;
        private System.Windows.Forms.Button btn_limpar;
    }
}