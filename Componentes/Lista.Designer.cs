
namespace Componentes {
    partial class f_veiculos {
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
            this.tb_listar_veiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_listar_veiculos
            // 
            this.tb_listar_veiculos.Location = new System.Drawing.Point(12, 12);
            this.tb_listar_veiculos.Multiline = true;
            this.tb_listar_veiculos.Name = "tb_listar_veiculos";
            this.tb_listar_veiculos.Size = new System.Drawing.Size(335, 374);
            this.tb_listar_veiculos.TabIndex = 0;
            // 
            // f_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 398);
            this.Controls.Add(this.tb_listar_veiculos);
            this.Name = "f_veiculos";
            this.Text = "Lista de Veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f_veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_listar_veiculos;
    }
}