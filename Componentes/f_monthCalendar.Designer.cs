
namespace Componentes {
    partial class f_monthCalendar {
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
            this.mc_01 = new System.Windows.Forms.MonthCalendar();
            this.tb_pegar_data = new System.Windows.Forms.TextBox();
            this.tb_02 = new System.Windows.Forms.TextBox();
            this.btn_obter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_hoje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mc_01
            // 
            this.mc_01.Location = new System.Drawing.Point(18, 18);
            this.mc_01.MaxSelectionCount = 31;
            this.mc_01.Name = "mc_01";
            this.mc_01.TabIndex = 0;
            this.mc_01.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_01_DateChanged);
            // 
            // tb_pegar_data
            // 
            this.tb_pegar_data.Location = new System.Drawing.Point(284, 56);
            this.tb_pegar_data.Name = "tb_pegar_data";
            this.tb_pegar_data.Size = new System.Drawing.Size(67, 20);
            this.tb_pegar_data.TabIndex = 1;
            // 
            // tb_02
            // 
            this.tb_02.Location = new System.Drawing.Point(389, 56);
            this.tb_02.Name = "tb_02";
            this.tb_02.Size = new System.Drawing.Size(67, 20);
            this.tb_02.TabIndex = 2;
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(257, 18);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(126, 23);
            this.btn_obter.TabIndex = 3;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Até";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "De";
            // 
            // tb_hoje
            // 
            this.tb_hoje.Location = new System.Drawing.Point(323, 104);
            this.tb_hoje.Name = "tb_hoje";
            this.tb_hoje.Size = new System.Drawing.Size(67, 20);
            this.tb_hoje.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data atual:";
            // 
            // f_monthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_hoje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.tb_02);
            this.Controls.Add(this.tb_pegar_data);
            this.Controls.Add(this.mc_01);
            this.Name = "f_monthCalendar";
            this.Text = "Month Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mc_01;
        private System.Windows.Forms.TextBox tb_pegar_data;
        private System.Windows.Forms.TextBox tb_02;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_hoje;
        private System.Windows.Forms.Label label3;
    }
}