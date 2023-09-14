namespace StorageArea
{
    partial class RegistrationForm
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
            SignUpButton = new Button();
            label2 = new Label();
            label1 = new Label();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            label3 = new Label();
            ConfirmTextBox = new TextBox();
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.Location = new Point(12, 120);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(326, 31);
            SignUpButton.TabIndex = 11;
            SignUpButton.Text = "Зарегистрироваться";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(82, 27);
            label2.TabIndex = 9;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 27);
            label1.TabIndex = 8;
            label1.Text = "Логин";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(118, 44);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(220, 32);
            PasswordTextBox.TabIndex = 7;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.Location = new Point(118, 6);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(220, 32);
            LoginTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(80, 27);
            label3.TabIndex = 12;
            label3.Text = "Повтор";
            // 
            // ConfirmTextBox
            // 
            ConfirmTextBox.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmTextBox.Location = new Point(118, 82);
            ConfirmTextBox.Name = "ConfirmTextBox";
            ConfirmTextBox.Size = new Size(220, 32);
            ConfirmTextBox.TabIndex = 13;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 159);
            Controls.Add(ConfirmTextBox);
            Controls.Add(label3);
            Controls.Add(SignUpButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name = "RegistrationForm";
            Text = "Регистрация";
            FormClosed += RegistrationForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignUpButton;
        private Label label2;
        private Label label1;
        private TextBox PasswordTextBox;
        private TextBox LoginTextBox;
        private Label label3;
        private TextBox ConfirmTextBox;
    }
}