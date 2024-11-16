using ObjectOrientedPractics.View.Tabs.Controls;

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
            FullnameLabel = new Label();
            IDTextBox = new TextBox();
            FullnameTextBox = new TextBox();
            AddRandomButton = new Button();
            AddressControl1 = new AddressControl();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            splitContainer5 = new SplitContainer();
            splitContainer6 = new SplitContainer();
            splitContainer7 = new SplitContainer();
            splitContainer8 = new SplitContainer();
            splitContainer9 = new SplitContainer();
            IDLabel = new Label();
            splitContainer10 = new SplitContainer();
            splitContainer11 = new SplitContainer();
            PriorityCheckBox = new CheckBox();
            splitContainer12 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer8).BeginInit();
            splitContainer8.Panel1.SuspendLayout();
            splitContainer8.Panel2.SuspendLayout();
            splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer9).BeginInit();
            splitContainer9.Panel1.SuspendLayout();
            splitContainer9.Panel2.SuspendLayout();
            splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer10).BeginInit();
            splitContainer10.Panel1.SuspendLayout();
            splitContainer10.Panel2.SuspendLayout();
            splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer11).BeginInit();
            splitContainer11.Panel1.SuspendLayout();
            splitContainer11.Panel2.SuspendLayout();
            splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer12).BeginInit();
            splitContainer12.Panel1.SuspendLayout();
            splitContainer12.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Dock = DockStyle.Fill;
            CustomersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersLabel.Location = new Point(0, 0);
            CustomersLabel.MaximumSize = new Size(85, 20);
            CustomersLabel.MinimumSize = new Size(85, 20);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(85, 20);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            CustomersListBox.Dock = DockStyle.Fill;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(0, 0);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(311, 474);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.Click += CustomersListBox_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.Dock = DockStyle.Fill;
            AddButton.ImageAlign = ContentAlignment.MiddleRight;
            AddButton.Location = new Point(0, 0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 71);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.AutoSize = true;
            RemoveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(0, 0);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(105, 71);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // SelectedCustomerLabel
            // 
            SelectedCustomerLabel.AutoSize = true;
            SelectedCustomerLabel.Dock = DockStyle.Fill;
            SelectedCustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerLabel.Location = new Point(0, 0);
            SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            SelectedCustomerLabel.Size = new Size(139, 20);
            SelectedCustomerLabel.TabIndex = 4;
            SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // FullnameLabel
            // 
            FullnameLabel.AutoSize = true;
            FullnameLabel.Dock = DockStyle.Fill;
            FullnameLabel.Location = new Point(0, 0);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(79, 20);
            FullnameLabel.TabIndex = 6;
            FullnameLabel.Text = "Full Name:";
            // 
            // IDTextBox
            // 
            IDTextBox.Dock = DockStyle.Fill;
            IDTextBox.Location = new Point(0, 0);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(545, 27);
            IDTextBox.TabIndex = 8;
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Dock = DockStyle.Fill;
            FullnameTextBox.Location = new Point(0, 0);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(410, 27);
            FullnameTextBox.TabIndex = 9;
            // 
            // AddRandomButton
            // 
            AddRandomButton.AutoSize = true;
            AddRandomButton.Dock = DockStyle.Fill;
            AddRandomButton.Location = new Point(0, 0);
            AddRandomButton.Margin = new Padding(3, 4, 3, 4);
            AddRandomButton.Name = "AddRandomButton";
            AddRandomButton.Size = new Size(98, 71);
            AddRandomButton.TabIndex = 11;
            AddRandomButton.Text = "AddRandom";
            AddRandomButton.UseVisualStyleBackColor = true;
            AddRandomButton.Click += AddRandomButton_Click;
            // 
            // AddressControl1
            // 
            AddressControl1.Dock = DockStyle.Fill;
            AddressControl1.Location = new Point(0, 0);
            AddressControl1.Margin = new Padding(3, 4, 3, 4);
            AddressControl1.MinimumSize = new Size(0, 200);
            AddressControl1.Name = "AddressControl1";
            AddressControl1.Size = new Size(619, 213);
            AddressControl1.TabIndex = 12;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer6);
            splitContainer1.Size = new Size(934, 585);
            splitContainer1.SplitterDistance = 311;
            splitContainer1.TabIndex = 13;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(CustomersLabel);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(311, 585);
            splitContainer2.SplitterDistance = 32;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(CustomersListBox);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(311, 549);
            splitContainer3.SplitterDistance = 474;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(AddButton);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(splitContainer5);
            splitContainer4.Size = new Size(311, 71);
            splitContainer4.SplitterDistance = 100;
            splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(AddRandomButton);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(RemoveButton);
            splitContainer5.Size = new Size(207, 71);
            splitContainer5.SplitterDistance = 98;
            splitContainer5.TabIndex = 0;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.Location = new Point(0, 0);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(splitContainer7);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(splitContainer12);
            splitContainer6.Size = new Size(619, 585);
            splitContainer6.SplitterDistance = 125;
            splitContainer6.TabIndex = 13;
            // 
            // splitContainer7
            // 
            splitContainer7.Dock = DockStyle.Fill;
            splitContainer7.Location = new Point(0, 0);
            splitContainer7.Name = "splitContainer7";
            splitContainer7.Orientation = Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(SelectedCustomerLabel);
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.Controls.Add(splitContainer8);
            splitContainer7.Size = new Size(619, 125);
            splitContainer7.SplitterDistance = 28;
            splitContainer7.TabIndex = 0;
            // 
            // splitContainer8
            // 
            splitContainer8.Dock = DockStyle.Fill;
            splitContainer8.Location = new Point(0, 0);
            splitContainer8.Name = "splitContainer8";
            splitContainer8.Orientation = Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            splitContainer8.Panel1.Controls.Add(splitContainer9);
            // 
            // splitContainer8.Panel2
            // 
            splitContainer8.Panel2.Controls.Add(splitContainer10);
            splitContainer8.Size = new Size(619, 93);
            splitContainer8.SplitterDistance = 25;
            splitContainer8.TabIndex = 0;
            // 
            // splitContainer9
            // 
            splitContainer9.Dock = DockStyle.Fill;
            splitContainer9.Location = new Point(0, 0);
            splitContainer9.Name = "splitContainer9";
            // 
            // splitContainer9.Panel1
            // 
            splitContainer9.Panel1.Controls.Add(IDLabel);
            // 
            // splitContainer9.Panel2
            // 
            splitContainer9.Panel2.Controls.Add(IDTextBox);
            splitContainer9.Size = new Size(619, 25);
            splitContainer9.SplitterDistance = 70;
            splitContainer9.TabIndex = 0;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Dock = DockStyle.Fill;
            IDLabel.Location = new Point(0, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 20);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "ID:";
            // 
            // splitContainer10
            // 
            splitContainer10.Dock = DockStyle.Fill;
            splitContainer10.Location = new Point(0, 0);
            splitContainer10.Name = "splitContainer10";
            splitContainer10.Orientation = Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            splitContainer10.Panel1.Controls.Add(splitContainer11);
            // 
            // splitContainer10.Panel2
            // 
            splitContainer10.Panel2.Controls.Add(PriorityCheckBox);
            splitContainer10.Size = new Size(619, 64);
            splitContainer10.SplitterDistance = 25;
            splitContainer10.TabIndex = 0;
            // 
            // splitContainer11
            // 
            splitContainer11.Dock = DockStyle.Fill;
            splitContainer11.Location = new Point(0, 0);
            splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            splitContainer11.Panel1.Controls.Add(FullnameLabel);
            // 
            // splitContainer11.Panel2
            // 
            splitContainer11.Panel2.Controls.Add(FullnameTextBox);
            splitContainer11.Size = new Size(619, 25);
            splitContainer11.SplitterDistance = 205;
            splitContainer11.TabIndex = 0;
            // 
            // PriorityCheckBox
            // 
            PriorityCheckBox.AutoSize = true;
            PriorityCheckBox.Location = new Point(2, 3);
            PriorityCheckBox.Name = "PriorityCheckBox";
            PriorityCheckBox.Size = new Size(92, 24);
            PriorityCheckBox.TabIndex = 0;
            PriorityCheckBox.Text = "is Priority";
            PriorityCheckBox.UseVisualStyleBackColor = true;
            PriorityCheckBox.CheckedChanged += PriorityCheckBox_CheckedChanged;
            // 
            // splitContainer12
            // 
            splitContainer12.Dock = DockStyle.Fill;
            splitContainer12.Location = new Point(0, 0);
            splitContainer12.Name = "splitContainer12";
            splitContainer12.Orientation = Orientation.Horizontal;
            // 
            // splitContainer12.Panel1
            // 
            splitContainer12.Panel1.Controls.Add(AddressControl1);
            splitContainer12.Size = new Size(619, 456);
            splitContainer12.SplitterDistance = 213;
            splitContainer12.TabIndex = 13;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CustomersTab";
            Size = new Size(934, 585);
            Load += CustomersTab_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel1.PerformLayout();
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            splitContainer8.Panel1.ResumeLayout(false);
            splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer8).EndInit();
            splitContainer8.ResumeLayout(false);
            splitContainer9.Panel1.ResumeLayout(false);
            splitContainer9.Panel1.PerformLayout();
            splitContainer9.Panel2.ResumeLayout(false);
            splitContainer9.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer9).EndInit();
            splitContainer9.ResumeLayout(false);
            splitContainer10.Panel1.ResumeLayout(false);
            splitContainer10.Panel2.ResumeLayout(false);
            splitContainer10.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer10).EndInit();
            splitContainer10.ResumeLayout(false);
            splitContainer11.Panel1.ResumeLayout(false);
            splitContainer11.Panel1.PerformLayout();
            splitContainer11.Panel2.ResumeLayout(false);
            splitContainer11.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer11).EndInit();
            splitContainer11.ResumeLayout(false);
            splitContainer12.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer12).EndInit();
            splitContainer12.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Label CustomersLabel;
        private ListBox CustomersListBox;
        private Button AddButton;
        private Button RemoveButton;
        private Label SelectedCustomerLabel;
        private Label FullnameLabel;
        private TextBox IDTextBox;
        private TextBox FullnameTextBox;
        private Button AddRandomButton;
        private AddressControl AddressControl1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private SplitContainer splitContainer6;
        private SplitContainer splitContainer7;
        private Label IDLabel;
        private SplitContainer splitContainer8;
        private SplitContainer splitContainer9;
        private SplitContainer splitContainer10;
        private SplitContainer splitContainer11;
        private CheckBox PriorityCheckBox;
        private SplitContainer splitContainer12;
    }
}
