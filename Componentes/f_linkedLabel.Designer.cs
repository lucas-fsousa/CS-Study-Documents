
namespace Componentes {
    partial class f_linkedLabel {
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
            this.label1 = new System.Windows.Forms.Label();
            this.ll_author = new System.Windows.Forms.LinkLabel();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.ll_calc = new System.Windows.Forms.LinkLabel();
            this.ll_aux = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // ll_author
            // 
            this.ll_author.AutoSize = true;
            this.ll_author.Location = new System.Drawing.Point(12, 63);
            this.ll_author.Name = "ll_author";
            this.ll_author.Size = new System.Drawing.Size(38, 13);
            this.ll_author.TabIndex = 1;
            this.ll_author.TabStop = true;
            this.ll_author.Text = "Author";
            this.ll_author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_author_LinkClicked);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 25);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // ll_calc
            // 
            this.ll_calc.AutoSize = true;
            this.ll_calc.Location = new System.Drawing.Point(12, 88);
            this.ll_calc.Name = "ll_calc";
            this.ll_calc.Size = new System.Drawing.Size(28, 13);
            this.ll_calc.TabIndex = 3;
            this.ll_calc.TabStop = true;
            this.ll_calc.Text = "Calc";
            this.ll_calc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calc_LinkClicked);
            // 
            // ll_aux
            // 
            this.ll_aux.AutoSize = true;
            this.ll_aux.Location = new System.Drawing.Point(9, 115);
            this.ll_aux.Name = "ll_aux";
            this.ll_aux.Size = new System.Drawing.Size(138, 13);
            this.ll_aux.TabIndex = 4;
            this.ll_aux.TabStop = true;
            this.ll_aux.Text = "Google - Channel - Youtube";
            this.ll_aux.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_aux_LinkClicked);
            // 
            // f_linkedLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 267);
            this.Controls.Add(this.ll_aux);
            this.Controls.Add(this.ll_calc);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.ll_author);
            this.Controls.Add(this.label1);
            this.Name = "f_linkedLabel";
            this.Text = "Linked Label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ll_author;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.LinkLabel ll_calc;
        private System.Windows.Forms.LinkLabel ll_aux;
    }
}