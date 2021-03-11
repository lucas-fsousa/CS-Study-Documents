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
    public partial class f_filho : Form {
        public f_checkbox ffbox;
        public f_filho() {
            InitializeComponent();
            ffbox = Application.OpenForms["f_checkbox"] as f_checkbox;
            cb_carro.Checked = ffbox.cb_carro.Checked;
            cb_aviao.Checked = ffbox.cb_aviao.Checked;
            cb_navio.Checked = ffbox.cb_navio.Checked;
            cb_onibus.Checked = ffbox.cb_onibus.Checked;
        }
    }
}
