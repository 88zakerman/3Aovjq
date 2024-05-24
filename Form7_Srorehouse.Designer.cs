namespace QualExam_Bingo_Bongo
{
    partial class Form7_Storehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7_Storehouse));
            button_deleteOrder = new Button();
            button_saveChanges = new Button();
            label_search = new Label();
            textBox_search = new TextBox();
            dataGridView_storehouse = new DataGridView();
            button_createPosition = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_storehouse).BeginInit();
            SuspendLayout();
            // 
            // button_deleteOrder
            // 
            button_deleteOrder.BackColor = Color.FromArgb(255, 124, 128);
            button_deleteOrder.FlatStyle = FlatStyle.Flat;
            button_deleteOrder.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_deleteOrder.Location = new Point(856, 577);
            button_deleteOrder.Name = "button_deleteOrder";
            button_deleteOrder.Size = new Size(196, 47);
            button_deleteOrder.TabIndex = 19;
            button_deleteOrder.Text = "Удалить позицию";
            button_deleteOrder.UseVisualStyleBackColor = false;
            button_deleteOrder.Click += button_deleteOrder_Click;
            // 
            // button_saveChanges
            // 
            button_saveChanges.BackColor = Color.FromArgb(255, 124, 128);
            button_saveChanges.FlatStyle = FlatStyle.Flat;
            button_saveChanges.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_saveChanges.Location = new Point(12, 577);
            button_saveChanges.Name = "button_saveChanges";
            button_saveChanges.Size = new Size(197, 47);
            button_saveChanges.TabIndex = 17;
            button_saveChanges.Text = "Внести изменения";
            button_saveChanges.UseVisualStyleBackColor = false;
            button_saveChanges.Click += button_saveChanges_Click;
            // 
            // label_search
            // 
            label_search.BackColor = Color.FromArgb(255, 229, 153);
            label_search.BorderStyle = BorderStyle.FixedSingle;
            label_search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_search.Location = new Point(12, 11);
            label_search.Name = "label_search";
            label_search.Size = new Size(105, 30);
            label_search.TabIndex = 16;
            label_search.Text = "Поиск";
            // 
            // textBox_search
            // 
            textBox_search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_search.Location = new Point(123, 11);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(929, 30);
            textBox_search.TabIndex = 15;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // dataGridView_storehouse
            // 
            dataGridView_storehouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_storehouse.Location = new Point(12, 44);
            dataGridView_storehouse.Name = "dataGridView_storehouse";
            dataGridView_storehouse.Size = new Size(1040, 527);
            dataGridView_storehouse.TabIndex = 14;
            // 
            // button_createPosition
            // 
            button_createPosition.BackColor = Color.FromArgb(255, 124, 128);
            button_createPosition.FlatStyle = FlatStyle.Flat;
            button_createPosition.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_createPosition.Location = new Point(215, 577);
            button_createPosition.Name = "button_createPosition";
            button_createPosition.Size = new Size(197, 47);
            button_createPosition.TabIndex = 20;
            button_createPosition.Text = "Создать запись";
            button_createPosition.UseVisualStyleBackColor = false;
            button_createPosition.Click += button_createPosition_Click;
            // 
            // Form7_Storehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 634);
            Controls.Add(button_createPosition);
            Controls.Add(button_deleteOrder);
            Controls.Add(button_saveChanges);
            Controls.Add(label_search);
            Controls.Add(textBox_search);
            Controls.Add(dataGridView_storehouse);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7_Storehouse";
            Text = "Form7_Storehouse";
            Load += Form7_Storehouse_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_storehouse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_deleteOrder;
        private Button button_saveChanges;
        private Label label_search;
        private TextBox textBox_search;
        private DataGridView dataGridView_storehouse;
        private Button button_createPosition;
    }
}