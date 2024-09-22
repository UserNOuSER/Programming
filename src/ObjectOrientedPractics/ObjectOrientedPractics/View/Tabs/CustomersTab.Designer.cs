namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            CustomersLabel = new Label();
            CustomersListBox = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            SelectedCustomerLabel = new Label();
            IDLabel = new Label();
            FullnameLabel = new Label();
            AddressLabel = new Label();
            IDTextBox = new TextBox();
            FullnameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            SuspendLayout();
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersLabel.Location = new Point(3, 10);
            CustomersLabel.MaximumSize = new Size(84, 20);
            CustomersLabel.MinimumSize = new Size(84, 20);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(84, 20);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Customers";
            CustomersLabel.Click += label1_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(3, 33);
            CustomersListBox.MaximumSize = new Size(288, 9999999);
            CustomersListBox.MinimumSize = new Size(288, 0);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(288, 484);
            CustomersListBox.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(3, 523);
            AddButton.MaximumSize = new Size(141, 57);
            AddButton.MinimumSize = new Size(141, 57);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(141, 57);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(150, 523);
            RemoveButton.MaximumSize = new Size(141, 57);
            RemoveButton.MinimumSize = new Size(141, 57);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(141, 57);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // SelectedCustomerLabel
            // 
            SelectedCustomerLabel.AutoSize = true;
            SelectedCustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerLabel.Location = new Point(298, 10);
            SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            SelectedCustomerLabel.Size = new Size(139, 20);
            SelectedCustomerLabel.TabIndex = 4;
            SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // IDLabel
            // 
            IDLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(298, 43);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 20);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "ID:";
            // 
            // FullnameLabel
            // 
            FullnameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FullnameLabel.AutoSize = true;
            FullnameLabel.Location = new Point(298, 76);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(79, 20);
            FullnameLabel.TabIndex = 6;
            FullnameLabel.Text = "Full Name:";
            // 
            // AddressLabel
            // 
            AddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(298, 109);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(65, 20);
            AddressLabel.TabIndex = 7;
            AddressLabel.Text = "Address:";
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IDTextBox.Location = new Point(392, 40);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(347, 27);
            IDTextBox.TabIndex = 8;
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBox.Location = new Point(392, 73);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(347, 27);
            FullnameTextBox.TabIndex = 9;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(392, 106);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(347, 411);
            AddressTextBox.TabIndex = 10;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressTextBox);
            Controls.Add(FullnameTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(AddressLabel);
            Controls.Add(FullnameLabel);
            Controls.Add(IDLabel);
            Controls.Add(SelectedCustomerLabel);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(CustomersListBox);
            Controls.Add(CustomersLabel);
            Name = "CustomersTab";
            Size = new Size(766, 583);
            Load += CustomersTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CustomersLabel;
        private ListBox CustomersListBox;
        private Button AddButton;
        private Button RemoveButton;
        private Label SelectedCustomerLabel;
        private Label IDLabel;
        private Label FullnameLabel;
        private Label AddressLabel;
        private TextBox IDTextBox;
        private TextBox FullnameTextBox;
        private TextBox AddressTextBox;
    }
}
