namespace QualExam_Bingo_Bongo
{
    partial class Form6_orderList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6_orderList));
            dataGridView_orderList = new DataGridView();
            label_search = new Label();
            textBox_search = new TextBox();
            button_createOrder = new Button();
            button_editOrder = new Button();
            button_deleteOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_orderList).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_orderList
            // 
            dataGridView_orderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_orderList.Location = new Point(12, 42);
            dataGridView_orderList.Name = "dataGridView_orderList";
            dataGridView_orderList.ReadOnly = true;
            dataGridView_orderList.Size = new Size(1040, 527);
            dataGridView_orderList.TabIndex = 0;
            // 
            // label_search
            // 
            label_search.BackColor = Color.FromArgb(255, 229, 153);
            label_search.BorderStyle = BorderStyle.FixedSingle;
            label_search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_search.Location = new Point(12, 9);
            label_search.Name = "label_search";
            label_search.Size = new Size(105, 30);
            label_search.TabIndex = 10;
            label_search.Text = "Поиск";
            // 
            // textBox_search
            // 
            textBox_search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_search.Location = new Point(123, 9);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(929, 30);
            textBox_search.TabIndex = 9;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // button_createOrder
            // 
            button_createOrder.BackColor = Color.FromArgb(255, 124, 128);
            button_createOrder.FlatStyle = FlatStyle.Flat;
            button_createOrder.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_createOrder.Location = new Point(12, 575);
            button_createOrder.Name = "button_createOrder";
            button_createOrder.Size = new Size(146, 47);
            button_createOrder.TabIndex = 11;
            button_createOrder.Text = "Создать заказ";
            button_createOrder.UseVisualStyleBackColor = false;
            button_createOrder.Click += button_createOrder_Click;
            // 
            // button_editOrder
            // 
            button_editOrder.BackColor = Color.FromArgb(255, 124, 128);
            button_editOrder.FlatStyle = FlatStyle.Flat;
            button_editOrder.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_editOrder.Location = new Point(164, 575);
            button_editOrder.Name = "button_editOrder";
            button_editOrder.Size = new Size(175, 47);
            button_editOrder.TabIndex = 12;
            button_editOrder.Text = "Редактировать заказ";
            button_editOrder.UseVisualStyleBackColor = false;
            button_editOrder.Click += button_editOrder_Click;
            // 
            // button_deleteOrder
            // 
            button_deleteOrder.BackColor = Color.FromArgb(255, 124, 128);
            button_deleteOrder.FlatStyle = FlatStyle.Flat;
            button_deleteOrder.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_deleteOrder.Location = new Point(906, 575);
            button_deleteOrder.Name = "button_deleteOrder";
            button_deleteOrder.Size = new Size(146, 47);
            button_deleteOrder.TabIndex = 13;
            button_deleteOrder.Text = "Удалить заказ";
            button_deleteOrder.UseVisualStyleBackColor = false;
            button_deleteOrder.Click += button_deleteOrder_Click;
            // 
            // Form6_orderList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 634);
            Controls.Add(button_deleteOrder);
            Controls.Add(button_editOrder);
            Controls.Add(button_createOrder);
            Controls.Add(label_search);
            Controls.Add(textBox_search);
            Controls.Add(dataGridView_orderList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6_orderList";
            Text = "Form6_orderList";
            Load += Form6_orderList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_orderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_orderList;
        private Label label_search;
        private TextBox textBox_search;
        private Button button_createOrder;
        private Button button_editOrder;
        private Button button_deleteOrder;
    }
}