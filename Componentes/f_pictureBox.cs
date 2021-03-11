using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes {
    public partial class f_pictureBox : Form {
        public f_pictureBox() {
            InitializeComponent();
        }

        private void f_pictureBox_Load(object sender, EventArgs e) {
            label1.Text = Properties.Resources.NomeCanal; // Adiciona o texto do Resources dentro do label de destino
            label2.Text = Properties.Resources.Endereço; // Adiciona o texto do Resources dentro do label de destino
        }

        private void btn_img1_Click(object sender, EventArgs e) {
            pictureBox1.Image = Properties.Resources.a; // Adiciona a imagem seleciona ao pictureBox
        }

        private void btn_img2_Click(object sender, EventArgs e) {
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2021_03_04_at_11_25_46_PM; // Adiciona a imagem seleciona no picture box
        }
    }
}
