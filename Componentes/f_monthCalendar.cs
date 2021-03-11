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
    public partial class f_monthCalendar : Form {
        public f_monthCalendar() {
            InitializeComponent();
        }
        public void atualizar_data() {
            tb_pegar_data.Text = mc_01.SelectionStart.ToShortDateString(); // Pega o primeiro dia da seleção do Month Calendar
            tb_02.Text = mc_01.SelectionEnd.ToShortDateString(); // pega o Ultimo dia da seleção no Month Calendar
            tb_hoje.Text = mc_01.TodayDate.ToShortDateString(); // Pega o dia atual no calendário Month Calendar
        }

        private void btn_obter_Click(object sender, EventArgs e) {
            atualizar_data(); // Atualiza as informações de data do Month Calendar
        }

        private void mc_01_DateChanged(object sender, DateRangeEventArgs e) {
            atualizar_data(); // Atualiza as informações de data do Month Calendar
        }
    }
}
