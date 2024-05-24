namespace QualExam_Bingo_Bongo
{
    partial class Form8_createProduct
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
            button_create = new Button();
            textBox_price_products = new TextBox();
            label3 = new Label();
            textBox_in_stock_products = new TextBox();
            label2 = new Label();
            textBox_name_products = new TextBox();
            label_name_products = new Label();
            textBox_type_products = new TextBox();
            label_type_products = new Label();
            SuspendLayout();
            // 
            // button_create
            // 
            button_create.BackColor = Color.FromArgb(255, 124, 128);
            button_create.FlatStyle = FlatStyle.Flat;
            button_create.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_create.Location = new Point(11, 166);
            button_create.Name = "button_create";
            button_create.Size = new Size(461, 44);
            button_create.TabIndex = 39;
            button_create.Text = "Создать";
            button_create.UseVisualStyleBackColor = false;
            button_create.Click += button_create_Click;
            // 
            // textBox_price_products
            // 
            textBox_price_products.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_price_products.Location = new Point(186, 126);
            textBox_price_products.Name = "textBox_price_products";
            textBox_price_products.Size = new Size(287, 34);
            textBox_price_products.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 229, 153);
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 34;
            label3.Text = "price_products";
            // 
            // textBox_in_stock_products
            // 
            textBox_in_stock_products.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_in_stock_products.Location = new Point(186, 86);
            textBox_in_stock_products.Name = "textBox_in_stock_products";
            textBox_in_stock_products.Size = new Size(287, 34);
            textBox_in_stock_products.TabIndex = 33;
            textBox_in_stock_products.TextChanged += textBox_in_stock_products_TextChanged;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.ScrollBar;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 229, 153);
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 32;
            label2.Text = "in_stock_products";
            // 
            // textBox_name_products
            // 
            textBox_name_products.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_name_products.Location = new Point(186, 46);
            textBox_name_products.Name = "textBox_name_products";
            textBox_name_products.Size = new Size(287, 34);
            textBox_name_products.TabIndex = 31;
            // 
            // label_name_products
            // 
            label_name_products.AutoSize = true;
            label_name_products.BackColor = Color.FromArgb(255, 229, 153);
            label_name_products.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_name_products.Location = new Point(12, 51);
            label_name_products.Name = "label_name_products";
            label_name_products.Size = new Size(119, 23);
            label_name_products.TabIndex = 30;
            label_name_products.Text = "name_products";
            // 
            // textBox_type_products
            // 
            textBox_type_products.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_type_products.Location = new Point(186, 6);
            textBox_type_products.Name = "textBox_type_products";
            textBox_type_products.Size = new Size(287, 34);
            textBox_type_products.TabIndex = 29;
            // 
            // label_type_products
            // 
            label_type_products.AutoSize = true;
            label_type_products.BackColor = Color.FromArgb(255, 229, 153);
            label_type_products.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_type_products.Location = new Point(12, 11);
            label_type_products.Name = "label_type_products";
            label_type_products.Size = new Size(117, 23);
            label_type_products.TabIndex = 28;
            label_type_products.Text = "type_products";
            // 
            // Form8_createProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 220);
            Controls.Add(button_create);
            Controls.Add(textBox_price_products);
            Controls.Add(label3);
            Controls.Add(textBox_in_stock_products);
            Controls.Add(label2);
            Controls.Add(textBox_name_products);
            Controls.Add(label_name_products);
            Controls.Add(textBox_type_products);
            Controls.Add(label_type_products);
            Name = "Form8_createProduct";
            Text = "Form8_createProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_create;
        private TextBox textBox_price_products;
        private Label label3;
        private TextBox textBox_in_stock_products;
        private Label label2;
        private TextBox textBox_name_products;
        private Label label_name_products;
        private TextBox textBox_type_products;
        private Label label_type_products;
    }
}