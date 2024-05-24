namespace QualExam_Bingo_Bongo
{
    partial class Form6_editOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6_editOrder));
            button_saveEdit = new Button();
            textBox_order_number = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox_request_quantity = new TextBox();
            label3 = new Label();
            textBox_requested_product = new TextBox();
            label2 = new Label();
            textBox_contact_email = new TextBox();
            label1 = new Label();
            textBox_customer_name = new TextBox();
            label_customer_name = new Label();
            dateTimePicker_request_date = new DateTimePicker();
            SuspendLayout();
            // 
            // button_saveEdit
            // 
            button_saveEdit.BackColor = Color.FromArgb(255, 124, 128);
            button_saveEdit.FlatStyle = FlatStyle.Flat;
            button_saveEdit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_saveEdit.Location = new Point(12, 246);
            button_saveEdit.Name = "button_saveEdit";
            button_saveEdit.Size = new Size(461, 44);
            button_saveEdit.TabIndex = 25;
            button_saveEdit.Text = "Изменить";
            button_saveEdit.UseVisualStyleBackColor = false;
            button_saveEdit.Click += button_saveEdit_Click;
            // 
            // textBox_order_number
            // 
            textBox_order_number.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_order_number.Location = new Point(186, 206);
            textBox_order_number.Name = "textBox_order_number";
            textBox_order_number.Size = new Size(287, 34);
            textBox_order_number.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 229, 153);
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 211);
            label5.Name = "label5";
            label5.Size = new Size(114, 23);
            label5.TabIndex = 23;
            label5.Text = "order_number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 229, 153);
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 21;
            label4.Text = "request_date";
            // 
            // textBox_request_quantity
            // 
            textBox_request_quantity.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_request_quantity.Location = new Point(186, 126);
            textBox_request_quantity.Name = "textBox_request_quantity";
            textBox_request_quantity.Size = new Size(287, 34);
            textBox_request_quantity.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 229, 153);
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 19;
            label3.Text = "request_quantity";
            // 
            // textBox_requested_product
            // 
            textBox_requested_product.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_requested_product.Location = new Point(186, 86);
            textBox_requested_product.Name = "textBox_requested_product";
            textBox_requested_product.Size = new Size(287, 34);
            textBox_requested_product.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 229, 153);
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 17;
            label2.Text = "requested_product";
            // 
            // textBox_contact_email
            // 
            textBox_contact_email.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_contact_email.Location = new Point(186, 46);
            textBox_contact_email.Name = "textBox_contact_email";
            textBox_contact_email.Size = new Size(287, 34);
            textBox_contact_email.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 229, 153);
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 15;
            label1.Text = "contact_email";
            // 
            // textBox_customer_name
            // 
            textBox_customer_name.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_customer_name.Location = new Point(186, 6);
            textBox_customer_name.Name = "textBox_customer_name";
            textBox_customer_name.Size = new Size(287, 34);
            textBox_customer_name.TabIndex = 14;
            // 
            // label_customer_name
            // 
            label_customer_name.AutoSize = true;
            label_customer_name.BackColor = Color.FromArgb(255, 229, 153);
            label_customer_name.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_customer_name.Location = new Point(12, 11);
            label_customer_name.Name = "label_customer_name";
            label_customer_name.Size = new Size(120, 23);
            label_customer_name.TabIndex = 13;
            label_customer_name.Text = "customer_name";
            // 
            // dateTimePicker_request_date
            // 
            dateTimePicker_request_date.CalendarFont = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker_request_date.Location = new Point(186, 171);
            dateTimePicker_request_date.Name = "dateTimePicker_request_date";
            dateTimePicker_request_date.Size = new Size(286, 23);
            dateTimePicker_request_date.TabIndex = 26;
            // 
            // Form6_editOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 296);
            Controls.Add(dateTimePicker_request_date);
            Controls.Add(button_saveEdit);
            Controls.Add(textBox_order_number);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_request_quantity);
            Controls.Add(label3);
            Controls.Add(textBox_requested_product);
            Controls.Add(label2);
            Controls.Add(textBox_contact_email);
            Controls.Add(label1);
            Controls.Add(textBox_customer_name);
            Controls.Add(label_customer_name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6_editOrder";
            Text = "Form6_editOrder";
            Load += Form6_editOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_saveEdit;
        private TextBox textBox_order_number;
        private Label label5;
        private Label label4;
        private TextBox textBox_request_quantity;
        private Label label3;
        private TextBox textBox_requested_product;
        private Label label2;
        private TextBox textBox_contact_email;
        private Label label1;
        private TextBox textBox_customer_name;
        private Label label_customer_name;
        private DateTimePicker dateTimePicker_request_date;
    }
}