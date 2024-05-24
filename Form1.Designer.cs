namespace QualExam_Bingo_Bongo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_login = new Label();
            label_password = new Label();
            pictureBox1 = new PictureBox();
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            button_auth = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_login
            // 
            label_login.BackColor = Color.FromArgb(255, 229, 153);
            label_login.BorderStyle = BorderStyle.FixedSingle;
            label_login.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_login.Location = new Point(4, 134);
            label_login.Name = "label_login";
            label_login.Size = new Size(100, 30);
            label_login.TabIndex = 0;
            label_login.Text = "Логин";
            // 
            // label_password
            // 
            label_password.BackColor = Color.FromArgb(255, 229, 153);
            label_password.BorderStyle = BorderStyle.FixedSingle;
            label_password.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_password.Location = new Point(4, 167);
            label_password.Name = "label_password";
            label_password.Size = new Size(229, 30);
            label_password.TabIndex = 1;
            label_password.Text = "Пароль";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 229, 153);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox_login
            // 
            textBox_login.BackColor = SystemColors.Window;
            textBox_login.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_login.Location = new Point(79, 134);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(154, 30);
            textBox_login.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = SystemColors.Window;
            textBox_password.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_password.Location = new Point(79, 167);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(154, 30);
            textBox_password.TabIndex = 4;
            // 
            // button_auth
            // 
            button_auth.BackColor = Color.FromArgb(255, 124, 128);
            button_auth.FlatStyle = FlatStyle.Flat;
            button_auth.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_auth.Location = new Point(4, 202);
            button_auth.Name = "button_auth";
            button_auth.Size = new Size(229, 32);
            button_auth.TabIndex = 5;
            button_auth.Text = "Войти";
            button_auth.UseVisualStyleBackColor = false;
            button_auth.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 244);
            Controls.Add(button_auth);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Controls.Add(pictureBox1);
            Controls.Add(label_password);
            Controls.Add(label_login);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_login;
        private Label label_password;
        private PictureBox pictureBox1;
        private TextBox textBox_login;
        private TextBox textBox_password;
        private Button button_auth;
    }
}
