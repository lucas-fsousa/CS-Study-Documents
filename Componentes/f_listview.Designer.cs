
namespace Componentes {
    partial class f_listview {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "34",
            "74,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "150",
            "37,75"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Fone",
            "12",
            "19,75"}, -1);
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.tb_qtd = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.btn_add_prod = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(22, 192);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(41, 20);
            this.tb_id.TabIndex = 1;
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(191, 192);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(270, 20);
            this.tb_produto.TabIndex = 2;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(125, 192);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(60, 20);
            this.tb_preco.TabIndex = 3;
            // 
            // tb_qtd
            // 
            this.tb_qtd.Location = new System.Drawing.Point(69, 192);
            this.tb_qtd.Name = "tb_qtd";
            this.tb_qtd.Size = new System.Drawing.Size(50, 20);
            this.tb_qtd.TabIndex = 4;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(35, 176);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "ID";
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Location = new System.Drawing.Point(80, 176);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(30, 13);
            this.lbl_qtd.TabIndex = 6;
            this.lbl_qtd.Text = "QTD";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(132, 176);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(44, 13);
            this.lbl_preco.TabIndex = 7;
            this.lbl_preco.Text = "PREÇO";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(263, 176);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(115, 13);
            this.lbl_produto.TabIndex = 8;
            this.lbl_produto.Text = "NOME DO PRODUTO";
            // 
            // btn_add_prod
            // 
            this.btn_add_prod.Location = new System.Drawing.Point(22, 218);
            this.btn_add_prod.Name = "btn_add_prod";
            this.btn_add_prod.Size = new System.Drawing.Size(112, 23);
            this.btn_add_prod.TabIndex = 9;
            this.btn_add_prod.Text = "Adicionar Produto";
            this.btn_add_prod.UseVisualStyleBackColor = true;
            this.btn_add_prod.Click += new System.EventHandler(this.btn_add_prod_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(140, 218);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(107, 23);
            this.btn_excluir.TabIndex = 10;
            this.btn_excluir.Text = "Excluir Produto";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(253, 218);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(208, 23);
            this.btn_obter.TabIndex = 11;
            this.btn_obter.Text = "Atualizar Produto";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 30;
            // 
            // col_produto
            // 
            this.col_produto.Text = "Produto";
            this.col_produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col_produto.Width = 243;
            // 
            // col_qtd
            // 
            this.col_qtd.Text = "Quantidade";
            this.col_qtd.Width = 80;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.Width = 80;
            // 
            // lv_produtos
            // 
            this.lv_produtos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_produtos.AutoArrange = false;
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_qtd,
            this.col_preco});
            this.lv_produtos.FullRowSelect = true;
            this.lv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_produtos.Location = new System.Drawing.Point(22, 12);
            this.lv_produtos.MultiSelect = false;
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Size = new System.Drawing.Size(439, 140);
            this.lv_produtos.TabIndex = 0;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            this.lv_produtos.SelectedIndexChanged += new System.EventHandler(this.lv_produtos_SelectedIndexChanged);
            // 
            // f_listview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 260);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_add_prod);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.tb_qtd);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lv_produtos);
            this.Name = "f_listview";
            this.Text = "List View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.TextBox tb_qtd;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Button btn_add_prod;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_qtd;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.ListView lv_produtos;
    }
}