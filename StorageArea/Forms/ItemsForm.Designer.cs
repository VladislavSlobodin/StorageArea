namespace StorageArea.Forms
{
    partial class ItemsForm
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
            panel1 = new Panel();
            EditPanel = new Panel();
            NewNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            EditItemTypeButton = new Button();
            EditComboBox = new ComboBox();
            EditButton = new Button();
            ViewPanel = new Panel();
            CloseViewButton = new Button();
            ViewButton = new Button();
            DeletePanel = new Panel();
            DeleteItemButton = new Button();
            DeleteComboBox = new ComboBox();
            DeleteButton = new Button();
            AddPanel = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            WeightTextBox = new TextBox();
            VolumeTextBox = new TextBox();
            TypeComboBox = new ComboBox();
            ContainerComboBox = new ComboBox();
            label4 = new Label();
            CountTextBox = new TextBox();
            label1 = new Label();
            AddContainerButton = new Button();
            NameTextBox = new TextBox();
            AddButton = new Button();
            MainPanel = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            EditPanel.SuspendLayout();
            ViewPanel.SuspendLayout();
            DeletePanel.SuspendLayout();
            AddPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(EditPanel);
            panel1.Controls.Add(EditButton);
            panel1.Controls.Add(ViewPanel);
            panel1.Controls.Add(ViewButton);
            panel1.Controls.Add(DeletePanel);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(AddPanel);
            panel1.Controls.Add(AddButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 738);
            panel1.TabIndex = 9;
            // 
            // EditPanel
            // 
            EditPanel.Controls.Add(NewNameTextBox);
            EditPanel.Controls.Add(label3);
            EditPanel.Controls.Add(label2);
            EditPanel.Controls.Add(EditItemTypeButton);
            EditPanel.Controls.Add(EditComboBox);
            EditPanel.Dock = DockStyle.Top;
            EditPanel.Location = new Point(0, 621);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(198, 100);
            EditPanel.TabIndex = 15;
            EditPanel.Visible = false;
            // 
            // NewNameTextBox
            // 
            NewNameTextBox.Location = new Point(79, 34);
            NewNameTextBox.Name = "NewNameTextBox";
            NewNameTextBox.Size = new Size(121, 23);
            NewNameTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(57, 30);
            label3.TabIndex = 6;
            label3.Text = "Новое\r\nназвание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Название";
            // 
            // EditItemTypeButton
            // 
            EditItemTypeButton.Location = new Point(79, 63);
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
            EditComboBox.Location = new Point(79, 6);
            EditComboBox.Name = "EditComboBox";
            EditComboBox.Size = new Size(121, 23);
            EditComboBox.TabIndex = 0;
            // 
            // EditButton
            // 
            EditButton.Dock = DockStyle.Top;
            EditButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(0, 571);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(198, 50);
            EditButton.TabIndex = 14;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ViewPanel
            // 
            ViewPanel.Controls.Add(CloseViewButton);
            ViewPanel.Dock = DockStyle.Top;
            ViewPanel.Location = new Point(0, 471);
            ViewPanel.Name = "ViewPanel";
            ViewPanel.Size = new Size(198, 100);
            ViewPanel.TabIndex = 13;
            ViewPanel.Visible = false;
            // 
            // CloseViewButton
            // 
            CloseViewButton.Dock = DockStyle.Fill;
            CloseViewButton.Location = new Point(0, 0);
            CloseViewButton.Name = "CloseViewButton";
            CloseViewButton.Size = new Size(198, 100);
            CloseViewButton.TabIndex = 1;
            CloseViewButton.Text = "Закрыть";
            CloseViewButton.UseVisualStyleBackColor = true;
            CloseViewButton.Click += CloseViewButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.Dock = DockStyle.Top;
            ViewButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ViewButton.Location = new Point(0, 421);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(198, 50);
            ViewButton.TabIndex = 11;
            ViewButton.Text = "Просмотреть";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // DeletePanel
            // 
            DeletePanel.Controls.Add(DeleteItemButton);
            DeletePanel.Controls.Add(DeleteComboBox);
            DeletePanel.Dock = DockStyle.Top;
            DeletePanel.Location = new Point(0, 321);
            DeletePanel.Name = "DeletePanel";
            DeletePanel.Size = new Size(198, 100);
            DeletePanel.TabIndex = 10;
            DeletePanel.Visible = false;
            // 
            // DeleteItemButton
            // 
            DeleteItemButton.Dock = DockStyle.Fill;
            DeleteItemButton.Location = new Point(0, 23);
            DeleteItemButton.Name = "DeleteItemButton";
            DeleteItemButton.Size = new Size(198, 77);
            DeleteItemButton.TabIndex = 2;
            DeleteItemButton.Text = "Удалить";
            DeleteItemButton.UseVisualStyleBackColor = true;
            DeleteItemButton.Click += DeleteItemButton_Click;
            // 
            // DeleteComboBox
            // 
            DeleteComboBox.Dock = DockStyle.Top;
            DeleteComboBox.FormattingEnabled = true;
            DeleteComboBox.Location = new Point(0, 0);
            DeleteComboBox.Name = "DeleteComboBox";
            DeleteComboBox.Size = new Size(198, 23);
            DeleteComboBox.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Top;
            DeleteButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(0, 271);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(198, 50);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddPanel
            // 
            AddPanel.BorderStyle = BorderStyle.FixedSingle;
            AddPanel.Controls.Add(label9);
            AddPanel.Controls.Add(label8);
            AddPanel.Controls.Add(label7);
            AddPanel.Controls.Add(label6);
            AddPanel.Controls.Add(WeightTextBox);
            AddPanel.Controls.Add(VolumeTextBox);
            AddPanel.Controls.Add(TypeComboBox);
            AddPanel.Controls.Add(ContainerComboBox);
            AddPanel.Controls.Add(label4);
            AddPanel.Controls.Add(CountTextBox);
            AddPanel.Controls.Add(label1);
            AddPanel.Controls.Add(AddContainerButton);
            AddPanel.Controls.Add(NameTextBox);
            AddPanel.Dock = DockStyle.Top;
            AddPanel.Location = new Point(0, 50);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(198, 221);
            AddPanel.TabIndex = 6;
            AddPanel.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 153);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 14;
            label9.Text = "Масса, кг";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 124);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 13;
            label8.Text = "Объем, м^3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 95);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 12;
            label7.Text = "Тип";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 67);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 11;
            label6.Text = "Контейнер";
            // 
            // WeightTextBox
            // 
            WeightTextBox.Location = new Point(91, 150);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(103, 23);
            WeightTextBox.TabIndex = 10;
            // 
            // VolumeTextBox
            // 
            VolumeTextBox.Location = new Point(91, 121);
            VolumeTextBox.Name = "VolumeTextBox";
            VolumeTextBox.Size = new Size(103, 23);
            VolumeTextBox.TabIndex = 9;
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Location = new Point(91, 92);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(103, 23);
            TypeComboBox.TabIndex = 8;
            // 
            // ContainerComboBox
            // 
            ContainerComboBox.FormattingEnabled = true;
            ContainerComboBox.Location = new Point(91, 64);
            ContainerComboBox.Name = "ContainerComboBox";
            ContainerComboBox.Size = new Size(103, 23);
            ContainerComboBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 38);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Количество";
            // 
            // CountTextBox
            // 
            CountTextBox.Location = new Point(91, 35);
            CountTextBox.Name = "CountTextBox";
            CountTextBox.Size = new Size(103, 23);
            CountTextBox.TabIndex = 5;
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
            AddContainerButton.Location = new Point(63, 179);
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
            NameTextBox.Size = new Size(103, 23);
            NameTextBox.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Top;
            AddButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(0, 0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(198, 50);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(200, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(855, 738);
            MainPanel.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(855, 738);
            dataGridView1.TabIndex = 0;
            dataGridView1.Visible = false;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 738);
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "ItemsForm";
            Text = "Предметы";
            panel1.ResumeLayout(false);
            EditPanel.ResumeLayout(false);
            EditPanel.PerformLayout();
            ViewPanel.ResumeLayout(false);
            DeletePanel.ResumeLayout(false);
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddButton;
        private Panel MainPanel;
        private Panel AddPanel;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox WeightTextBox;
        private TextBox VolumeTextBox;
        private ComboBox TypeComboBox;
        private ComboBox ContainerComboBox;
        private Label label4;
        private TextBox CountTextBox;
        private Label label1;
        private Button AddContainerButton;
        private TextBox NameTextBox;
        private Panel EditPanel;
        private TextBox NewNameTextBox;
        private Label label3;
        private Label label2;
        private Button EditItemTypeButton;
        private ComboBox EditComboBox;
        private Button EditButton;
        private Panel ViewPanel;
        private Button ViewButton;
        private Panel DeletePanel;
        private Button CloseViewButton;
        private Button DeleteItemButton;
        private ComboBox DeleteComboBox;
        private Button DeleteButton;
        private DataGridView dataGridView1;
    }
}