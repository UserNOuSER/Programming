namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ItemsLabel1 = new Label();
            ItemListBox = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            SelectedItemLabel = new Label();
            IDLabel = new Label();
            CostLabel = new Label();
            IDTextBox = new TextBox();
            CostTextBox = new TextBox();
            ItemsLabel2 = new Label();
            NameTextBox = new TextBox();
            DescriptionLabel = new Label();
            DescriptionTextBox = new TextBox();
            SuspendLayout();
            // 
            // ItemsLabel1
            // 
            ItemsLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsLabel1.Location = new Point(3, 9);
            ItemsLabel1.MaximumSize = new Size(50, 20);
            ItemsLabel1.MinimumSize = new Size(50, 20);
            ItemsLabel1.Name = "ItemsLabel1";
            ItemsLabel1.Size = new Size(50, 20);
            ItemsLabel1.TabIndex = 0;
            ItemsLabel1.Text = "ltems";
            ItemsLabel1.Click += label1_Click_1;
            // 
            // ItemListBox
            // 
            ItemListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemListBox.FormattingEnabled = true;
            ItemListBox.Location = new Point(3, 32);
            ItemListBox.MaximumSize = new Size(261, 9999);
            ItemListBox.MinimumSize = new Size(261, 0);
            ItemListBox.Name = "ItemListBox";
            ItemListBox.Size = new Size(261, 464);
            ItemListBox.TabIndex = 1;
            ItemListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(3, 502);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(124, 64);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(140, 502);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(124, 64);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedItemLabel.Location = new Point(274, 9);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(118, 20);
            SelectedItemLabel.TabIndex = 4;
            SelectedItemLabel.Text = "Selected Item";
            SelectedItemLabel.Click += label2_Click_1;
            // 
            // IDLabel
            // 
            IDLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IDLabel.Location = new Point(274, 36);
            IDLabel.MaximumSize = new Size(50, 20);
            IDLabel.MinimumSize = new Size(50, 20);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(50, 20);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            CostLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CostLabel.Location = new Point(274, 70);
            CostLabel.MaximumSize = new Size(50, 20);
            CostLabel.MinimumSize = new Size(50, 20);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(50, 20);
            CostLabel.TabIndex = 6;
            CostLabel.Text = "Cost:";
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IDTextBox.Location = new Point(344, 33);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(499, 27);
            IDTextBox.TabIndex = 7;
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.Location = new Point(344, 67);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(499, 27);
            CostTextBox.TabIndex = 8;
            // 
            // ItemsLabel2
            // 
            ItemsLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsLabel2.Location = new Point(274, 106);
            ItemsLabel2.MaximumSize = new Size(52, 20);
            ItemsLabel2.MinimumSize = new Size(52, 20);
            ItemsLabel2.Name = "ItemsLabel2";
            ItemsLabel2.Size = new Size(52, 20);
            ItemsLabel2.TabIndex = 9;
            ItemsLabel2.Text = "Name:";
            ItemsLabel2.Click += label5_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(274, 129);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(569, 149);
            NameTextBox.TabIndex = 10;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionLabel.Location = new Point(274, 281);
            DescriptionLabel.MaximumSize = new Size(88, 20);
            DescriptionLabel.MinimumSize = new Size(88, 20);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.RightToLeft = RightToLeft.No;
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 11;
            DescriptionLabel.Text = "Description:";
            DescriptionLabel.Click += label6_Click;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(274, 304);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(569, 192);
            DescriptionTextBox.TabIndex = 12;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DescriptionTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(ItemsLabel2);
            Controls.Add(CostTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(CostLabel);
            Controls.Add(IDLabel);
            Controls.Add(SelectedItemLabel);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(ItemListBox);
            Controls.Add(ItemsLabel1);
            Controls.Add(NameTextBox);
            Name = "ItemsTab";
            Size = new Size(846, 566);
            Load += ItemsTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ItemsLabel1;
        private ListBox ItemListBox;
        private Button AddButton;
        private Button RemoveButton;
        private Label SelectedItemLabel;
        private Label IDLabel;
        private Label CostLabel;
        private TextBox IDTextBox;
        private TextBox CostTextBox;
        private Label ItemsLabel2;
        private TextBox NameTextBox;
        private Label DescriptionLabel;
        private TextBox DescriptionTextBox;
    }
}
