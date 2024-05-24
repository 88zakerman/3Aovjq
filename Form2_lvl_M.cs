using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualExam_Bingo_Bongo
{
    public partial class Form2_lvl_M : Form
    {
        private Form3_orderRelease formOrderRelease;
        private Form4_Sell formSell;
        private Form5_viewStore formViewStore;

        public Form2_lvl_M()
        {
            InitializeComponent();

            // Инициализация форм
            formOrderRelease = new Form3_orderRelease();
            formSell = new Form4_Sell();
            formViewStore = new Form5_viewStore();
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            formOrderRelease.Show();
        }

        private void button_sell_Click(object sender, EventArgs e)
        {
            formSell.Show();
        }

        private void button_viewAssortment_Click(object sender, EventArgs e)
        {
            formViewStore.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            CloseAllForms();

        }
        private void CloseAllForms()
        {
            // Закрыть все открытые формы
            formOrderRelease.Close();
            formSell.Close();
            formViewStore.Close();
            Close();
        }
    }
}
