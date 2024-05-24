namespace QualExam_Bingo_Bongo
{
    partial class Form3_orderRelease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_orderRelease));
            button_giveOrder = new Button();
            label_search = new Label();
            textBox_search = new TextBox();
            dataGridView_order = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_order).BeginInit();
            SuspendLayout();
            // 
            // button_giveOrder
            // 
            button_giveOrder.BackColor = Color.FromArgb(255, 124, 128);
            button_giveOrder.FlatStyle = FlatStyle.Flat;
            button_giveOrder.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_giveOrder.Location = new Point(474, 400);
            button_giveOrder.Name = "button_giveOrder";
            button_giveOrder.Size = new Size(413, 38);
            button_giveOrder.TabIndex = 3;
            button_giveOrder.Text = "Выдать";
            button_giveOrder.UseVisualStyleBackColor = false;
            button_giveOrder.Click += button_giveOrder_Click;
            // 
            // label_search
            // 
            label_search.BackColor = Color.FromArgb(255, 229, 153);
            label_search.BorderStyle = BorderStyle.FixedSingle;
            label_search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_search.Location = new Point(12, 9);
            label_search.Name = "label_search";
            label_search.Size = new Size(100, 30);
            label_search.TabIndex = 2;
            label_search.Text = "Поиск";
            // 
            // textBox_search
            // 
            textBox_search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_search.Location = new Point(118, 9);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(769, 30);
            textBox_search.TabIndex = 1;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // dataGridView_order
            // 
            dataGridView_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_order.Location = new Point(12, 45);
            dataGridView_order.Name = "dataGridView_order";
            dataGridView_order.Size = new Size(875, 349);
            dataGridView_order.TabIndex = 4;
            // 
            // Form3_orderRelease
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 450);
            Controls.Add(dataGridView_order);
            Controls.Add(button_giveOrder);
            Controls.Add(label_search);
            Controls.Add(textBox_search);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3_orderRelease";
            Text = "Form3_orderRelease";
            Load += Form3_orderRelease_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_giveOrder;
        private Label label_search;
        private TextBox textBox_search;
        private DataGridView dataGridView_order;
    }
}