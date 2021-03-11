
namespace Componentes {
    partial class f_datetimer {
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_obter_data = new System.Windows.Forms.Button();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_data_comp = new System.Windows.Forms.TextBox();
            this.btn_setar_data = new System.Windows.Forms.Button();
            this.tb_data_tudo = new System.Windows.Forms.TextBox();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(3, 12);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(236, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_obter_data
            // 
            this.btn_obter_data.Location = new System.Drawing.Point(245, 12);
            this.btn_obter_data.Name = "btn_obter_data";
            this.btn_obter_data.Size = new System.Drawing.Size(77, 20);
            this.btn_obter_data.TabIndex = 1;
            this.btn_obter_data.Text = "Obter Data";
            this.btn_obter_data.UseVisualStyleBackColor = true;
            this.btn_obter_data.Click += new System.EventHandler(this.btn_obter_data_Click);
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(3, 70);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(35, 20);
            this.tb_dia.TabIndex = 2;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(44, 70);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(35, 20);
            this.tb_mes.TabIndex = 3;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(85, 70);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(35, 20);
            this.tb_ano.TabIndex = 4;
            // 
            // tb_data_comp
            // 
            this.tb_data_comp.Location = new System.Drawing.Point(3, 44);
            this.tb_data_comp.Name = "tb_data_comp";
            this.tb_data_comp.ReadOnly = true;
            this.tb_data_comp.Size = new System.Drawing.Size(236, 20);
            this.tb_data_comp.TabIndex = 5;
            // 
            // btn_setar_data
            // 
            this.btn_setar_data.Location = new System.Drawing.Point(136, 95);
            this.btn_setar_data.Name = "btn_setar_data";
            this.btn_setar_data.Size = new System.Drawing.Size(78, 20);
            this.btn_setar_data.TabIndex = 9;
            this.btn_setar_data.Text = "Setar Data";
            this.btn_setar_data.UseVisualStyleBackColor = true;
            this.btn_setar_data.Click += new System.EventHandler(this.btn_setar_data_Click);
            // 
            // tb_data_tudo
            // 
            this.tb_data_tudo.Location = new System.Drawing.Point(3, 96);
            this.tb_data_tudo.Name = "tb_data_tudo";
            this.tb_data_tudo.ReadOnly = true;
            this.tb_data_tudo.Size = new System.Drawing.Size(117, 20);
            this.tb_data_tudo.TabIndex = 10;
            this.tb_data_tudo.TextChanged += new System.EventHandler(this.tb_data_tudo_TextChanged);
            // 
            // btn_hoje
            // 
            this.btn_hoje.Location = new System.Drawing.Point(245, 44);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(77, 20);
            this.btn_hoje.TabIndex = 11;
            this.btn_hoje.Text = "Hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // f_datetimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 124);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.tb_data_tudo);
            this.Controls.Add(this.btn_setar_data);
            this.Controls.Add(this.tb_data_comp);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.btn_obter_data);
            this.Controls.Add(this.dtp_data);
            this.Name = "f_datetimer";
            this.Text = "Tempo e Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_obter_data;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.TextBox tb_data_comp;
        private System.Windows.Forms.Button btn_setar_data;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.TextBox tb_data_tudo;
        private System.Windows.Forms.Button btn_hoje;
    }
}