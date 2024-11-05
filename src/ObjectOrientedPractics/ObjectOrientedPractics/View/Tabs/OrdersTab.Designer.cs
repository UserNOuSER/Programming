namespace ObjectOrientedPractics
{
    partial class OrdersTab
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
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            OrdersLabel = new Label();
            OrdersDataGridView = new DataGridView();
            splitContainer2 = new SplitContainer();
            SelectedOrderLabel = new Label();
            splitContainer4 = new SplitContainer();
            splitContainer11 = new SplitContainer();
            label3 = new Label();
            IDTextBox = new TextBox();
            splitContainer5 = new SplitContainer();
            splitContainer12 = new SplitContainer();
            label4 = new Label();
            DatetimeTextBox = new TextBox();
            splitContainer6 = new SplitContainer();
            splitContainer13 = new SplitContainer();
            label5 = new Label();
            OrderStatusComboBox = new ComboBox();
            splitContainer7 = new SplitContainer();
            addressControl1 = new AddressControl();
            splitContainer8 = new SplitContainer();
            label6 = new Label();
            splitContainer9 = new SplitContainer();
            OrdersListBox = new ListBox();
            splitContainer10 = new SplitContainer();
            label7 = new Label();
            AmountNumberLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer11).BeginInit();
            splitContainer11.Panel1.SuspendLayout();
            splitContainer11.Panel2.SuspendLayout();
            splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer12).BeginInit();
            splitContainer12.Panel1.SuspendLayout();
            splitContainer12.Panel2.SuspendLayout();
            splitContainer12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer13).BeginInit();
            splitContainer13.Panel1.SuspendLayout();
            splitContainer13.Panel2.SuspendLayout();
            splitContainer13.SuspendLayout();
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
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(982, 635);
            splitContainer1.SplitterDistance = 392;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(OrdersLabel);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(OrdersDataGridView);
            splitContainer3.Size = new Size(392, 635);
            splitContainer3.SplitterDistance = 28;
            splitContainer3.TabIndex = 1;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Dock = DockStyle.Fill;
            OrdersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OrdersLabel.Location = new Point(0, 0);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(56, 20);
            OrdersLabel.TabIndex = 0;
            OrdersLabel.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Dock = DockStyle.Fill;
            OrdersDataGridView.Location = new Point(0, 0);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.Size = new Size(392, 603);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(SelectedOrderLabel);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer4);
            splitContainer2.Size = new Size(586, 635);
            splitContainer2.SplitterDistance = 28;
            splitContainer2.TabIndex = 0;
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Dock = DockStyle.Fill;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectedOrderLabel.Location = new Point(0, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(111, 20);
            SelectedOrderLabel.TabIndex = 0;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.IsSplitterFixed = true;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(splitContainer11);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(splitContainer5);
            splitContainer4.Size = new Size(586, 603);
            splitContainer4.SplitterDistance = 29;
            splitContainer4.TabIndex = 0;
            // 
            // splitContainer11
            // 
            splitContainer11.Dock = DockStyle.Fill;
            splitContainer11.IsSplitterFixed = true;
            splitContainer11.Location = new Point(0, 0);
            splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            splitContainer11.Panel1.Controls.Add(label3);
            // 
            // splitContainer11.Panel2
            // 
            splitContainer11.Panel2.Controls.Add(IDTextBox);
            splitContainer11.Size = new Size(586, 29);
            splitContainer11.SplitterDistance = 195;
            splitContainer11.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // IDTextBox
            // 
            IDTextBox.Dock = DockStyle.Fill;
            IDTextBox.Location = new Point(0, 0);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(387, 27);
            IDTextBox.TabIndex = 0;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.IsSplitterFixed = true;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(splitContainer12);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(splitContainer6);
            splitContainer5.Size = new Size(586, 570);
            splitContainer5.SplitterDistance = 30;
            splitContainer5.TabIndex = 0;
            // 
            // splitContainer12
            // 
            splitContainer12.Dock = DockStyle.Fill;
            splitContainer12.IsSplitterFixed = true;
            splitContainer12.Location = new Point(0, 0);
            splitContainer12.Name = "splitContainer12";
            // 
            // splitContainer12.Panel1
            // 
            splitContainer12.Panel1.Controls.Add(label4);
            // 
            // splitContainer12.Panel2
            // 
            splitContainer12.Panel2.Controls.Add(DatetimeTextBox);
            splitContainer12.Size = new Size(586, 30);
            splitContainer12.SplitterDistance = 195;
            splitContainer12.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 0;
            label4.Text = "Created:";
            // 
            // DatetimeTextBox
            // 
            DatetimeTextBox.Dock = DockStyle.Fill;
            DatetimeTextBox.Location = new Point(0, 0);
            DatetimeTextBox.Name = "DatetimeTextBox";
            DatetimeTextBox.ReadOnly = true;
            DatetimeTextBox.Size = new Size(387, 27);
            DatetimeTextBox.TabIndex = 0;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.IsSplitterFixed = true;
            splitContainer6.Location = new Point(0, 0);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(splitContainer13);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(splitContainer7);
            splitContainer6.Size = new Size(586, 536);
            splitContainer6.SplitterDistance = 27;
            splitContainer6.TabIndex = 0;
            // 
            // splitContainer13
            // 
            splitContainer13.Dock = DockStyle.Fill;
            splitContainer13.IsSplitterFixed = true;
            splitContainer13.Location = new Point(0, 0);
            splitContainer13.Name = "splitContainer13";
            // 
            // splitContainer13.Panel1
            // 
            splitContainer13.Panel1.Controls.Add(label5);
            // 
            // splitContainer13.Panel2
            // 
            splitContainer13.Panel2.Controls.Add(OrderStatusComboBox);
            splitContainer13.Size = new Size(586, 27);
            splitContainer13.SplitterDistance = 195;
            splitContainer13.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 0;
            label5.Text = "Status:";
            // 
            // OrderStatusComboBox
            // 
            OrderStatusComboBox.Dock = DockStyle.Fill;
            OrderStatusComboBox.FormattingEnabled = true;
            OrderStatusComboBox.Location = new Point(0, 0);
            OrderStatusComboBox.Name = "OrderStatusComboBox";
            OrderStatusComboBox.Size = new Size(387, 28);
            OrderStatusComboBox.TabIndex = 0;
            OrderStatusComboBox.SelectedIndexChanged += OrderStatusComboBox_SelectedIndexChanged;
            // 
            // splitContainer7
            // 
            splitContainer7.Dock = DockStyle.Fill;
            splitContainer7.IsSplitterFixed = true;
            splitContainer7.Location = new Point(0, 0);
            splitContainer7.Name = "splitContainer7";
            splitContainer7.Orientation = Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(addressControl1);
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.Controls.Add(splitContainer8);
            splitContainer7.Size = new Size(586, 505);
            splitContainer7.SplitterDistance = 240;
            splitContainer7.TabIndex = 0;
            // 
            // addressControl1
            // 
            addressControl1.Dock = DockStyle.Fill;
            addressControl1.Location = new Point(0, 0);
            addressControl1.Margin = new Padding(3, 4, 3, 4);
            addressControl1.MinimumSize = new Size(0, 200);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(586, 240);
            addressControl1.TabIndex = 0;
            // 
            // splitContainer8
            // 
            splitContainer8.Dock = DockStyle.Fill;
            splitContainer8.IsSplitterFixed = true;
            splitContainer8.Location = new Point(0, 0);
            splitContainer8.Name = "splitContainer8";
            splitContainer8.Orientation = Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            splitContainer8.Panel1.Controls.Add(label6);
            // 
            // splitContainer8.Panel2
            // 
            splitContainer8.Panel2.Controls.Add(splitContainer9);
            splitContainer8.Size = new Size(586, 261);
            splitContainer8.SplitterDistance = 29;
            splitContainer8.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 0;
            label6.Text = "Order Items:";
            // 
            // splitContainer9
            // 
            splitContainer9.Dock = DockStyle.Fill;
            splitContainer9.IsSplitterFixed = true;
            splitContainer9.Location = new Point(0, 0);
            splitContainer9.Name = "splitContainer9";
            splitContainer9.Orientation = Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            splitContainer9.Panel1.Controls.Add(OrdersListBox);
            // 
            // splitContainer9.Panel2
            // 
            splitContainer9.Panel2.Controls.Add(splitContainer10);
            splitContainer9.Size = new Size(586, 228);
            splitContainer9.SplitterDistance = 149;
            splitContainer9.TabIndex = 0;
            // 
            // OrdersListBox
            // 
            OrdersListBox.Dock = DockStyle.Fill;
            OrdersListBox.FormattingEnabled = true;
            OrdersListBox.Location = new Point(0, 0);
            OrdersListBox.Name = "OrdersListBox";
            OrdersListBox.Size = new Size(586, 149);
            OrdersListBox.TabIndex = 0;
            // 
            // splitContainer10
            // 
            splitContainer10.Dock = DockStyle.Fill;
            splitContainer10.IsSplitterFixed = true;
            splitContainer10.Location = new Point(0, 0);
            splitContainer10.Name = "splitContainer10";
            splitContainer10.Orientation = Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            splitContainer10.Panel1.Controls.Add(label7);
            // 
            // splitContainer10.Panel2
            // 
            splitContainer10.Panel2.Controls.Add(AmountNumberLabel);
            splitContainer10.Size = new Size(586, 75);
            splitContainer10.SplitterDistance = 25;
            splitContainer10.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 0;
            label7.Text = "Amount:";
            // 
            // AmountNumberLabel
            // 
            AmountNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountNumberLabel.AutoSize = true;
            AmountNumberLabel.Font = new Font("Bahnschrift Condensed", 20F);
            AmountNumberLabel.Location = new Point(508, 0);
            AmountNumberLabel.Name = "AmountNumberLabel";
            AmountNumberLabel.Size = new Size(32, 41);
            AmountNumberLabel.TabIndex = 0;
            AmountNumberLabel.Text = "0";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "OrdersTab";
            Size = new Size(982, 635);
            Load += OrdersTab_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer11.Panel1.ResumeLayout(false);
            splitContainer11.Panel1.PerformLayout();
            splitContainer11.Panel2.ResumeLayout(false);
            splitContainer11.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer11).EndInit();
            splitContainer11.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer12.Panel1.ResumeLayout(false);
            splitContainer12.Panel1.PerformLayout();
            splitContainer12.Panel2.ResumeLayout(false);
            splitContainer12.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer12).EndInit();
            splitContainer12.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            splitContainer13.Panel1.ResumeLayout(false);
            splitContainer13.Panel1.PerformLayout();
            splitContainer13.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer13).EndInit();
            splitContainer13.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            splitContainer8.Panel1.ResumeLayout(false);
            splitContainer8.Panel1.PerformLayout();
            splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer8).EndInit();
            splitContainer8.ResumeLayout(false);
            splitContainer9.Panel1.ResumeLayout(false);
            splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer9).EndInit();
            splitContainer9.ResumeLayout(false);
            splitContainer10.Panel1.ResumeLayout(false);
            splitContainer10.Panel1.PerformLayout();
            splitContainer10.Panel2.ResumeLayout(false);
            splitContainer10.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer10).EndInit();
            splitContainer10.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer2;
        private DataGridView OrdersDataGridView;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private SplitContainer splitContainer6;
        private SplitContainer splitContainer7;
        private SplitContainer splitContainer8;
        private Label OrdersLabel;
        private Label SelectedOrderLabel;
        private SplitContainer splitContainer11;
        private Label label3;
        private TextBox IDTextBox;
        private SplitContainer splitContainer12;
        private Label label4;
        private TextBox DatetimeTextBox;
        private SplitContainer splitContainer13;
        private Label label5;
        private AddressControl addressControl1;
        private Label label6;
        private SplitContainer splitContainer9;
        private ListBox OrdersListBox;
        private SplitContainer splitContainer10;
        private Label label7;
        private Label AmountNumberLabel;
        private ComboBox OrderStatusComboBox;
    }
}
