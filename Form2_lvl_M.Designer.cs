namespace QualExam_Bingo_Bongo
{
    partial class Form2_lvl_M
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_lvl_M));
            button_order = new Button();
            pictureBox1 = new PictureBox();
            button_sell = new Button();
            button_viewAssortment = new Button();
            button_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_order
            // 
            button_order.BackColor = Color.FromArgb(255, 124, 128);
            button_order.FlatStyle = FlatStyle.Flat;
            button_order.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_order.Location = new Point(12, 130);
            button_order.Name = "button_order";
            button_order.Size = new Size(276, 45);
            button_order.TabIndex = 0;
            button_order.Text = "Выдача заказа";
            button_order.UseVisualStyleBackColor = false;
            button_order.Click += button_order_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 229, 153);
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button_sell
            // 
            button_sell.BackColor = Color.FromArgb(255, 124, 128);
            button_sell.FlatStyle = FlatStyle.Flat;
            button_sell.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_sell.Location = new Point(12, 181);
            button_sell.Name = "button_sell";
            button_sell.Size = new Size(276, 45);
            button_sell.TabIndex = 2;
            button_sell.Text = "Продажа";
            button_sell.UseVisualStyleBackColor = false;
            button_sell.Click += button_sell_Click;
            // 
            // button_viewAssortment
            // 
            button_viewAssortment.BackColor = Color.FromArgb(255, 124, 128);
            button_viewAssortment.FlatStyle = FlatStyle.Flat;
            button_viewAssortment.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_viewAssortment.Location = new Point(12, 232);
            button_viewAssortment.Name = "button_viewAssortment";
            button_viewAssortment.Size = new Size(276, 45);
            button_viewAssortment.TabIndex = 3;
            button_viewAssortment.Text = "Ассортимент";
            button_viewAssortment.UseVisualStyleBackColor = false;
            button_viewAssortment.Click += button_viewAssortment_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(255, 124, 128);
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_exit.Location = new Point(12, 323);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(276, 45);
            button_exit.TabIndex = 4;
            button_exit.Text = "Выйти";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // Form2_lvl_M
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 377);
            Controls.Add(button_exit);
            Controls.Add(button_viewAssortment);
            Controls.Add(button_sell);
            Controls.Add(pictureBox1);
            Controls.Add(button_order);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2_lvl_M";
            Text = "Form2_lvl_M";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_order;
        private PictureBox pictureBox1;
        private Button button_sell;
        private Button button_viewAssortment;
        private Button button_exit;
    }
}