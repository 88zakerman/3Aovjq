namespace QualExam_Bingo_Bongo
{
    partial class Form5_viewStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5_viewStore));
            label_search = new Label();
            textBox_search = new TextBox();
            dataGridView_viewStore = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_viewStore).BeginInit();
            SuspendLayout();
            // 
            // label_search
            // 
            label_search.BackColor = Color.FromArgb(255, 229, 153);
            label_search.BorderStyle = BorderStyle.FixedSingle;
            label_search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_search.Location = new Point(6, 12);
            label_search.Name = "label_search";
            label_search.Size = new Size(105, 30);
            label_search.TabIndex = 8;
            label_search.Text = "Поиск";
            // 
            // textBox_search
            // 
            textBox_search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_search.Location = new Point(112, 12);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(676, 30);
            textBox_search.TabIndex = 7;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // dataGridView_viewStore
            // 
            dataGridView_viewStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_viewStore.Location = new Point(6, 48);
            dataGridView_viewStore.Name = "dataGridView_viewStore";
            dataGridView_viewStore.Size = new Size(1141, 666);
            dataGridView_viewStore.TabIndex = 9;
            // 
            // Form5_viewStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 726);
            Controls.Add(dataGridView_viewStore);
            Controls.Add(label_search);
            Controls.Add(textBox_search);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5_viewStore";
            Text = "Form5_viewStore";
            Load += Form5_viewStore_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_viewStore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_search;
        private TextBox textBox_search;
        private DataGridView dataGridView_viewStore;
    }
}