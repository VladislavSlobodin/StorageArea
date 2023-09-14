namespace StorageArea
{
    partial class LoginForm
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
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SignInButton = new Button();
            SignUpButton = new Button();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.Location = new Point(118, 6);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(220, 32);
            LoginTextBox.TabIndex = 0;
            LoginTextBox.TextChanged += LoginTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(118, 44);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(220, 32);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 27);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(82, 27);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            label2.Click += label2_Click;
            // 
            // SignInButton
            // 
            SignInButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignInButton.Location = new Point(12, 82);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(100, 31);
            SignInButton.TabIndex = 4;
            SignInButton.Text = "Войти";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.Location = new Point(118, 82);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(220, 31);
            SignUpButton.TabIndex = 5;
            SignUpButton.Text = "Зарегистрироваться";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 125);
            Controls.Add(SignUpButton);
            Controls.Add(SignInButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name = "LoginForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private Button SignInButton;
        private Button SignUpButton;
    }
}