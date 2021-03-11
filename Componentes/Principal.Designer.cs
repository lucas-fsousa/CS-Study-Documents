
namespace Componentes {
    partial class f_main {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_main));
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rcb_veic = new System.Windows.Forms.TextBox();
            this.tb_add_veic = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_mostar = new System.Windows.Forms.Button();
            this.btn_val_num = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNofify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimerPickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.progressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botãoDeRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNofify.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(166, 51);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionar Veiculo";
            // 
            // tb_rcb_veic
            // 
            this.tb_rcb_veic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rcb_veic.Location = new System.Drawing.Point(12, 79);
            this.tb_rcb_veic.Multiline = true;
            this.tb_rcb_veic.Name = "tb_rcb_veic";
            this.tb_rcb_veic.ReadOnly = true;
            this.tb_rcb_veic.Size = new System.Drawing.Size(229, 188);
            this.tb_rcb_veic.TabIndex = 2;
            this.tb_rcb_veic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_rcb_veic_MouseClick);
            this.tb_rcb_veic.TextChanged += new System.EventHandler(this.tb_rcb_veic_TextChanged);
            // 
            // tb_add_veic
            // 
            this.tb_add_veic.Location = new System.Drawing.Point(15, 53);
            this.tb_add_veic.Name = "tb_add_veic";
            this.tb_add_veic.Size = new System.Drawing.Size(145, 20);
            this.tb_add_veic.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(15, 273);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(90, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_mostar
            // 
            this.btn_mostar.Location = new System.Drawing.Point(151, 273);
            this.btn_mostar.Name = "btn_mostar";
            this.btn_mostar.Size = new System.Drawing.Size(90, 23);
            this.btn_mostar.TabIndex = 5;
            this.btn_mostar.Text = "Listar Veiculos";
            this.btn_mostar.UseVisualStyleBackColor = true;
            this.btn_mostar.Click += new System.EventHandler(this.btn_mostar_Click);
            // 
            // btn_val_num
            // 
            this.btn_val_num.Location = new System.Drawing.Point(15, 302);
            this.btn_val_num.Name = "btn_val_num";
            this.btn_val_num.Size = new System.Drawing.Size(226, 23);
            this.btn_val_num.TabIndex = 6;
            this.btn_val_num.Text = "Valor da variavel NUM";
            this.btn_val_num.UseVisualStyleBackColor = true;
            this.btn_val_num.Click += new System.EventHandler(this.btn_val_num_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNofify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ic_alerta";
            this.notifyIcon1.Visible = true;
            // 
            // MenuNofify
            // 
            this.MenuNofify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_restaurar,
            this.tsm_mensagem,
            this.tsm_fechar});
            this.MenuNofify.Name = "MenuNofify";
            this.MenuNofify.Size = new System.Drawing.Size(134, 70);
            this.MenuNofify.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNofify_ItemClicked);
            // 
            // tsm_restaurar
            // 
            this.tsm_restaurar.Name = "tsm_restaurar";
            this.tsm_restaurar.Size = new System.Drawing.Size(133, 22);
            this.tsm_restaurar.Text = "Restaurar";
            // 
            // tsm_mensagem
            // 
            this.tsm_mensagem.Name = "tsm_mensagem";
            this.tsm_mensagem.Size = new System.Drawing.Size(133, 22);
            this.tsm_mensagem.Text = "Mensagem";
            // 
            // tsm_fechar
            // 
            this.tsm_fechar.Name = "tsm_fechar";
            this.tsm_fechar.Size = new System.Drawing.Size(133, 22);
            this.tsm_fechar.Text = "Fechar";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimerPickToolStripMenuItem,
            this.linkedLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.pictureBoxToolStripMenuItem,
            this.progressBarToolStripMenuItem,
            this.botãoDeRadioToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkboxToolStripMenuItem
            // 
            this.checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            this.checkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkboxToolStripMenuItem.Text = "Checkbox";
            this.checkboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "Checked ListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimerPickToolStripMenuItem
            // 
            this.dateTimerPickToolStripMenuItem.Name = "dateTimerPickToolStripMenuItem";
            this.dateTimerPickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimerPickToolStripMenuItem.Text = "Date/Timer-Pick";
            this.dateTimerPickToolStripMenuItem.Click += new System.EventHandler(this.dateTimerPickToolStripMenuItem_Click);
            // 
            // linkedLabelToolStripMenuItem
            // 
            this.linkedLabelToolStripMenuItem.Name = "linkedLabelToolStripMenuItem";
            this.linkedLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkedLabelToolStripMenuItem.Text = "Linked Label";
            this.linkedLabelToolStripMenuItem.Click += new System.EventHandler(this.linkedLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listViewToolStripMenuItem.Text = "List View";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBoxToolStripMenuItem.Text = "Masked Text Box";
            this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthCalendarToolStripMenuItem.Text = "Month Calendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pictureBoxToolStripMenuItem.Text = "Picture Box";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // progressBarToolStripMenuItem
            // 
            this.progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            this.progressBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.progressBarToolStripMenuItem.Text = "Progress Bar";
            this.progressBarToolStripMenuItem.Click += new System.EventHandler(this.progressBarToolStripMenuItem_Click);
            // 
            // botãoDeRadioToolStripMenuItem
            // 
            this.botãoDeRadioToolStripMenuItem.Name = "botãoDeRadioToolStripMenuItem";
            this.botãoDeRadioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.botãoDeRadioToolStripMenuItem.Text = "Botão de Radio";
            this.botãoDeRadioToolStripMenuItem.Click += new System.EventHandler(this.botãoDeRadioToolStripMenuItem_Click);
            // 
            // f_main
            // 
            this.ClientSize = new System.Drawing.Size(262, 346);
            this.Controls.Add(this.btn_val_num);
            this.Controls.Add(this.btn_mostar);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_add_veic);
            this.Controls.Add(this.tb_rcb_veic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "f_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.MenuNofify.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adc_veiculo;
        private System.Windows.Forms.TextBox tb_adc_veiculo;
        private System.Windows.Forms.TextBox tb_rcb_veiculo;
        private System.Windows.Forms.Label lbl_dig_veiculo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_add_veic;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_mostar;
        private System.Windows.Forms.Button btn_val_num;
        public System.Windows.Forms.TextBox tb_rcb_veic;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MenuNofify;
        private System.Windows.Forms.ToolStripMenuItem tsm_restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsm_mensagem;
        private System.Windows.Forms.ToolStripMenuItem tsm_fechar;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimerPickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botãoDeRadioToolStripMenuItem;
    }
}

