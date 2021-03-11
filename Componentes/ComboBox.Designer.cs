
namespace Componentes {
    partial class f_combobox {
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
            this.cmb_elementos = new System.Windows.Forms.ComboBox();
            this.btn_mostrar_element = new System.Windows.Forms.Button();
            this.btn_limpar_element = new System.Windows.Forms.Button();
            this.btn_reset_element = new System.Windows.Forms.Button();
            this.btn_adicionar_ele = new System.Windows.Forms.Button();
            this.tb_add_element = new System.Windows.Forms.TextBox();
            this.lbl_add_element = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_elementos
            // 
            this.cmb_elementos.FormattingEnabled = true;
            this.cmb_elementos.Items.AddRange(new object[] {
            "Avião",
            "Navio",
            "Onibus",
            "Carro",
            "Trem"});
            this.cmb_elementos.Location = new System.Drawing.Point(12, 12);
            this.cmb_elementos.Name = "cmb_elementos";
            this.cmb_elementos.Size = new System.Drawing.Size(121, 21);
            this.cmb_elementos.TabIndex = 0;
            this.cmb_elementos.SelectedIndexChanged += new System.EventHandler(this.cmb_elementos_SelectedIndexChanged);
            // 
            // btn_mostrar_element
            // 
            this.btn_mostrar_element.Location = new System.Drawing.Point(139, 9);
            this.btn_mostrar_element.Name = "btn_mostrar_element";
            this.btn_mostrar_element.Size = new System.Drawing.Size(135, 23);
            this.btn_mostrar_element.TabIndex = 1;
            this.btn_mostrar_element.Text = "Mostrar Selecionados";
            this.btn_mostrar_element.UseVisualStyleBackColor = true;
            this.btn_mostrar_element.Click += new System.EventHandler(this.btn_mostrar_element_Click);
            // 
            // btn_limpar_element
            // 
            this.btn_limpar_element.Location = new System.Drawing.Point(139, 38);
            this.btn_limpar_element.Name = "btn_limpar_element";
            this.btn_limpar_element.Size = new System.Drawing.Size(135, 23);
            this.btn_limpar_element.TabIndex = 2;
            this.btn_limpar_element.Text = "Limpar";
            this.btn_limpar_element.UseVisualStyleBackColor = true;
            this.btn_limpar_element.Click += new System.EventHandler(this.btn_limpar_element_Click);
            // 
            // btn_reset_element
            // 
            this.btn_reset_element.Location = new System.Drawing.Point(139, 67);
            this.btn_reset_element.Name = "btn_reset_element";
            this.btn_reset_element.Size = new System.Drawing.Size(135, 23);
            this.btn_reset_element.TabIndex = 3;
            this.btn_reset_element.Text = "Resetar";
            this.btn_reset_element.UseVisualStyleBackColor = true;
            this.btn_reset_element.Click += new System.EventHandler(this.btn_reset_element_Click);
            // 
            // btn_adicionar_ele
            // 
            this.btn_adicionar_ele.Location = new System.Drawing.Point(164, 208);
            this.btn_adicionar_ele.Name = "btn_adicionar_ele";
            this.btn_adicionar_ele.Size = new System.Drawing.Size(110, 23);
            this.btn_adicionar_ele.TabIndex = 4;
            this.btn_adicionar_ele.Text = "Adicionar";
            this.btn_adicionar_ele.UseVisualStyleBackColor = true;
            this.btn_adicionar_ele.Click += new System.EventHandler(this.btn_adicionar_ele_Click);
            // 
            // tb_add_element
            // 
            this.tb_add_element.Location = new System.Drawing.Point(12, 211);
            this.tb_add_element.Name = "tb_add_element";
            this.tb_add_element.Size = new System.Drawing.Size(140, 20);
            this.tb_add_element.TabIndex = 5;
            // 
            // lbl_add_element
            // 
            this.lbl_add_element.AutoSize = true;
            this.lbl_add_element.Location = new System.Drawing.Point(12, 195);
            this.lbl_add_element.Name = "lbl_add_element";
            this.lbl_add_element.Size = new System.Drawing.Size(98, 13);
            this.lbl_add_element.TabIndex = 6;
            this.lbl_add_element.Text = "Adicionar Elemento";
            // 
            // f_combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 253);
            this.Controls.Add(this.lbl_add_element);
            this.Controls.Add(this.tb_add_element);
            this.Controls.Add(this.btn_adicionar_ele);
            this.Controls.Add(this.btn_reset_element);
            this.Controls.Add(this.btn_limpar_element);
            this.Controls.Add(this.btn_mostrar_element);
            this.Controls.Add(this.cmb_elementos);
            this.Name = "f_combobox";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_elementos;
        private System.Windows.Forms.Button btn_mostrar_element;
        private System.Windows.Forms.Button btn_limpar_element;
        private System.Windows.Forms.Button btn_reset_element;
        private System.Windows.Forms.Button btn_adicionar_ele;
        private System.Windows.Forms.TextBox tb_add_element;
        private System.Windows.Forms.Label lbl_add_element;
    }
}