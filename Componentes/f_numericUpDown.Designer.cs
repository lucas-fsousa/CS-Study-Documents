
namespace Componentes {
    partial class f_numericUpDown {
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
            this.nud_valor = new System.Windows.Forms.NumericUpDown();
            this.btn_def_valor = new System.Windows.Forms.Button();
            this.tb_valor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_valor
            // 
            this.nud_valor.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_valor.Location = new System.Drawing.Point(12, 12);
            this.nud_valor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_valor.Name = "nud_valor";
            this.nud_valor.Size = new System.Drawing.Size(63, 20);
            this.nud_valor.TabIndex = 0;
            this.nud_valor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_def_valor
            // 
            this.btn_def_valor.Location = new System.Drawing.Point(118, 12);
            this.btn_def_valor.Name = "btn_def_valor";
            this.btn_def_valor.Size = new System.Drawing.Size(75, 20);
            this.btn_def_valor.TabIndex = 1;
            this.btn_def_valor.Text = "Definir";
            this.btn_def_valor.UseVisualStyleBackColor = true;
            this.btn_def_valor.Click += new System.EventHandler(this.btn_def_valor_Click);
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(81, 12);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(31, 20);
            this.tb_valor.TabIndex = 2;
            // 
            // f_numericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 58);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.btn_def_valor);
            this.Controls.Add(this.nud_valor);
            this.Name = "f_numericUpDown";
            this.Text = "NumericUP";
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_valor;
        private System.Windows.Forms.Button btn_def_valor;
        private System.Windows.Forms.TextBox tb_valor;
    }
}