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
    public partial class f_linkedLabel : Form {
        public f_linkedLabel() {
            InitializeComponent();
            ll_aux.Links.Add(0,6,"https://www.google.com.br");
            ll_aux.Links.Add(9, 7, "https://github.com/lucas-fsousa");
            ll_aux.Links.Add(19, 7,"https://Youtube.com");

            ll_aux.Links[2].Enabled = false; // Desabilita o link da posição 2.
        }

        private void ll_author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LinkLabel ll = (LinkLabel)sender;
            System.Diagnostics.Process.Start("https://github.com/lucas-fsousa"+""); // Abre uma pagina da internet utilizando o browser padrão do sistema (é possivel concatenar string)
            ll.LinkVisited = true; // Infomra que o link foi visitado mudando a caor do link
        }

        private void ll_calc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_aux_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString()); // Paramentro E com o LinkData informa ao programa o local exato do click e adiciona o evento de acordo com o link de origem
            e.Link.Visited = true; // Infomra que o link foi visitado.
        }
    }
}
