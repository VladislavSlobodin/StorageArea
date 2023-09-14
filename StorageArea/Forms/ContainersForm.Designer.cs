namespace StorageArea.Forms
{
    partial class ContainersForm
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
            CloseViewButton = new Button();
            DeleteContainerButton = new Button();
            DeleteComboBox = new ComboBox();
            DeletePanel = new Panel();
            NewNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            EditItemTypeButton = new Button();
            EditComboBox = new ComboBox();
            EditPanel = new Panel();
            MainPanel = new Panel();
            ViewPanel = new Panel();
            ViewComboBox = new ComboBox();
            AddPanel = new Panel();
            label4 = new Label();
            VolumeTextBox = new TextBox();
            label1 = new Label();
            AddContainerButton = new Button();
            NameTextBox = new TextBox();
            EditButton = new Button();
            ViewButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            panel1 = new Panel();
            label5 = new Label();
            DeletePanel.SuspendLayout();
            EditPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            ViewPanel.SuspendLayout();
            AddPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CloseViewButton
            // 
            CloseViewButton.Location = new Point(127, 64);
            CloseViewButton.Name = "CloseViewButton";
            CloseViewButton.Size = new Size(75, 23);
            CloseViewButton.TabIndex = 1;
            CloseViewButton.Text = "Закрыть";
            CloseViewButton.UseVisualStyleBackColor = true;
            CloseViewButton.Click += CloseViewButton_Click;
            // 
            // DeleteContainerButton
            // 
            DeleteContainerButton.Location = new Point(45, 44);
            DeleteContainerButton.Name = "DeleteContainerButton";
            DeleteContainerButton.Size = new Size(75, 23);
            DeleteContainerButton.TabIndex = 2;
            DeleteContainerButton.Text = "Удалить";
            DeleteContainerButton.UseVisualStyleBackColor = true;
            DeleteContainerButton.Click += DeleteContainerButton_Click;
            // 
            // DeleteComboBox
            // 
            DeleteComboBox.FormattingEnabled = true;
            DeleteComboBox.Location = new Point(23, 15);
            DeleteComboBox.Name = "DeleteComboBox";
            DeleteComboBox.Size = new Size(121, 23);
            DeleteComboBox.TabIndex = 1;
            // 
            // DeletePanel
            // 
            DeletePanel.Controls.Add(DeleteContainerButton);
            DeletePanel.Controls.Add(DeleteComboBox);
            DeletePanel.Location = new Point(0, 0);
            DeletePanel.Name = "DeletePanel";
            DeletePanel.Size = new Size(300, 100);
            DeletePanel.TabIndex = 7;
            DeletePanel.Visible = false;
            // 
            // NewNameTextBox
            // 
            NewNameTextBox.Location = new Point(110, 31);
            NewNameTextBox.Name = "NewNameTextBox";
            NewNameTextBox.Size = new Size(121, 23);
            NewNameTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 34);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Новое название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 9);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Название";
            // 
            // EditItemTypeButton
            // 
            EditItemTypeButton.Location = new Point(131, 60);
            EditItemTypeButton.Name = "EditItemTypeButton";
            EditItemTypeButton.Size = new Size(75, 23);
            EditItemTypeButton.TabIndex = 1;
            EditItemTypeButton.Text = "Изменить";
            EditItemTypeButton.UseVisualStyleBackColor = true;
            EditItemTypeButton.Click += EditItemTypeButton_Click;
            // 
            // EditComboBox
            // 
            EditComboBox.FormattingEnabled = true;
            EditComboBox.Location = new Point(110, 6);
            EditComboBox.Name = "EditComboBox";
            EditComboBox.Size = new Size(121, 23);
            EditComboBox.TabIndex = 0;
            // 
            // EditPanel
            // 
            EditPanel.Controls.Add(NewNameTextBox);
            EditPanel.Controls.Add(label3);
            EditPanel.Controls.Add(label2);
            EditPanel.Controls.Add(EditItemTypeButton);
            EditPanel.Controls.Add(EditComboBox);
            EditPanel.Location = new Point(0, 0);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(300, 100);
            EditPanel.TabIndex = 7;
            EditPanel.Visible = false;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(EditPanel);
            MainPanel.Controls.Add(DeletePanel);
            MainPanel.Controls.Add(ViewPanel);
            MainPanel.Controls.Add(AddPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(200, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(600, 450);
            MainPanel.TabIndex = 8;
            // 
            // ViewPanel
            // 
            ViewPanel.Controls.Add(label5);
            ViewPanel.Controls.Add(CloseViewButton);
            ViewPanel.Controls.Add(ViewComboBox);
            ViewPanel.Location = new Point(0, 0);
            ViewPanel.Name = "ViewPanel";
            ViewPanel.Size = new Size(300, 100);
            ViewPanel.TabIndex = 6;
            ViewPanel.Visible = false;
            // 
            // ViewComboBox
            // 
            ViewComboBox.FormattingEnabled = true;
            ViewComboBox.Location = new Point(23, 35);
            ViewComboBox.Name = "ViewComboBox";
            ViewComboBox.Size = new Size(271, 23);
            ViewComboBox.TabIndex = 0;
            // 
            // AddPanel
            // 
            AddPanel.Controls.Add(label4);
            AddPanel.Controls.Add(VolumeTextBox);
            AddPanel.Controls.Add(label1);
            AddPanel.Controls.Add(AddContainerButton);
            AddPanel.Controls.Add(NameTextBox);
            AddPanel.Location = new Point(0, 0);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(300, 100);
            AddPanel.TabIndex = 5;
            AddPanel.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 38);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 6;
            label4.Text = "Объем (м^3)";
            // 
            // VolumeTextBox
            // 
            VolumeTextBox.Location = new Point(91, 35);
            VolumeTextBox.Name = "VolumeTextBox";
            VolumeTextBox.Size = new Size(121, 23);
            VolumeTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // AddContainerButton
            // 
            AddContainerButton.Location = new Point(116, 64);
            AddContainerButton.Name = "AddContainerButton";
            AddContainerButton.Size = new Size(75, 23);
            AddContainerButton.TabIndex = 4;
            AddContainerButton.Text = "Добавить";
            AddContainerButton.UseVisualStyleBackColor = true;
            AddContainerButton.Click += AddContainerButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(91, 6);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(121, 23);
            NameTextBox.TabIndex = 2;
            // 
            // EditButton
            // 
            EditButton.Dock = DockStyle.Top;
            EditButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(0, 150);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(200, 50);
            EditButton.TabIndex = 4;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.Dock = DockStyle.Top;
            ViewButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ViewButton.Location = new Point(0, 100);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(200, 50);
            ViewButton.TabIndex = 3;
            ViewButton.Text = "Просмотреть";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Top;
            DeleteButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(0, 50);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(200, 50);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Top;
            AddButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(0, 0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(200, 50);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(EditButton);
            panel1.Controls.Add(ViewButton);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(AddButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 14);
            label5.Name = "label5";
            label5.Size = new Size(210, 15);
            label5.TabIndex = 2;
            label5.Text = "Название | Свободно | Занято | Всего";
            // 
            // ContainersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "ContainersForm";
            Text = "Контейнеры";
            DeletePanel.ResumeLayout(false);
            EditPanel.ResumeLayout(false);
            EditPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            ViewPanel.ResumeLayout(false);
            ViewPanel.PerformLayout();
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CloseViewButton;
        private Button DeleteContainerButton;
        private ComboBox DeleteComboBox;
        private Panel DeletePanel;
        private TextBox NewNameTextBox;
        private Label label3;
        private Label label2;
        private Button EditItemTypeButton;
        private ComboBox EditComboBox;
        private Panel EditPanel;
        private Panel MainPanel;
        private Panel ViewPanel;
        private ComboBox ViewComboBox;
        private Panel AddPanel;
        private Label label1;
        private Button AddContainerButton;
        private TextBox NameTextBox;
        private Button EditButton;
        private Button ViewButton;
        private Button DeleteButton;
        private Button AddButton;
        private Panel panel1;
        private Label label4;
        private TextBox VolumeTextBox;
        private Label label5;
    }
}