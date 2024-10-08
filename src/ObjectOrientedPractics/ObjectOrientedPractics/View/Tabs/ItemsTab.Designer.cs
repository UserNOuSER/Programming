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
            ItemsListBox = new ListBox();
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
            InfoTextBox = new TextBox();
            AddRandomButton = new Button();
            label1 = new Label();
            CategoryComboBox = new ComboBox();
            SuspendLayout();
            // 
            // ItemsLabel1
            // 
            ItemsLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsLabel1.Location = new Point(3, 7);
            ItemsLabel1.MaximumSize = new Size(44, 15);
            ItemsLabel1.MinimumSize = new Size(44, 15);
            ItemsLabel1.Name = "ItemsLabel1";
            ItemsLabel1.Size = new Size(44, 15);
            ItemsLabel1.TabIndex = 0;
            ItemsLabel1.Text = "ltems";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.DataSource = ItemsListBox.CustomTabOffsets;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 24);
            ItemsListBox.Margin = new Padding(3, 2, 3, 2);
            ItemsListBox.MaximumSize = new Size(229, 7500);
            ItemsListBox.MinimumSize = new Size(229, 4);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(229, 319);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.Click += ItemListBox_Click;
            ItemsListBox.SelectedIndexChanged += ItemListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(3, 345);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(67, 48);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(165, 345);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(67, 48);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedItemLabel.Location = new Point(240, 7);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(103, 15);
            SelectedItemLabel.TabIndex = 4;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // IDLabel
            // 
            IDLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IDLabel.Location = new Point(240, 27);
            IDLabel.MaximumSize = new Size(44, 15);
            IDLabel.MinimumSize = new Size(44, 15);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(44, 15);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            CostLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CostLabel.Location = new Point(240, 52);
            CostLabel.MaximumSize = new Size(44, 15);
            CostLabel.MinimumSize = new Size(44, 15);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(44, 15);
            CostLabel.TabIndex = 6;
            CostLabel.Text = "Cost:";
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IDTextBox.Location = new Point(301, 25);
            IDTextBox.Margin = new Padding(3, 2, 3, 2);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(316, 23);
            IDTextBox.TabIndex = 7;
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.Location = new Point(301, 50);
            CostTextBox.Margin = new Padding(3, 2, 3, 2);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(316, 23);
            CostTextBox.TabIndex = 8;
            // 
            // ItemsLabel2
            // 
            ItemsLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsLabel2.Location = new Point(240, 101);
            ItemsLabel2.MaximumSize = new Size(46, 15);
            ItemsLabel2.MinimumSize = new Size(46, 15);
            ItemsLabel2.Name = "ItemsLabel2";
            ItemsLabel2.Size = new Size(46, 15);
            ItemsLabel2.TabIndex = 9;
            ItemsLabel2.Text = "Name:";
            //
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(240, 118);
            NameTextBox.Margin = new Padding(3, 2, 3, 2);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(378, 92);
            NameTextBox.TabIndex = 10;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionLabel.Location = new Point(240, 211);
            DescriptionLabel.MaximumSize = new Size(77, 15);
            DescriptionLabel.MinimumSize = new Size(77, 15);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.RightToLeft = RightToLeft.No;
            DescriptionLabel.Size = new Size(77, 15);
            DescriptionLabel.TabIndex = 11;
            DescriptionLabel.Text = "Description:";
            // 
            // InfoTextBox
            // 
            InfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InfoTextBox.Location = new Point(242, 228);
            InfoTextBox.Margin = new Padding(3, 2, 3, 2);
            InfoTextBox.Multiline = true;
            InfoTextBox.Name = "InfoTextBox";
            InfoTextBox.Size = new Size(378, 113);
            InfoTextBox.TabIndex = 12;
            // 
            // AddRandomButton
            // 
            AddRandomButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddRandomButton.Location = new Point(76, 345);
            AddRandomButton.Name = "AddRandomButton";
            AddRandomButton.Size = new Size(83, 48);
            AddRandomButton.TabIndex = 13;
            AddRandomButton.Text = "AddRandom";
            AddRandomButton.UseVisualStyleBackColor = true;
            AddRandomButton.Click += AddRandomButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(240, 78);
            label1.MaximumSize = new Size(61, 17);
            label1.MinimumSize = new Size(61, 17);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 14;
            label1.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(301, 78);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(121, 23);
            CategoryComboBox.TabIndex = 15;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CategoryComboBox);
            Controls.Add(label1);
            Controls.Add(AddRandomButton);
            Controls.Add(InfoTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(ItemsLabel2);
            Controls.Add(CostTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(CostLabel);
            Controls.Add(IDLabel);
            Controls.Add(SelectedItemLabel);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(ItemsListBox);
            Controls.Add(ItemsLabel1);
            Controls.Add(NameTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ItemsTab";
            Size = new Size(620, 395);
            Load += ItemsTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ItemsLabel1;
        private ListBox ItemsListBox;
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
        private TextBox InfoTextBox;
        private Button AddRandomButton;
        private Label label1;
        private ComboBox CategoryComboBox;
    }
}
