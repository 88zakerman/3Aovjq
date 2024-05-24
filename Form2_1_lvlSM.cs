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
    public partial class Form2_1_lvlSM : Form
    {
        private Form3_orderRelease formOrderRelease;
        private Form4_Sell formSell;
        private Form5_viewStore formViewStore;
        private Form6_orderList formOrderList;
        private Form7_Storehouse formStorehouse;

        public Form2_1_lvlSM()
        {
            InitializeComponent();

            // Инициализация форм
            formOrderRelease = new Form3_orderRelease();
            formSell = new Form4_Sell();
            formViewStore = new Form5_viewStore();
            formOrderList = new Form6_orderList();
            formStorehouse = new Form7_Storehouse();
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

        private void button_listOrder_Click(object sender, EventArgs e)
        {
            formOrderList.Show();
        }

        private void button_store_Click(object sender, EventArgs e)
        {
            formStorehouse.Show();
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
            formOrderList.Close();
            formStorehouse.Close();
            Close();
        }
    }
}
