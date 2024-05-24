namespace QualExam_Bingo_Bongo
{
    partial class Form4_Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_Sell));
            button_Sell = new Button();
            label_search = new Label();
            textBox_search = new TextBox();
            dataGridView_sell = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sell).BeginInit();
            SuspendLayout();
            // 
            // button_Sell
            // 
            button_Sell.BackColor = Color.FromArgb(255, 124, 128);
            button_Sell.FlatStyle = FlatStyle.Flat;
            button_Sell.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Sell.Location = new Point(474, 400);
            button_Sell.Name = "button_Sell";
            button_Sell.Size = new Size(413, 38);
            button_Sell.TabIndex = 7;
            button_Sell.Text = "Продать";
            button_Sell.UseVisualStyleBackColor = false;
            button_Sell.Click += button_Sell_Click;
            // 
            // label_search
            // 
            label_search.BackColor = Color.FromArgb(255, 229, 153);
            label_search.BorderStyle = BorderStyle.FixedSingle;
            label_search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_search.Location = new Point(12, 10);
            label_search.Name = "label_search";
            label_search.Size = new Size(100, 30);
            label_search.TabIndex = 6;
            label_search.Text = "Поиск";
            // 
            // textBox_search
            // 
            textBox_search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_search.Location = new Point(118, 10);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(769, 30);
            textBox_search.TabIndex = 5;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // dataGridView_sell
            // 
            dataGridView_sell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_sell.Location = new Point(12, 46);
            dataGridView_sell.Name = "dataGridView_sell";
            dataGridView_sell.Size = new Size(875, 349);
            dataGridView_sell.TabIndex = 8;
            // 
            // Form4_Sell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 450);
            Controls.Add(dataGridView_sell);
            Controls.Add(button_Sell);
            Controls.Add(label_search);
            Controls.Add(textBox_search);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4_Sell";
            Text = "Form4_Sell";
            Load += Form4_Sell_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_sell).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Sell;
        private Label label_search;
        private TextBox textBox_search;
        private DataGridView dataGridView_sell;
    }
}