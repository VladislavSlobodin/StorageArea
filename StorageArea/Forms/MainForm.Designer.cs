namespace StorageArea
{
    partial class MainForm
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
            panel1 = new Panel();
            ItemTypesButton = new Button();
            ContainersButton = new Button();
            ItemsButton = new Button();
            panel4 = new Panel();
            GreetingsLabel = new Label();
            panel3 = new Panel();
            LogoLabel = new Label();
            FormPanel = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ItemTypesButton);
            panel1.Controls.Add(ContainersButton);
            panel1.Controls.Add(ItemsButton);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // ItemTypesButton
            // 
            ItemTypesButton.Dock = DockStyle.Top;
            ItemTypesButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemTypesButton.Location = new Point(0, 200);
            ItemTypesButton.Name = "ItemTypesButton";
            ItemTypesButton.Size = new Size(198, 50);
            ItemTypesButton.TabIndex = 3;
            ItemTypesButton.Text = "Категории предметов";
            ItemTypesButton.UseVisualStyleBackColor = true;
            ItemTypesButton.Click += ItemTypesButton_Click;
            // 
            // ContainersButton
            // 
            ContainersButton.Dock = DockStyle.Top;
            ContainersButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContainersButton.Location = new Point(0, 150);
            ContainersButton.Name = "ContainersButton";
            ContainersButton.Size = new Size(198, 50);
            ContainersButton.TabIndex = 2;
            ContainersButton.Text = "Контейнеры";
            ContainersButton.UseVisualStyleBackColor = true;
            ContainersButton.Click += ContainersButton_Click;
            // 
            // ItemsButton
            // 
            ItemsButton.Dock = DockStyle.Top;
            ItemsButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsButton.Location = new Point(0, 100);
            ItemsButton.Name = "ItemsButton";
            ItemsButton.Size = new Size(198, 50);
            ItemsButton.TabIndex = 1;
            ItemsButton.Text = "Предметы";
            ItemsButton.UseVisualStyleBackColor = true;
            ItemsButton.Click += ItemsButton_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(GreetingsLabel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(198, 100);
            panel4.TabIndex = 0;
            panel4.DoubleClick += panel4_DoubleClick;
            // 
            // GreetingsLabel
            // 
            GreetingsLabel.AutoSize = true;
            GreetingsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            GreetingsLabel.Location = new Point(3, 3);
            GreetingsLabel.Name = "GreetingsLabel";
            GreetingsLabel.Size = new Size(225, 25);
            GreetingsLabel.TabIndex = 1;
            GreetingsLabel.Text = "Здравствуй, {User.Login}!";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(LogoLabel);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 100);
            panel3.TabIndex = 2;
            // 
            // LogoLabel
            // 
            LogoLabel.AutoSize = true;
            LogoLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LogoLabel.Location = new Point(214, 37);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(0, 29);
            LogoLabel.TabIndex = 0;
            LogoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPanel
            // 
            FormPanel.Dock = DockStyle.Fill;
            FormPanel.Location = new Point(200, 100);
            FormPanel.Name = "FormPanel";
            FormPanel.Size = new Size(600, 350);
            FormPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FormPanel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label GreetingsLabel;
        private Panel panel3;
        private Button ItemTypesButton;
        private Button ContainersButton;
        private Button ItemsButton;
        private Label LogoLabel;
        private Panel FormPanel;
    }
}