
namespace Componentes {
    partial class f_progressbar {
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
            this.pgbar_01 = new System.Windows.Forms.ProgressBar();
            this.btn_definit = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_contar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pgbar_01
            // 
            this.pgbar_01.Location = new System.Drawing.Point(93, 68);
            this.pgbar_01.Name = "pgbar_01";
            this.pgbar_01.Size = new System.Drawing.Size(251, 23);
            this.pgbar_01.TabIndex = 0;
            // 
            // btn_definit
            // 
            this.btn_definit.Location = new System.Drawing.Point(269, 13);
            this.btn_definit.Name = "btn_definit";
            this.btn_definit.Size = new System.Drawing.Size(75, 22);
            this.btn_definit.TabIndex = 1;
            this.btn_definit.Text = "Definir";
            this.btn_definit.UseVisualStyleBackColor = true;
            this.btn_definit.Click += new System.EventHandler(this.btn_definit_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 68);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor da Progressão:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // tb_contar
            // 
            this.tb_contar.Location = new System.Drawing.Point(182, 97);
            this.tb_contar.Name = "tb_contar";
            this.tb_contar.Size = new System.Drawing.Size(46, 20);
            this.tb_contar.TabIndex = 5;
            // 
            // f_progressbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 147);
            this.Controls.Add(this.tb_contar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_definit);
            this.Controls.Add(this.pgbar_01);
            this.Name = "f_progressbar";
            this.Text = "Barra de Progressão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbar_01;
        private System.Windows.Forms.Button btn_definit;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_contar;
    }
}