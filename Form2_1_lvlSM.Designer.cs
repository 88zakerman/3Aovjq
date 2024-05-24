namespace QualExam_Bingo_Bongo
{
    partial class Form2_1_lvlSM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_1_lvlSM));
            button_exit = new Button();
            button_viewAssortment = new Button();
            button_sell = new Button();
            pictureBox1 = new PictureBox();
            button_order = new Button();
            button_listOrder = new Button();
            button_store = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(255, 124, 128);
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_exit.Location = new Point(12, 434);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(276, 45);
            button_exit.TabIndex = 9;
            button_exit.Text = "Выйти";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // button_viewAssortment
            // 
            button_viewAssortment.BackColor = Color.FromArgb(255, 124, 128);
            button_viewAssortment.FlatStyle = FlatStyle.Flat;
            button_viewAssortment.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_viewAssortment.Location = new Point(12, 232);
            button_viewAssortment.Name = "button_viewAssortment";
            button_viewAssortment.Size = new Size(276, 45);
            button_viewAssortment.TabIndex = 8;
            button_viewAssortment.Text = "Ассортимент";
            button_viewAssortment.UseVisualStyleBackColor = false;
            button_viewAssortment.Click += button_viewAssortment_Click;
            // 
            // button_sell
            // 
            button_sell.BackColor = Color.FromArgb(255, 124, 128);
            button_sell.FlatStyle = FlatStyle.Flat;
            button_sell.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_sell.Location = new Point(12, 181);
            button_sell.Name = "button_sell";
            button_sell.Size = new Size(276, 45);
            button_sell.TabIndex = 7;
            button_sell.Text = "Продажа";
            button_sell.UseVisualStyleBackColor = false;
            button_sell.Click += button_sell_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 229, 153);
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button_order
            // 
            button_order.BackColor = Color.FromArgb(255, 124, 128);
            button_order.FlatStyle = FlatStyle.Flat;
            button_order.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_order.Location = new Point(12, 130);
            button_order.Name = "button_order";
            button_order.Size = new Size(276, 45);
            button_order.TabIndex = 5;
            button_order.Text = "Выдача заказа";
            button_order.UseVisualStyleBackColor = false;
            button_order.Click += button_order_Click;
            // 
            // button_listOrder
            // 
            button_listOrder.BackColor = Color.FromArgb(255, 124, 128);
            button_listOrder.FlatStyle = FlatStyle.Flat;
            button_listOrder.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_listOrder.Location = new Point(12, 283);
            button_listOrder.Name = "button_listOrder";
            button_listOrder.Size = new Size(276, 45);
            button_listOrder.TabIndex = 10;
            button_listOrder.Text = "Заказы";
            button_listOrder.UseVisualStyleBackColor = false;
            button_listOrder.Click += button_listOrder_Click;
            // 
            // button_store
            // 
            button_store.BackColor = Color.FromArgb(255, 124, 128);
            button_store.FlatStyle = FlatStyle.Flat;
            button_store.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_store.Location = new Point(12, 334);
            button_store.Name = "button_store";
            button_store.Size = new Size(276, 45);
            button_store.TabIndex = 11;
            button_store.Text = "Работа со складом";
            button_store.UseVisualStyleBackColor = false;
            button_store.Click += button_store_Click;
            // 
            // Form2_1_lvlSM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 486);
            Controls.Add(button_store);
            Controls.Add(button_listOrder);
            Controls.Add(button_exit);
            Controls.Add(button_viewAssortment);
            Controls.Add(button_sell);
            Controls.Add(pictureBox1);
            Controls.Add(button_order);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2_1_lvlSM";
            Text = "Form2_1_lvlSM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_exit;
        private Button button_viewAssortment;
        private Button button_sell;
        private PictureBox pictureBox1;
        private Button button_order;
        private Button button_listOrder;
        private Button button_store;
    }
}