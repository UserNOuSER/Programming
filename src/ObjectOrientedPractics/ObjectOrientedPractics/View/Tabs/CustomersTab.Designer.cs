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
            AddRandomButton = new Button();
            SuspendLayout();
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersLabel.Location = new Point(3, 8);
            CustomersLabel.MaximumSize = new Size(74, 15);
            CustomersLabel.MinimumSize = new Size(74, 15);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(74, 15);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 25);
            CustomersListBox.Margin = new Padding(3, 2, 3, 2);
            CustomersListBox.MaximumSize = new Size(252, 7500000);
            CustomersListBox.MinimumSize = new Size(252, 4);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(252, 379);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.Click += CustomersListBox_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(3, 408);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.MaximumSize = new Size(123, 43);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(74, 43);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(181, 408);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.MaximumSize = new Size(123, 43);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(74, 43);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // SelectedCustomerLabel
            // 
            SelectedCustomerLabel.AutoSize = true;
            SelectedCustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerLabel.Location = new Point(261, 8);
            SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            SelectedCustomerLabel.Size = new Size(113, 15);
            SelectedCustomerLabel.TabIndex = 4;
            SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // IDLabel
            // 
            IDLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(261, 32);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(21, 15);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "ID:";
            // 
            // FullnameLabel
            // 
            FullnameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FullnameLabel.AutoSize = true;
            FullnameLabel.Location = new Point(261, 57);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(64, 15);
            FullnameLabel.TabIndex = 6;
            FullnameLabel.Text = "Full Name:";
            // 
            // AddressLabel
            // 
            AddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(261, 82);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(52, 15);
            AddressLabel.TabIndex = 7;
            AddressLabel.Text = "Address:";
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IDTextBox.Location = new Point(343, 30);
            IDTextBox.Margin = new Padding(3, 2, 3, 2);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(363, 23);
            IDTextBox.TabIndex = 8;
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBox.Location = new Point(343, 55);
            FullnameTextBox.Margin = new Padding(3, 2, 3, 2);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(363, 23);
            FullnameTextBox.TabIndex = 9;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(343, 80);
            AddressTextBox.Margin = new Padding(3, 2, 3, 2);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(363, 326);
            AddressTextBox.TabIndex = 10;
            // 
            // AddRandomButton
            // 
            AddRandomButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddRandomButton.Location = new Point(83, 408);
            AddRandomButton.Name = "AddRandomButton";
            AddRandomButton.Size = new Size(92, 43);
            AddRandomButton.TabIndex = 11;
            AddRandomButton.Text = "AddRandom";
            AddRandomButton.UseVisualStyleBackColor = true;
            AddRandomButton.Click += AddRandomButton_Click;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddRandomButton);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomersTab";
            Size = new Size(729, 454);
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
        private Button AddRandomButton;
    }
}
